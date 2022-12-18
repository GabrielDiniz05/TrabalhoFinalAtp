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

    public static void relatorioEstoque(string[] produtos){
        Console.WriteLine("/======= Relatório =======\\");
        for(int i = 0; i < produtos.Length; i++){
            Console.WriteLine("  " + produtos[i]);
        }
        Console.WriteLine("\\========================/");
    }

    public static void menuPrincipal(){
        Console.WriteLine("1 - [Importar arquivo de produtos]");
        Console.WriteLine("2 - [Registrar venda]");
        Console.WriteLine("3 - [Relatório de vendas]");
        Console.WriteLine("4 - [Relatório de estoque]");
        Console.WriteLine("5 - [Criar arquivo de vendas]");
        Console.WriteLine("6 - [Sair]");
    }

    public static void Main(string[] args){

        string caminho = @".\produtos.txt";
        
        bool run = true;
        int escolha = 0;

        Console.WriteLine("==============================");
        Console.WriteLine("          Bem-Vindo(a)        ");
        Console.WriteLine("==============================");

        while(run){
            menuPrincipal();
            escolha = int.Parse(Console.ReadLine());
            switch(escolha){
                case 1:
                    // string esc = "";

                    // relatorioProdutos(lerArq(caminho));
                    // Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    // esc = Console.ReadLine();
                    // if(esc.ToLower() == "s"){
                    //     break;
                    // }
                    return;
                
                case 2:
                    // string esc = "";

                    // relatorioProdutos(lerArq(caminho));
                    // Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    // esc = Console.ReadLine();
                    // if(esc.ToLower() == "s"){
                    //     break;
                    // }
                    return;
                
                case 3:
                    // string esc = "";

                    // relatorioProdutos(lerArq(caminho));
                    // Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    // esc = Console.ReadLine();
                    // if(esc.ToLower() == "s"){
                    //     break;
                    // }
                    return;
                
                case 4:
                    string esc = "";

                    relatorioEstoque(lerArq(caminho));
                    Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    esc = Console.ReadLine();
                    if(esc.ToLower() == "s"){
                        break;
                    }
                    return;
                
                case 5:
                    // string esc = "";

                    // relatorioProdutos(lerArq(caminho));
                    // Console.WriteLine("Deseja voltar para o menu? (s/n)");
                    
                    // esc = Console.ReadLine();
                    // if(esc.ToLower() == "s"){
                    //     break;
                    // }
                    return;
                
                case 6:
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