using Microsoft.AspNetCore.Mvc;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicoController : ControllerBase {

    private static readonly string[] Doctors = new[]
    {
        "Dr Alex", "Dr Guilherme", "Dra Caroline"
    };

     private readonly ILogger<MedicoController> _logger;

     public MedicoController(ILogger<MedicoController> logger){
        _logger = logger;
     }

      [HttpGet(Name = "GetMedico")]
    
     public IEnumerable<Medico> Get(){
        return Enumerable.Range(0, 3).Select(index => new Medico{
            Name = Doctors[index],
            Especialidade = "Clinico Geral"
        })
        .ToArray();
     }

}
