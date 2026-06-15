using Microsoft.AspNetCore.Mvc;
using LAB13APAZA.Services;

namespace LAB13APAZA.Controllers;

[ApiController]
[Route("api/modification-excel-file")]
public class ModificationExcelFileController : ControllerBase
{
    [HttpPut("modify")]
    public IActionResult ModificarExcel()
    {
        var excel = new ModificationExcelFile();
        excel.SecondExample();

        return Ok("Excel modificado correctamente");
    }
}