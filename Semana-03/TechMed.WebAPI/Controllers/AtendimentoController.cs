using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TechMed.WebAPI;
using TecnoMed.WebAPI;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class AtendimentoController : ControllerBase
{
    private readonly IOptions<OpeningTime> _openingTime;

    public AtendimentoController(IOptions<OpeningTime> openingTime){
        _openingTime = openingTime;
    }

   [HttpGet("atendimentos")]
   public IActionResult Get()
   {
    if(DateTime.Now.Hour >= _openingTime.Value.StartAt.Hours && DateTime.Now.Hour <= _openingTime.Value.EndAt.Hours){
        
    }
      var atendimento = Enumerable.Range(1, 5).Select(index => new Atendimento
        {
            AtendimentoId = index,
            DataHora = DateTime.Now,
            MedicoId = index,
            Medico = new Medico
            {
                Id = Guid.NewGuid(),
                Name = $"Medico {index}",
                Especialidade = "Clinico Geral"
            }
        })
        .ToArray();
      return Ok(atendimento);
   }
}
