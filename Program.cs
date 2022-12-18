using System;


class Program{

    public static string[] lerArq(string caminho){
        StreamReader sr1 = new StreamReader(caminho);
        int cont = 0;
        string linha1 = sr1.ReadLine();

        while(linha1 != null){
            cont++;
            linha1 = sr1.ReadLine();
        }
        sr1.Close();

        StreamReader sr2 = new StreamReader(caminho);
        string[] produtos = new string[cont];
        string linha2 = sr2.ReadLine();
        
        for(int i = 0; i < cont; i++){
            produtos[i] = linha2;
            linha2 = sr2.ReadLine(); 
        }
        sr2.Close();
        return produtos;
    }

    public static void gerarArqVenda(string[,] registroMesVenda){
        StreamWriter sw = new StreamWriter(@".\relatorio_vendas.txt");

        int pA = 0, pB = 0, pC = 0, pD = 0;

        for(int i = 0; i < 30; i++){
            for(int j = 0; j < 4; j++){
                pA+=Convert.ToInt32(registroMesVenda[i,0]);
                pB+=Convert.ToInt32(registroMesVenda[i,1]);
                pC+=Convert.ToInt32(registroMesVenda[i,2]);
                pD+=Convert.ToInt32(registroMesVenda[i,3]);
            }
        }

        sw.WriteLine("ProdutoA: " + pA + 
                     "\nProdutoB: " + pB +
                     "\nProdutoC: " + pC +
                     "\nProdutoD: " + pD);
        sw.Close();
    }

    public static void relatorioEstoque(string[] produtos){
        Console.WriteLine("/======= Relatório =======\\");
        for(int i = 0; i < produtos.Length; i++){
            Console.WriteLine("  " + produtos[i]);
        }
        Console.WriteLine("\\========================/");
    }

    public static void preencherRegMesVenda(string[] produtos, string[,] registroMesVenda){
        Random rdm = new Random();

        int pA = 0, pB = 0, pC = 0, pD = 0;

        for(int i = 0; i < 30; i++){
            for(int j = 0; j < produtos.Length; j++){
                registroMesVenda[i,j] = Convert.ToString(rdm.Next(0,10));
            }
        }       
    }

    public static void relatorioVenda(string[,] registroMesVenda){
        Console.WriteLine("       ProdutoA - ProdutoB - ProdutoC - ProdutoD");
        for(int i = 0; i < 30; i++){
            Console.Write("\nDia " + i + ": ");
            for(int j = 0; j < 4; j++){
                Console.Write("   " + registroMesVenda[i,j] + "       ");
            }
        }
    }

    public static void menuPrincipal(){
        Console.WriteLine("1 - [Registrar venda]");
        Console.WriteLine("2 - [Relatório de vendas]");
        Console.WriteLine("3 - [Relatório de estoque]");
        Console.WriteLine("4 - [Criar arquivo de vendas]");
        Console.WriteLine("5 - [Sair]");
    }

    public static void espacamento(){
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }

    public static void Main(string[] args){

        string caminho = @".\produtos.txt";

        bool run = true;
        int escolha = 0;

        string[,] registroMesVenda = new string[30,4];

        preencherRegMesVenda(lerArq(caminho), registroMesVenda);

        Console.WriteLine("==============================");
        Console.WriteLine("          Bem-Vindo(a)        ");
        Console.WriteLine("==============================");

        while(run){
            menuPrincipal();
            escolha = int.Parse(Console.ReadLine());
            switch(escolha){    
                case 1:
                    // string esc = "";

                    // gerarArqVenda(registroMesVenda);
                    // Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    // esc = Console.ReadLine();
                    // if(esc.ToLower() == "s"){
                    //     break;
                    // }
                    return;
                
                case 2:
                    string esc3 = "";

                    espacamento();
                    relatorioVenda(registroMesVenda);
                    Console.WriteLine("\nDeseja voltar para o menu? (s/n)");
                    
                    esc3 = Console.ReadLine();
                    if(esc3.ToLower() == "s"){
                        break;
                    }
                    return;
                
                case 3:
                    string esc4 = "";

                    espacamento();
                    relatorioEstoque(lerArq(caminho));
                    Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    esc4 = Console.ReadLine();
                    if(esc4.ToLower() == "s"){
                        break;
                    }
                    return;
                
                case 4:
                    string esc = "";

                    gerarArqVenda(registroMesVenda);
                    Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    esc = Console.ReadLine();
                    if(esc.ToLower() == "s"){
                        break;
                    }
                    return;
                
                case 5:
                    Console.WriteLine("Obrigado por utilizar a nossa aplicação! Volte sempre!");
                    run = false;
                    break;

                default:
                    Console.WriteLine("Comando Inválido! Digite novamente: ");
                    break;
            }
        }   
    }
}