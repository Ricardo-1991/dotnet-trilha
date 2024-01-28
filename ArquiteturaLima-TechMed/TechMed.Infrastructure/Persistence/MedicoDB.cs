using TechMed.Infrastructure.Persistence.Interface;
using TechMed.Core.Entities;
using System.Security.Cryptography;
namespace TechMed.Infrastructure.Persistence;
public class MedicoDB : IMedicoCollection {
    private readonly List<Medico> _medicos = new List<Medico>();
   private int _id = 2;

   public MedicoDB(){
    _medicos.Add(new Medico{MedicoId = 1, Nome = "Dr.House"});
    _medicos.Add(new Medico{MedicoId = 2, Nome = "Dr.Dexter"});
   }

   public int Create(Medico medico){
      if(_medicos.Count > 0){
        _id = _medicos.Max(m => m.MedicoId);
        medico.MedicoId = _id;
      }
       _medicos.Add(medico);
       return medico.MedicoId;
   }
   public ICollection<Medico> GetAll(){
      return _medicos.ToArray();
   }
   
   public Medico? GetById(int id){
      return _medicos.FirstOrDefault(m => m.MedicoId == id);
   }

   public void Update(int id, Medico medico){
      var medicoDB = _medicos.FirstOrDefault(m => m.MedicoId == id); 
      if(medicoDB is not null){
        medicoDB.Nome = medico.Nome;
      }
   }

   public void Delete(int id){
     _medicos.RemoveAll(m => m.MedicoId == id);
   }
}
