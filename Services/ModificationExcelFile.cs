using ClosedXML.Excel;

namespace LAB13APAZA.Services;

public class ModificationExcelFile
{
    public void SecondExample()
    {
        using (var workbook = new XLWorkbook("D:\\EmpresarialesAvanzados\\Lab13\\CreationExcelFile.xlsx"))
        {
            var worksheet = workbook.Worksheet(1);
            worksheet.Cell(2, 2).Value = 30;
            workbook.Save();
        }
    }
}