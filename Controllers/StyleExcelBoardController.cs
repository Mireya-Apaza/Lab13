using Microsoft.AspNetCore.Mvc;
using LAB13APAZA.Services;

namespace LAB13APAZA.Controllers;

[ApiController]
[Route("api/style-excel-board")]
public class StyleExcelBoardController : ControllerBase
{
    [HttpPost("create")]
    public IActionResult GenerarTablaStyle()
    {
        var excel = new StyleExcelBoard();
        excel.FourthExample();

        return Ok("Tabla de excel con estilo generado correctamente");
    }
}