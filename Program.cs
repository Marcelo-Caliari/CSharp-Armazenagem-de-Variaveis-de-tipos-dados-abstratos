using AttClasses.Classes;

Person[] people = new Person[]
{
    new userWorker{
        Nomezinho = "Diogenes"
        , Cargo = "Gerente"
        , Data_de_Aniversario = new DateTime(2009, 8, 28)
        , Genero_Sexo = "Masculino"
        , Setor_Trabalho = "Geral"
        , Contrato = new DateTime(2008, 2, 1)
        , Ganho_Salarial = 4500
    },

    new userSupervisor{
        Nomezinho = "Larissa"
        , Cargo = "Supervisor"
        , Data_de_Aniversario = new DateTime(1996, 7, 30)
        , Genero_Sexo = "Feminino"
        , Setor_Trabalho = "Recepção"
        , Contrato = new DateTime(2020, 7, 21)
        , Periodo = "Noturno"
    },

    new userSupervisor{
        Nomezinho = "Babadook"
        , Cargo = "Supervisor"
        , Data_de_Aniversario = new DateTime(1994, 6, 12)
        , Genero_Sexo = "Masculino"
        , Setor_Trabalho = "Produção"
        , Contrato = new DateTime(2011, 5, 8)
        , Periodo = "Diurno"
    },

    new userWorker{
        Nomezinho = "Jormungandr"
        , Cargo = "Funcionário"
        , Data_de_Aniversario = new DateTime(2003, 2, 20)
        , Genero_Sexo = "Masculino"
        , Setor_Trabalho = "Produção"
        , Contrato = new DateTime(2019, 3, 5)
        , Designado_Como = "Manutenção"
    },
    new userWorker{
        Nomezinho = "Judite"
        , Cargo = "Funcionário"
        , Data_de_Aniversario = new DateTime(2004, 5, 14)
        , Genero_Sexo = "Masculino"
        , Setor_Trabalho = "Recepção"
        , Contrato = new DateTime(2019, 2, 5)
        , Designado_Como = "Sistemas"
    },
    new userWorker{
        Nomezinho = "Marcelo"
        , Cargo = "Funcionário"
        , Data_de_Aniversario = new DateTime(1997, 3, 30)
        , Genero_Sexo = "Masculino"
        , Setor_Trabalho = "Recepção"
        , Contrato = new DateTime(2019, 5, 18)
        , Designado_Como = "Recepcionista"
    }

};

for(int i = 0; i < people.Length; i++)
{
   Console.WriteLine($"Pessoa {i + 1}:");
   Console.WriteLine($"Nomezinho: {people[i].Nomezinho}" + $" / Cargo: {people[i].Cargo}");

   Console.WriteLine($"Data de nascimento: {people[i].Data_de_Aniversario.ToShortDateString()}");
   Console.WriteLine($"Data de contratação: {people[i].Contrato.ToShortDateString()}");
   Console.WriteLine($"Gênero: {people[i].Genero_Sexo}");
   Console.WriteLine($"Setor_Trabalho: {people[i].Setor_Trabalho}");


   if(people[i] is userWorker)
   {
    userWorker manager = (userWorker)people[i];
    Console.WriteLine($"Salário: {manager.Ganho_Salarial}");
   }
   else if (people[i] is userSupervisor)
   {
    userSupervisor supervisor = (userSupervisor)people[i];
    Console.WriteLine($"Período de trabalho: {supervisor.Periodo}");
   }
   else if (people[i] is userWorker)
   {
    userWorker operario = (userWorker)people[i];
    Console.WriteLine($"Função: {operario.Designado_Como}");
   }

   Console.WriteLine();
}
