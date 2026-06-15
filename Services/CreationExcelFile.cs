using ClosedXML.Excel;

namespace LAB13APAZA.Services;

public class CreationExcelFile
{
    public void FirstExample()
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Hoja1");

            worksheet.Cell(1, 1).Value = "Nombre";
            worksheet.Cell(1, 2).Value = "Edad";
            worksheet.Cell(2, 1).Value = "Juan";
            worksheet.Cell(2, 2).Value = 28;

            workbook.SaveAs("D:\\EmpresarialesAvanzados\\Lab13\\CreationExcelFile.xlsx");
        }
    }
}