namespace Projeto2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o primeiro lado do triângulo: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o segundo lado do triângulo: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o terceiro lado do triângulo: ");
        double c = Convert.ToDouble(Console.ReadLine());
        double semiperimetro = (a + b + c) / 2;
        double dentroDaRaiz = semiperimetro * (semiperimetro - a) * (semiperimetro - b) * (semiperimetro - c);
        double area = Math.Round(Math.Sqrt(dentroDaRaiz),2);
        Console.WriteLine("A área é: " + area);
    }
}
