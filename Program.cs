using AppGestao.RegrasDeNegocios;
List<Casa> casas  = new List<Casa>();

int contador = 1;
int opcao  = 1;
double valorCasa = 0;
string descricaoVeiculo = null;

while(contador != 0)
{
    Console.Clear();
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- + *");
    Console.WriteLine("\t\t* +                                      JAVA                                       * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.WriteLine("\t\t* +                               IZIANY E MARIA EDUARDA                            * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.WriteLine("\t\t* +                      1 - Cadastrar uma casa nova                                * +");
    Console.WriteLine("\t\t* +                      2 - Cadastrar moradores em uma casa                        * +");
    Console.WriteLine("\t\t* +                      3 - Consultar moradores de uma casa                        * +");
    Console.WriteLine("\t\t* +                      4 - Consultar morador pelo nome                            * +");
    Console.WriteLine("\t\t* +                      5 - Filtrar moradores por nome                             * +");
    Console.WriteLine("\t\t* +                      6 - Filtrar moradores por salário                          * +");
    Console.WriteLine("\t\t* +                      7 - Filtrar moradores por tipo de casa                     * +");
    Console.WriteLine("\t\t* +                      8 - Mostrar o percentual de moradores por tipo de casa     * +");
    Console.WriteLine("\t\t* +                      9 - Listar todos os moradores titulares                    * +");
    Console.WriteLine("\t\t* +                      0 - Sair do sistema                                        * +");
    Console.WriteLine("\t\t* + ------------------------------------------------------------------------------- * +");
    Console.Write("                Opção N°..............");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            CadastrarCasa();
            break;
        case 2:
            var casa = SelecionarCasa();
            if (casa != null) casas.Where(casa => casa == SelecionarCasa()).FirstOrDefault().CadastrarMoradores();
            break;
    }
}
void CadastrarCasa()
{
    int contador = 0;
    while (contador > 450)
    {
            Console.Clear();
            Console.WriteLine("------------- Cadastrar Casa -------------\n");
            Console.Write("Casa Numero.........: ");
            int numeroCasa = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite um nome simbolico para a casa (exemplo = 'CASA 1'):");
            //var nomeCasa = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\t |      Tipos de Casa    |");
            Console.WriteLine("\t | 1- Casa Basica        |");
            Console.WriteLine("\t | 2- Casa Padrão        |");
            Console.WriteLine("\t | 3- Casa alto Padrão   |");
            Console.Write("Qual é o tipo da casa.........:");
            var tipoCasa = Console.ReadLine();

            if (tipoCasa == "1")
            {
                valorCasa = 300000;
                Console.WriteLine($"Casa Basica tem ser valor de{valorCasa.ToString("C2")} ");
            }
            else if (tipoCasa == "2")
            {
                valorCasa = 500000;
                Console.WriteLine($"Casa Padrão tem o valor de {valorCasa.ToString("C2")} ");
            }
            else if (tipoCasa == "3")
            {
                valorCasa = 700000;
                Console.WriteLine($"Casa Alto Padão tem o valor de {valorCasa.ToString("C2")}");
            }
            else
            {
                Console.WriteLine("Não temos esse tipo de casa");
                Console.ReadKey();
                break;
                
            }
            if(tipoCasa == "1" || tipoCasa == "2" || tipoCasa == "3")
            {
                Console.Clear();
                Console.Write("A casa terá algum veiculo (S/N).........? ");
                string respostaVeiculo = Console.ReadLine().ToUpper();
                if (respostaVeiculo == "S")
                {
                    Console.Write("Quantos Veiculos terá na casa.........? ");
                    int quantVeiculo = Convert.ToInt32(Console.ReadLine());
                    if (quantVeiculo == 1)
                    {
                        Console.Write("Digite o modelo e a placa do Veiculo.........: ");
                        descricaoVeiculo = Console.ReadLine(); 
                    }
                    else if (quantVeiculo == 2)
                    {
                        Console.Write("Digite o modelo e a placa do primeiro veiculo.........: ");
                        string veiculo1 = Console.ReadLine();
                        Console.Write("Digite o modelo e a placa do segundo veiculo.........: ");
                        string veiculo2 = Console.ReadLine();
                        descricaoVeiculo = $"{veiculo1} {veiculo2}";
                    }
                    else
                    {
                        Console.WriteLine("No condominio não permitimos mais do que 2 veiculos por casa");
                        Console.ReadKey();
                        
                    }
                    
                }
                else if (respostaVeiculo == "N")
                {
                    descricaoVeiculo = "não há veículos";

                }
            }
            Casa casa = new Casa(contador, numeroCasa, tipoCasa, descricaoVeiculo);
            casas.Add(casa);
            contador++;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("* + * + * + * + * + * + * + CASA CADASTRADA COM SUCESSO * + * + * + * + * + * + * +");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Deseja continuar cadastrando casa? (S/N).....: ");
            var RespsPararCadastrar = Console.ReadLine().ToUpper();
            if (RespsPararCadastrar == "N") break;
            
            
        
    }
}// fim da função cadastrar casa
Casa SelecionarCasa()
{
    Console.Clear();
    Console.WriteLine("* + * + * + * + * + * + * + SELECIONAR TURMA * + * + * + * + * + * + * +");
    Console.WriteLine();
    Console.Write("Digite o numero da casa:.....................: ");
    int numeroCasa= Convert.ToInt32(Console.ReadLine());
    var casaSelecionada = casas.Where(casas => casas.Numero == numeroCasa).FirstOrDefault();// o var tava errado
    if (casaSelecionada == null)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--> CASA NÃO ENCONTRADA <--");
        Console.ReadKey();

    }
    Console.ForegroundColor = ConsoleColor.White;
    return casaSelecionada;
}
