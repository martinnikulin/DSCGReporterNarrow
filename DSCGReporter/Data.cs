using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCGReporter
{
    class Data
    {
        public static DataTable GetServers()
        {
            string sql = "select Id, ServerName, LocalServer, RemoteServer from Servers";
            return GetTable(DSCGConnections.HomeCatConn, sql);
        }

        public static DataTable GetProjects()
        {
            string sql = "select Id as ProjectId, ProjectName, [Database] from Projects" +
                " where Actual = 1 and not [Database] = 'GDB50'";
            return GetTable(DSCGConnections.RemoteCatConn, sql);
        }
        public static DataTable GetSeams()
        {
            string sql = "select SeamId, Description as SeamName from Seams where Actual = 1 and SeamId <> 0 order by N";
            return GetTable(DSCGConnections.GDBConnection, sql);
        }
        public static DataTable GetVariants(int ReportType)
        {
            string sql = "select ConditionId, NVariant, " +
            "case " +
            "when ParamValue = 1 and " + ReportType + " = 1 then VariantName1 " +
            "when ParamValue = 1 and " + ReportType + " = 2 then VariantName2 " +
            "when ParamValue = 2 then VariantName2 " +
            "end as VariantName " +
            "from		Variants " +
            "cross join	Settings s " +
            "where		s.Section = 'Database' and " +
            "			s.ParamName = 'GDBType' " +
            "order by	NVariant";
            return GetTable(DSCGConnections.GDBConnection, sql);
        }
        public static DataTable GetReservesParameters()
        {
            string sql = "select H, Beta, A, B, PTransportBVR, Krovla1, Krovla2, Krovla3, Pochva, Okont, Verch, ZasorKrovla, ZasorPochva, WorkType from ResParams";
            return GetTable(DSCGConnections.GDBConnection, sql);
        }
        public static DataTable GetfSeams()
        {
            string sql = "select * from fSeams(4)";
            return GetTable(DSCGConnections.GDBConnection, sql);
        }
        public static void GetReservesTables(string sql, out DataTable reserves, out DataTable summary)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DSCGConnections.GDBConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            reserves = dataSet.Tables[0];
            summary = dataSet.Tables[1];
        }
        private static DataTable GetTable(SqlConnection connection, string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            return dataSet.Tables[0];
        }
    }
}
