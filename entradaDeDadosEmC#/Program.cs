using System;

namespace Course
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma frase");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite uma cor");
            string x = Console.ReadLine();

            Console.WriteLine("Digite outra cor");
            string y = Console.ReadLine();

            Console.WriteLine("mais uma cor");
            string z = Console.ReadLine();

            Console.WriteLine("digite 3 palavras");
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Console.WriteLine("tudo o que voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            

       
        }
    }
}