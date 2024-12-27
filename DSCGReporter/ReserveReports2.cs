using DevExpress.Export.Xl;
using DevExpress.Spreadsheet;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace DSCGReporter
{
    public partial class ReserveReports
    {
        internal void CreateReport(IEnumerable Variants, IEnumerable Seams)
        {
            bool reportDone = false;
            string sql = "";

            if (ReportKind == "BalanceReserves")
            {
                outputFileName = BalanceReservesFileName;
                summaryTableWidth = 15;
                firstDetailRow = 6;
                firstSummaryRow = 10;
                CreateWorkbook(BalanceReservesTemplate);
                reportDone = ExportReservesToExcel("Reserves2", Seams, Variants);
            }
            else
            {
                outputFileName = ComReservesFileName;
                summaryTableWidth = 13;
                firstDetailRow = 5;
                firstSummaryRow = 5;
                CreateWorkbook(ComReservesTemplate);
                ExportParametersToExcel();
                ExportSeamsToExcel();
                reportDone = ExportReservesToExcel("ReservesCom2", Seams, Variants);
            }

            if (reportDone)
            {
                workbook.Worksheets.Remove(workbook.Worksheets["Подсчет"]);
                workbook.Worksheets.Remove(workbook.Worksheets["Свод"]);
                SaveWorkbook();
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                MessageBox.Show("Нет записей для вывода");
            }
        }
        private void SaveWorkbook()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveDocument(saveFileDialog.FileName, DocumentFormat.Xlsx);
            }
        }
        private bool ExportReservesToExcel(string procedureName, IEnumerable Seams, IEnumerable Variants)
        {
            bool reportIsEmpty = true;

            foreach (ListViewItem v in Variants) 
            {
                int variant = Convert.ToInt32(v.Text);
                string variantName = v.SubItems[1].Text;
                string sql = GetSQL(procedureName, variant, Seams);
                Data.GetReservesTables(sql, out DataTable reserves, out DataTable summary);

                if (reserves.Rows.Count > 1)
                {
                    WriteVariant(variantName, reserves, summary);
                    reportIsEmpty = false;
                }
            }
            return !reportIsEmpty;
        }
        private string GetSQL(string procedureName, int Variant, IEnumerable Seams)
        {
            string sql = "declare @Seams \"int[]\";";
            string seamList = "";
            foreach (ListViewItem seam in Seams)
            {
                seamList = seamList + "(" + seam.SubItems[1].Text + "),";
            }
            sql = sql + "insert into @Seams values " + seamList.Substring(0, seamList.Length - 1) + "; ";
            sql = sql + "exec " + procedureName + " " + ReportType.ToString() + ", " + Variant.ToString() + ", @Seams, 1";
            return sql;
        }
        private void WriteVariant(string variantName, DataTable reserves, DataTable summary)
        {
            Worksheet detailWorksheet = workbook.Worksheets.Add("Подсчет " + variantName.Trim());
            detailWorksheet.CopyFrom(workbook.Worksheets["Подсчет"]);

            Worksheet summaryWorksheet = workbook.Worksheets.Add("Свод " + variantName.Trim());
            summaryWorksheet.CopyFrom(workbook.Worksheets["Свод"]);

            WriteTableToExcel("details", reserves, workbook, detailWorksheet, firstDetailRow);
            WriteTableToExcel("summary", summary, workbook, summaryWorksheet, firstSummaryRow);
        }

        private void WriteTableToExcel(string reportPart, DataTable reserves, Workbook workbook, Worksheet worksheet, int firstExcelRow)
        {
            workbook.BeginUpdate();
            try
            {
                for (int i = 0; i <= reserves.Rows.Count - 1; i++)
                {
                    DataRow dataRow = reserves.Rows[i];
                    int level = Convert.ToInt32(dataRow[reserves.Columns.Count - 1]);
                    int excelRow = i + firstExcelRow - 1;

                    for (int columnIndex = 0; columnIndex < reserves.Columns.Count; columnIndex++)
                        WriteValueToCell(worksheet, dataRow, excelRow, columnIndex);

                    if (reportPart == "details")
                        FormatDetailRow(worksheet, level, excelRow);
                    else
                        FormatSummaryRow(worksheet, level, excelRow, summaryTableWidth);
                }
                CellRange range1 = worksheet.GetUsedRange();
                range1.Borders.SetAllBorders(XlColor.DefaultForeground, BorderLineStyle.Thin);
            }
            finally
            {
                workbook.EndUpdate();
            }
        }

        private static void WriteValueToCell(Worksheet worksheet, DataRow dataRow, int rowIndex, int columnIndex)
        {
            if (!(dataRow[columnIndex] == DBNull.Value || dataRow[columnIndex].ToString() == string.Empty))
            {
                //var cultureInfo = new System.Globalization.CultureInfo("ru-RU");
                //var fec = new FormulaEvaluationContext();
                //fec.Culture = cultureInfo;



                if (dataRow[columnIndex].GetType() == (typeof(string)))
                {
                    worksheet[rowIndex, columnIndex].Value = dataRow[columnIndex].ToString();
                }
                else if (dataRow[columnIndex].GetType() == (typeof(decimal)))
                {
                    worksheet[rowIndex, columnIndex].Value = Convert.ToDouble(dataRow[columnIndex]);
                }
                if (dataRow[columnIndex].ToString().Substring(0, 1) == "=")
                {
                    worksheet[rowIndex, columnIndex].Formula = dataRow[columnIndex].ToString();
                }
            }
        }

        private static void FormatDetailRow(Worksheet worksheet, int level, int excelRow)
        {
            if (level <= CoalgradeLevel || level >= SeamTotalLevel)
            {
                worksheet.Range.FromLTRB(0, excelRow, 0, excelRow).Font.Bold = true;
                worksheet.Range.FromLTRB(0, excelRow, 0, excelRow).Font.Size = 11;
            }
            if (level <= CoalgradeLevel)
            {
                worksheet.MergeCells(worksheet.Range.FromLTRB(0, excelRow, 28, excelRow));
            }
            if ((level >= SeamTotalLevel && level <= CoalTypeTotalLevel) || (level >= GrandTotalLevel && level <= CoalTypeGrandTotalLevel))
                worksheet.MergeCells(worksheet.Range.FromLTRB(0, excelRow, 14, excelRow));
            if (level == CoalGradeTotalLevel || level == CoalGradeGrandTotalLevel)
                worksheet.MergeCells(worksheet.Range.FromLTRB(2, excelRow, 13, excelRow));
        }

        private static void FormatSummaryRow(Worksheet worksheet, int level, int excelRow, int tableWidth)
        {
            if (level <= CoalgradeLevel || level >= SeamTotalLevel)
            {
                worksheet.Range.FromLTRB(0, excelRow, 0, excelRow).Font.Bold = true;
                worksheet.Range.FromLTRB(0, excelRow, 0, excelRow).Font.Size = 11;
            }
            if (level == 1 || level == 101)
            {
                worksheet.MergeCells(worksheet.Range.FromLTRB(0, excelRow, tableWidth, excelRow));
                worksheet.Rows[excelRow].Height = 30;
                worksheet.Rows[excelRow].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            }
            if (level == 3)
            {
                worksheet.Cells["A1"].Alignment.WrapText = true;
            }
            if (!(level == CoalGradeTotalLevel || level == CoalGradeGrandTotalLevel))
            {
                worksheet.MergeCells(worksheet.Range.FromLTRB(0, excelRow, 1, excelRow));
            }
        }
    }
}
