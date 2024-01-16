namespace TechMed.WebAPI;

public class Medico
{
    public Guid Id { get; set; }
    required public string Name { get; set; }
    required public string Especialidade { get; set; }
}
