using Microsoft.AspNetCore.Mvc;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v.1/")]
public class MedicoController : ControllerBase {

    private static readonly string[] Doctors = new[]
    {
        "Dr Alex", "Dr Guilherme", "Dra Caroline"
    };

     private readonly ILogger<MedicoController> _logger;

     public MedicoController(ILogger<MedicoController> logger){
        _logger = logger;
     }

      [HttpGet("medicos")]
     public IActionResult Get(){
        var medicos = Enumerable.Range(0, 3).Select(index => new Medico{
            Id = Guid.NewGuid(),
            Name = Doctors[index],
            Especialidade = "Clinico Geral"
        })
        .ToArray();
        return Ok(medicos);
     }

     [HttpDelete("/{id}")]
     public IActionResult Delete(Guid? id){
         if(id is null) return BadRequest();

        var medicos = Enumerable.Range(0, 3).Select(index => new Medico{
            Id = Guid.NewGuid(),
            Name = Doctors[index],
            Especialidade = "Clinico Geral"
        })
        .ToArray();
        var deletedDoctor = medicos[0].Id;
        id = deletedDoctor;
        var newMedicos = medicos.Where(m => m.Id != id);
        return Ok(newMedicos);
     }

     [HttpPut("/{id}")]
       public IActionResult Put(Guid? id){
         if(id is null) return BadRequest();

        var medicos = Enumerable.Range(0, 3).Select(index => new Medico{
            Id = Guid.NewGuid(),
            Name = Doctors[index],
            Especialidade = "Clinico Geral"
        })
        .ToArray();
        var updatedDoctor = medicos[0].Id;
        id = updatedDoctor;
        foreach(var medico in medicos){
            if(medico.Id == id){
                medico.Name = "Novo Nome";
            }
        }
        return Ok(medicos);
     }

     [HttpPost]
       public IActionResult Post(){
        var medicos = Enumerable.Range(0, 3).Select(index => new Medico{
            Id = Guid.NewGuid(),
            Name = Doctors[index],
            Especialidade = "Clinico Geral"
        })
        .ToArray();
        
       var newMedico = medicos.Append(new Medico{
            Id = Guid.NewGuid(),
            Name = "Dr Paulo",
            Especialidade = "Clinico Geral"
        });

        return Ok(newMedico);
     }
}
