using System;

namespace CursoGitHub.InterfaceConsole
{ //Inicio do namespace
    internal class Program
    { // Inicio da classe
        static void Main(string[] args)
        { // inicio do método
            /*
             * Main - principal
             * O método inicia-se com a letra maiuscula
             *
             */
            //Variável
            /*
             * É um espaço reservado na memória
             */
            string pergunta;
            string resposta = "git init";
 
            Console.WriteLine("Qual comando para iniciar o git");
            pergunta = Console.ReadLine();

            if (pergunta.Equals(resposta))
            {
                Console.WriteLine("acertou");
            }
            else
            {
                Console.WriteLine("errou");
            }

            Console.WriteLine($"A resposta é {resposta}");
            Console.WriteLine("Alô Mundo!");
            Console.ReadKey();


        } // fin do método
    } // fim da classe
} // fim do namespace
