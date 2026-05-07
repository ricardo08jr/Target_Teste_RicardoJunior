namespace FaturaTrack.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using FaturaTrack.Api.Requests;
    using FaturaTrack.Application;

    [ApiController]
    [Route("api/[controller]")]
    public class FaturamentoController : ControllerBase
    {
        private readonly CalcularFaturamentoAnualUseCase _useCase;

        public FaturamentoController(CalcularFaturamentoAnualUseCase useCase)
        {
            _useCase = useCase;
        }

        [HttpPost("calcular")]
        public IActionResult Calcular([FromBody] FaturamentoRequest request)
        {
            if (request is null || request.Valores is null)
                return BadRequest("Dados inválidos.");

            var resultado = _useCase.Execute(request.Valores);
            return Ok(resultado);
        }
    }
}
