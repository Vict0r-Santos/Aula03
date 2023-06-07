using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como declarar uma variável 
            // O nome não pode ter:
            // - Acentos
            // - Começar com número
            string chefe = "Mafioso";
            int idade = 19;
            Console.WriteLine("Programa criado por " + chefe); 
            Console.WriteLine("Lembrando que foi criado pelo " + chefe);
            Console.WriteLine("O dono desse codigo é o " + chefe);
            Console.WriteLine( chefe + " criou esse programa");
            Console.WriteLine("Minha idade é " + idade + "y");

            // Juntar os pedaços de texto se chama CONCATENAÇÃO
            // Esse é o jeito velho
            Console.WriteLine("Meu nome é " + chefe + " e tenho " + idade + "y");

            // Esse é o Jeito moderno, se chama INTERPOLAÇÃO
            Console.WriteLine($"Meu nome é {chefe} e eu tenho {idade} anos");
            Console.ReadKey(); // <---- Comando para finalizar
        }
    }
}
