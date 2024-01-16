using TechMed_EFCore.Models;

var context = new TechMedContext();

var medico1 = new Medico{
    Nome = "Ricardo",
    CPF = "123.456.789-00",
    CRM =  "8523684",
    Especialidade = "Cardiologista",
    Salario =  30000,
};

var paciente1 = new Paciente{
    Nome = "Joaquim",
    CPF = "123.456.789-00",
    Telefone = "12345678",
};


context.AddRange(medico1, paciente1);
context.SaveChanges();
/* 
var atendimento1 = new Atendimento {
    DataHora = DateTime.Now,   
    Medico = medico1,
    Paciente = paciente1,
};

var atendimento2 = new Atendimento {
    DataHora = DateTime.Now,   
    Medico = medico1,
    Paciente = paciente1,
};

var atendimento3 = new Atendimento {
    DataHora = DateTime.Now,   
    Medico = medico1,
    Paciente = paciente1,
};

context.AddRange(atendimento1, atendimento2, atendimento3);
context.SaveChanges();


var exame1 = new Exame {
    Nome = "Exame de Sangue",
    Tipo = "Hemograma",
    Preco = 100,
    Atendimento = atendimento1
};


var exame2 = new Exame {
    Nome = "Exame de Urina",
    Tipo = "Pesquisa de Urina",
    Preco = 200,
    Atendimento = atendimento1
};

var exame3 = new Exame {
    Nome = "Exame de Hormônios",
    Tipo = "Pesquisa de Hormônios",
    Preco = 300,
    Atendimento = atendimento2
};

var exame4 = new Exame {
    Nome = "Exame de Colesterol",
    Tipo = "Pesquisa de Colesterol",
    Preco = 400,
    Atendimento = atendimento3
};

context.AddRange(exame1, exame2, exame3, exame4);
context.SaveChanges();
 */


/* Console.WriteLine($"Lendo todos os médicos no banco de dados");
foreach (var med in context.Medicos.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {med.Id} - Nome: {med.Nome} - CRM: {med.CRM}");
}

Console.WriteLine($"Lendo todos os pacientes no banco de dados");
foreach (var pac in context.Pacientes.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {pac.Id} - Nome: {pac.Nome} - CRM: {pac.CPF}");
}


Console.WriteLine($"Criar um médico no banco de dados");

var medico = new Medico{
    Nome = "Dr. Dexter",
    CPF = "123.456.789-00",
    CRM = "123456",
    Especialidade = "Clínico Geral",
    Salario = 10000
};
context.Medicos.Add(medico);

Console.WriteLine($"Criar um paciente no banco de dados");
var paciente = new Paciente{
    Nome = "Valber",
    CPF = "101.202.303-00",
    Endereco = "Rua A, 0",
    Telefone = "1234-5678"
};

context.Pacientes.Add(paciente);

context.SaveChanges();


Console.WriteLine($"Atualizando o nome de um paciente no banco de dados");
var doente = context.Pacientes.Where(p => p.CPF == "101.202.303-00").FirstOrDefault();
doente.Nome = "João";
context.Pacientes.Update(doente);

context.SaveChanges();

Console.WriteLine($"Removendo o primeiro médico no banco de dados");
var primeiroMedico = context.Medicos.FirstOrDefault();
context.Medicos.Remove(primeiroMedico);

context.SaveChanges();

Console.WriteLine($"Finalizando o programa");
 */


