using System.Numerics;
using System.Reflection;

namespace Aula_4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Programa de cadastro de usuário");

        Console.WriteLine("");

        Console.WriteLine("");

        Console.WriteLine("Digite seu nome: ");

        String? nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");

        int idade = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Digite sua cidade: ");

        String? cidade = Console.ReadLine();

        Console.WriteLine("Digite seu estado: ");

        String? estado = Console.ReadLine();

        Console.WriteLine("Digite sua profissão: ");

        String? profissão = Console.ReadLine();

        Console.WriteLine("Digite seu salario: ");

        double salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite seu estado civil: ");

        String? estadoCivil = Console.ReadLine();

        Console.WriteLine("Processando ....");

        Console.WriteLine("");

        Console.WriteLine("");

        Console.WriteLine("Cadastro realizado com sucesso.");
        
    }
}
