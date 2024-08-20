namespace ParImpar;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");

        var numero = Console.ReadLine();

        int restoDaDivisao = Convert.ToInt32(numero) % 2;

        String parOuImpar = restoDaDivisao == 0 ? "par" : "ímpar";

        Console.WriteLine("O número inserido é: " + parOuImpar);

    }
}
