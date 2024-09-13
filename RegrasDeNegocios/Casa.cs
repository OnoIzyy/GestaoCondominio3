using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGestao.RegrasDeNegocios
{
    public class Casa
    {
        //atributos
        public int Numero { get; set; }
        public int IdCasa { get; set; }
        public string DescricaoVeiculo { get; set; }
        private int NumeroMaximoDePessoa = 7;
        private string Titular;
        


        //public double ValorCasa { get; set; }
        //public double ValorCondominio { get; set; }


        public string TipoCasa { get; set; }
        

      

        public List<Pessoa> Moradores { get; set; }
        //metodo construtor

        public Casa(int idCasa, int numeroCasa, string tipoCasa, string descricaoVeiculo)
        {
            this.Numero =numeroCasa ;
            this.TipoCasa = tipoCasa;
            this.IdCasa = idCasa;
            this.DescricaoVeiculo = descricaoVeiculo;
            
            Moradores = new List<Pessoa>();

        }
        public string VerificarTitular(string respostaTitular)
        {
            
            if (respostaTitular == "S")
            {
                Titular = "É PROPRIETARIO TITULAR";
            }
            else if (respostaTitular == "N")
            {
                Titular = "NÃO É PROPRIETARIO TITULAR";
            }
            return Titular;
        }

        public void CadastrarMoradores()
        {
            int contador = 0;
           
           
            while (contador <= 7)
            {
                Console.Clear();
                Console.WriteLine("------------- Cadastrar Moradores --------------\n");
                   
                     Pessoa morador= new Pessoa();

                    Console.Write("Nome:");
                    morador.Nome = Console.ReadLine();
                    Console.Write("Genero:");
                    morador.Genero = Console.ReadLine();
                    Console.Write("Data De Nascimento:");
                    morador.DataDeNascimento =Console.ReadLine();
                    Console.Write("CPF:");
                    morador.CPF = Console.ReadLine();
                    Console.Write("Renda:");
                    morador.Renda = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O morador é o titular da casa:");
                    string respostaTitular= Console.ReadLine().ToUpper();
                    morador.Titular =VerificarTitular(respostaTitular);
                    contador++;
                    
                    Console.WriteLine("Deseja continuar cadastrando???(S/n)");
                    var resp = Console.ReadLine().ToUpper();
                    if (resp == "N") break ;
                
            }

        }
        //public void ConsultarAlunos()
        //{
        //    int opc = 1;
        //    while (opc != 0)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("---------------- Consultar Aluno ---------------\n");
        //        Console.WriteLine($"Serie e Turma: {Serie}/{NomeTurma}");
        //        Console.Write("Nome:");
        //        var nome = Console.ReadLine().ToUpper();
        //        var aluno = AlunosMatriculados.Where(a => a.Nome.ToUpper() == nome).FirstOrDefault();
        //        if (aluno != null)
        //        {
        //            Console.WriteLine($"Nº Matricula: {aluno.NumeroMatricula}");
        //            Console.WriteLine($"Nome: {aluno.Nome}");
        //            Console.WriteLine($"1ª Nota: {aluno.Nota1}");
        //            Console.WriteLine($"2ª Nota: {aluno.Nota2}");
        //            Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        //            Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");

        //        }
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Yellow;
        //            Console.WriteLine("Aluno não encontrado!!!!!\n");
        //        }
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Deseja continuar consultando? (S/n)");
        //        var resp = Console.ReadLine().ToUpper();
        //        if (resp == "N") opc = 0;
        //    }

        //}//Fim do metodo consultar aluno
        //public void FiltarAlunos()
        //{
        //    Console.Clear();
        //    Console.WriteLine("---------------> Filtrar Alunos Por Nome <-------------------\n");
        //    Console.Write("Pesquisar Nome: ");
        //    string nomeAlunos = Console.ReadLine();
        //    var nomesAlunos = AlunosMatriculados.Where(h => h.Nome.ToUpper().Contains(nomeAlunos.ToUpper())).ToList();
        //    foreach (var aluno in nomesAlunos.OrderBy(h => h.Nome).ToList())
        //    {
        //        Console.WriteLine($"\nNº Matricula: {aluno.NumeroMatricula}");
        //        Console.WriteLine($"Nome: {aluno.Nome}");
        //        Console.WriteLine($"1ª Nota: {aluno.Nota1}");
        //        Console.WriteLine($"2ª Nota: {aluno.Nota2}");
        //        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        //        Console.WriteLine($"Situação: {aluno.VerificarSituacao()}");

        //    }
        //    Console.ReadKey();


        //}//Fim do metodo Filtrar Alunos
        //public void ListarTodosAlunos()
        //{
        //    Console.Clear();
        //    Console.WriteLine("---------------> Listar Todos os alunos da Turma <-------------------\n");
        //    Console.WriteLine("Selecione a turma:");

        //    foreach (var aluno in AlunosMatriculados.OrderBy(k => k.Nome).ToList())
        //    {
        //        Console.WriteLine($"Nº Matricula: {aluno.NumeroMatricula}");
        //        Console.WriteLine($"Nome: {aluno.Nome}");
        //        Console.WriteLine($"1ª Nota: {aluno.Nota1}");
        //        Console.WriteLine($"2ª Nota: {aluno.Nota2}");
        //        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        //        Console.WriteLine($"Situação: {aluno.VerificarSituacao()}\n");


        //    }
        //    Console.ReadKey();


        //}//Fim do metodo listar todos os alunos
        //public void ListarAlunosAprovados()
        //{
        //    Console.Clear();
        //    Console.WriteLine("---------------> Listar Alunos Aprovados  <-------------------\n");
        //    var alunosAprovados = AlunosMatriculados.Where(aluno => aluno.CalcularMedia() >= 60).ToList();
        //    foreach (var aluno in alunosAprovados.OrderBy(l => l.Nome).ToList())
        //    {
        //        Console.WriteLine($"Nº Matricula: {aluno.NumeroMatricula}");
        //        Console.WriteLine($"Nome: {aluno.Nome}");
        //        Console.WriteLine($"1ª Nota: {aluno.Nota1}");
        //        Console.WriteLine($"2ª Nota: {aluno.Nota2}");
        //        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        //        Console.WriteLine($"Situação: {aluno.VerificarSituacao()}\n");

        //    }
        //    Console.ReadKey();


        //}//Fim do metodo listar alunos aprovados
        //public void ListarAlunosReprovados()
        //{
        //    Console.Clear();
        //    Console.WriteLine("---------------> Listar Alunos Reprovados  <-------------------\n");
        //    var alunosReprovados = AlunosMatriculados.Where(aluno => aluno.CalcularMedia() < 60).ToList();
        //    foreach (var aluno in alunosReprovados.OrderBy(l => l.Nome).ToList())
        //    {
        //        Console.WriteLine($"Nº Matricula: {aluno.NumeroMatricula}");
        //        Console.WriteLine($"Nome: {aluno.Nome}");
        //        Console.WriteLine($"1ª Nota: {aluno.Nota1}");
        //        Console.WriteLine($"2ª Nota: {aluno.Nota2}");
        //        Console.WriteLine($"Média: {aluno.CalcularMedia()}");
        //        Console.WriteLine($"Situação: {aluno.VerificarSituacao()}\n");

        //    }
        //    Console.ReadKey();


        //}//Fim do metodo listar alunos reprovados
        //public void EstatisticaDaTurma()
        //{
        //    double alunosAprovados = AlunosMatriculados.Where(aluno => aluno.CalcularMedia() >= 60).Count();
        //    double alunosTotal = AlunosMatriculados.Count();
        //    double alunosReprovados = AlunosMatriculados.Where(aluno => aluno.CalcularMedia() < 60).Count();
        //    double estatisticaApro = (alunosAprovados / alunosTotal) * 100;
        //    double estatisticaRepro = (alunosReprovados / alunosTotal) * 100;
        //    Console.WriteLine($" A porcentagem de alunos Aprovados é de  {estatisticaApro}%");
        //    Console.WriteLine($" A porcentagem de alunos Reprovados é de  {estatisticaRepro}%");
        //    Console.ReadKey();

        //}//Fim do metodo estatistico




    }//SalaDeAula
}

    