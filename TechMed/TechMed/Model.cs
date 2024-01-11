using Microsoft.EntityFrameworkCore;

namespace TechMed_EFCore.Models;
public class TechMedContext : DbContext
{

    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connectionString = "server=localhost;user=techmed;password=123456;database=techmed";
        var serverVersion = ServerVersion.AutoDetect(connectionString);
        
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Medico>().ToTable("Medicos").HasKey(m => m.Id);
        modelBuilder.Entity<Paciente>().ToTable("Pacientes").HasKey(p => p.Id);
        modelBuilder.Entity<Atendimento>().ToTable("Antendimentos").HasKey(p => p.Id);

        modelBuilder.Entity<Atendimento>()
        .HasOne(a => a.Medico)
        .WithMany(m => m.Atendimentos)
        .HasForeignKey(a => a.MedicoId);

        modelBuilder.Entity<Atendimento>()
        .HasOne(a => a.Paciente)
        .WithMany(p => p.Atendimentos)
        .HasForeignKey(a => a.PacienteId);

        modelBuilder.Entity<Atendimento>()
        .HasMany(a => a.Exames)
        .WithOne(x => x.Atendimento)
        .HasForeignKey(a => a.AtendimentoId);
    }
}

public abstract class Pessoa{
    public int Id {get; set;}
    required public string Nome {get; set;}
    required public string CPF {get; set;}
}

public class Medico : Pessoa{
    required public string CRM {get; set;}
    required public string Especialidade {get; set;}
    public decimal Salario {get; set;}
    public List<Atendimento> Atendimentos { get; set; }
}

public class Paciente : Pessoa{
    public string? Endereco {get; set;}
    public string? Telefone {get; set;}
    public List<Atendimento> Atendimentos { get; set; }
}


public class Exame {
    public int Id { get; set; }
    required public string Nome { get; set; }
    public string Tipo { get; set; }
    public decimal Preco { get; set; }
    public int AtendimentoId { get; set; }
    public Atendimento Atendimento { get; set; }
}

public class Atendimento {
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public int MedicoId { get; set; }
    public int PacienteId { get; set; }
    public Medico Medico { get; set; }
    public Paciente Paciente { get; set; }
    public List<Exame> Exames { get; set; }
}

