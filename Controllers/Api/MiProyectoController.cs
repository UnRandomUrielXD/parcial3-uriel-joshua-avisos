using Microsoft.AspNetCore.Mvc;

[Route("api/mi-proyecto")]
public class MiProyectoController : ControllerBase {

    [HttpGet("integrantes")]
    public ActionResult<MiProyecto> Integrantes() {
        var integrantes = new MiProyecto {
            NombreIntegrante1 = "Uriel Fermin",
            NombreIntegrante2 = "Joshua Ricardo"
        };
        return Ok(integrantes);
    }
}