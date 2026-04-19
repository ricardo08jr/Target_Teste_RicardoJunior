namespace Target_Teste.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Target_Teste.Api.Requests;
    using Target_Teste.Application;

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
