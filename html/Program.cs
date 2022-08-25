using System;

namespace html
{
    class Program
    {
        static void Main(string[] args)
        { 
            // Entrada e saida de dados
            Console.WriteLine("Bem-vindo ao sistema de notas");

            Console.WriteLine("Digite uma opção para continuar:");
            Console.WriteLine("1 - Cadastro de notas de alunos:");
            Console.WriteLine("2 - Calcular idade:");
            Console.WriteLine("3 - ...");
            Console.WriteLine("0 - Sair");
            
            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 0 : 
                    break;
                case 1 :
                    Console.WriteLine("Digite o nome do Aluno:");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a nota do Aluno:");
                    double nota = Double.Parse(Console.ReadLine());

                    if(nota == 0) {
                    Console.WriteLine("Nota Zerada!"); 
                } else {
                    // Verificar se o aluno tirou uma nota maior que a média
                    if( nota >= 6) {
                        if ( nota == 10 && nota <= 10){
                            Console.WriteLine("Gabaritou!");
                        } else {
                        Console.WriteLine("Passou!");
                        }
                    } else if(nota < 6 && nota >= 0) {
                        Console.WriteLine("Reprovou!");
                    } else {
                        Console.WriteLine("Nem passou e nem rodou!");
                    }
                } 

                Console.WriteLine(" A nota do Aluno " + nome + " foi " + nota );
                break;

                case 2:
                    Console.WriteLine("Digite seu nome");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite seu ano de nascimento:");
                    int ano = int.Parse(Console.ReadLine());

                    string anoAtual = System.DateTime.Now.ToString("yyyy");
                    int idade = int.Parse(anoAtual) - ano;

                    Console.WriteLine(nome + " a sua idade é: " + idade);
                    break;
            }          
        }
    }
}
