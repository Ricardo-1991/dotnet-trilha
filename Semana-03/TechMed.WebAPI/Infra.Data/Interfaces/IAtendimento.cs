using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data.Interfaces;
public interface IAtendimento {
   void Create(Atendimento atendimento);
   ICollection<Atendimento> GetAll();
   Atendimento? GetById(int id);
   void Update(int id, Atendimento atendimento);
   void Delete(int id);
}
