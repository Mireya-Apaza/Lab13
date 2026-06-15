using Microsoft.AspNetCore.Mvc;
using LAB13APAZA.Services;

namespace LAB13APAZA.Controllers;

[ApiController]
[Route("api/create-excel-file")]
public class CreationExcelFileController : ControllerBase
{
    [HttpPost("create")]
    public IActionResult GenerarExcel()
    {
        var excel = new CreationExcelFile();
        excel.FirstExample();

        return Ok("Excel generado correctamente");
    }
}