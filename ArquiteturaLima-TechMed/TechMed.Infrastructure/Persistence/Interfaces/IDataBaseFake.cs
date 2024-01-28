namespace TechMed.Infrastructure.Persistence.Interface;
public interface IDataBaseFake {
    public IMedicoCollection MedicosCollection { get; set; }    
    public IPacienteCollection PacienteCollection { get; set; }    
    public IAtendimentoCollection AtendimentoCollection { get; set; }    
    public IExameCollection ExameCollection { get; set; }    
}
