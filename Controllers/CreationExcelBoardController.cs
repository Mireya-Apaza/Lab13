using Microsoft.AspNetCore.Mvc;
using LAB13APAZA.Services;

namespace LAB13APAZA.Controllers;

[ApiController]
[Route("api/create-excel-board")]
public class CreationExcelBoardController : ControllerBase
{
    [HttpPost("create")]
    public IActionResult GenerarTabla()
    {
        var excel = new CreationExcelBoard();
        excel.ThirdExample();

        return Ok("Tabla de excel generado correctamente");
    }
}