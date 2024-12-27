using DevExpress.Spreadsheet;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace DSCGReporter
{
    public partial class ReserveReports
    {
        const string BalanceReservesTemplate = "BalanceReserves1.xltx";
        const string BalanceReservesFileName = "..\\Балансовые запасы.xlsx";
        const string BalanceReservesProcedureName = "Reserves2";

        const string ComReservesTemplate = "ComReserves1.xltx";
        const string ComReservesFileName = "..\\Промышленные запасы.xlsx";
        const string ComReservesProcedureName = "ReservesCom2";

        const int firstSeamsRow = 4;
        const int firstParametersRow = 4;
        const int firstBalanceDetailRow = 6;
        const int firstBalanceSummaryRow = 10;
        const int firstComDetailRow = 5;
        const int firstComSummaryRow = 5;

        const int BoundaryLevel = 3;
        const int BlockLevel = 8;
        const int CoalgradeLevel = 7;
        const int SeamTotalLevel = 11;
        const int BoundaryTotalLevel = 13;
        const int CoalTypeTotalLevel = 16;
        const int CoalGradeTotalLevel = 17;
        const int GrandTotalLevel = 101;
        const int BoundaryGrandTotalLevel = 103;
        const int CoalTypeGrandTotalLevel = 106;
        const int CoalGradeGrandTotalLevel = 107;

        public string ReportKind { get; set; }
        public IEnumerable Variants { get; set; }
        public int ReportType { get; set; }
        public int? SeamId { get; set; }
        public int VersionId { get; set; }
        public int? Boundary { get; set; }
        public int? Attribute { get; set; }

        public Workbook workbook;
        string outputFileName = string.Empty;
        int summaryTableWidth;

        private int firstDetailRow;
        private int firstSummaryRow;

        private void CreateWorkbook(string excelTemplate)
        {
            workbook = new Workbook();
            workbook.Unit = DevExpress.Office.DocumentUnit.Point;
            workbook.LoadDocument(excelTemplate, DocumentFormat.Xltx);
            //workbook.Options.Culture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU");
        }


        private void ExportParametersToExcel()
        {
            int firstRecord = 3;
            var paramSheet = workbook.Worksheets["Параметры"];
            var reservesParameters = Data.GetReservesParameters();

            var importOptions = new DataSourceImportOptions();
            paramSheet.Import(reservesParameters, false, firstRecord, 0, importOptions);
        }
        private void ExportSeamsToExcel()
        {
            int firstRecord = 4;
            var worksheet = workbook.Worksheets["Пласты"];
            DataTable seams = Data.GetfSeams();

            var importOptions = new DataSourceImportOptions
            {
                ImportFormulas = true,
                FormulaCulture = new System.Globalization.CultureInfo("en-EN", true)
            };
            worksheet.Import(seams, false, firstRecord - 1, 0, importOptions);
        }
    }
}

