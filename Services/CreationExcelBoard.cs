using ClosedXML.Excel;

namespace LAB13APAZA.Services;

public class CreationExcelBoard
{
    public void ThirdExample()
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Datos");
            worksheet.Cell(1, 1).Value = "ID";
            worksheet.Cell(1, 2).Value = "Nombre";
            worksheet.Cell(1, 3).Value = "Edad";
            
            worksheet.Cell(2, 1).Value = 1;
            worksheet.Cell(2, 2).Value = "Juan";
            worksheet.Cell(2, 3).Value = 28;
            
            worksheet.Cell(3, 1).Value = 2;
            worksheet.Cell(3, 2).Value = "María";
            worksheet.Cell(3, 3).Value = "34";
            
            var range = worksheet.Range("A1:C3");
            range.CreateTable();
            
            workbook.SaveAs("D:\\EmpresarialesAvanzados\\Lab13\\CreationExcelBoard.xlsx");
        }
    }
}