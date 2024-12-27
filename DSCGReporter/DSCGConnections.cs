using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace DSCGReporter
{
    public static class DSCGConnections
    {
        public static string Database;
        public static string ServerAddr;

        public static SqlConnection HomeCatConn;
        public static SqlConnection RemoteCatConn;
        public static SqlConnection GDBConnection;

        private static string RemoteServer;

        public static void ConnectToGDB(string Database)
        {
            string connString = "Data Source=" + RemoteServer + ";Persist Security Info=True;User ID=DSCG;Password=DSCG;Initial Catalog=" + Database;
            GDBConnection = new SqlConnection(connString);
            GDBConnection.Open();
        }

        public static void ConnectToHomeCatalog()
        {
            string connString = ReadConfConnString() + "Persist Security Info=True;User ID=DSCG;Password=DSCG;Initial Catalog=DSCGSystem";
            HomeCatConn = new SqlConnection(connString);
            HomeCatConn.Open();
        }
        private static string ReadConfConnString()
        {
            string line = "";
            string textFile = "DSCG.conf";
            if (File.Exists(textFile)) {
                string[] lines = File.ReadAllLines(textFile);
                line = lines[0];
            }
            return line;
        }
        private static string GetProvider(string confString)
        {
            return GetBetween(confString, "Provider=", ";");
        }
        public static void ConnectToRemoteCatalog(string remoteServer)
        {
            RemoteServer = remoteServer;
            string connString = "Data Source=" + remoteServer + ";Persist Security Info=True;User ID=DSCG;Password=DSCG;Initial Catalog=DSCGSystem";
            RemoteCatConn = new SqlConnection(connString);
            RemoteCatConn.Open();
        }
        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }
    }
}

