using ClosedXML.Excel;
    
namespace LAB13APAZA.Services;

public class StyleExcelBoard
{
    public void FourthExample()
    {
        using (var workbook = new XLWorkbook())
        {
            var worksheet = workbook.Worksheets.Add("Estilos");
            
            var headerRow = worksheet.Row(1);
            headerRow.Style.Font.Bold = true;
            headerRow.Style.Fill.BackgroundColor = XLColor.Cyan;
            headerRow.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            worksheet.Cell(1, 1).Value = "ID";
            worksheet.Cell(1, 2).Value = "Nombre";
            worksheet.Cell(1, 3).Value = "Edad";
            
            worksheet.Cell(2, 1).Value = 1;
            worksheet.Cell(2, 2).Value = "Juan";
            worksheet.Cell(2, 3).Value = 28;
            
            workbook.SaveAs("D:\\EmpresarialesAvanzados\\Lab13\\StyleExcelBoard.xlsx");
        }
    }
}