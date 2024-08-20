namespace ConversaoUnidadesMetricas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a unidade de medida: ");

        string? unidade = Console.ReadLine();

        Console.WriteLine("Escolha o valor da unidade de medida: ");

        double valor = Convert.ToDouble(Console.ReadLine());

        switch (unidade){

                case "km":
                
                {

                    Console.WriteLine("Equivalente em hm: ");
                    Console.WriteLine(valor * (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em dam: ");
                    Console.WriteLine(valor * (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em m: ");
                    Console.WriteLine(valor * (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em dm: ");
                    Console.WriteLine(valor * (Math.Pow(10,4)));

                    Console.WriteLine("Equivalente em cm: ");
                    Console.WriteLine(valor * (Math.Pow(10,5)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor * (Math.Pow(10,6)));
                    

                    break;

                }

                case "hm":

                {
                    Console.WriteLine("Equivalente em km: ");
                    Console.WriteLine(valor / (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em dam: ");
                    Console.WriteLine(valor * (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em m: ");
                    Console.WriteLine(valor * (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em dm: ");
                    Console.WriteLine(valor * (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em cm: ");
                    Console.WriteLine(valor * (Math.Pow(10,4)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor * (Math.Pow(10,5)));


                    break;

                }

                case "dam": {

                    Console.WriteLine("Equivalente em km: ");
                    Console.WriteLine(valor / (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em hm: ");
                    Console.WriteLine(valor / (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em m: ");
                    Console.WriteLine(valor * (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em dm: ");
                    Console.WriteLine(valor * (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em cm: ");
                    Console.WriteLine(valor * (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor * (Math.Pow(10,4)));


                    break;

                }

                case "m":

                {

                    Console.WriteLine("Equivalente em km: ");
                    Console.WriteLine(valor / (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em hm: ");
                    Console.WriteLine(valor / (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em dam: ");
                    Console.WriteLine(valor / (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em dm: ");
                    Console.WriteLine(valor * (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em cm: ");
                    Console.WriteLine(valor * (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor * (Math.Pow(10,3)));

                    break;

                }

                case "dm": {

                    Console.WriteLine("Equivalente em km: ");
                    Console.WriteLine(valor / (Math.Pow(10,4)));

                    Console.WriteLine("Equivalente em hm: ");
                    Console.WriteLine(valor / (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em dam: ");
                    Console.WriteLine(valor / (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em m: ");
                    Console.WriteLine(valor / (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em cm: ");
                    Console.WriteLine(valor * (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor * (Math.Pow(10,2)));

                    break;

                }

                case "cm": {

                    Console.WriteLine("Equivalente em km: ");
                    Console.WriteLine(valor / (Math.Pow(10,5)));

                    Console.WriteLine("Equivalente em hm: ");
                    Console.WriteLine(valor / (Math.Pow(10,4)));

                    Console.WriteLine("Equivalente em dam: ");
                    Console.WriteLine(valor / (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em m: ");
                    Console.WriteLine(valor / (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em dm: ");
                    Console.WriteLine(valor / (Math.Pow(10,1)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor * (Math.Pow(10,1)));

                    break;

                }

                case "mm": {

                    Console.WriteLine("Equivalente em km: ");
                    Console.WriteLine(valor / (Math.Pow(10,6)));

                    Console.WriteLine("Equivalente em hm: ");
                    Console.WriteLine(valor / (Math.Pow(10,5)));

                    Console.WriteLine("Equivalente em dam: ");
                    Console.WriteLine(valor / (Math.Pow(10,4)));

                    Console.WriteLine("Equivalente em mm: ");
                    Console.WriteLine(valor / (Math.Pow(10,3)));

                    Console.WriteLine("Equivalente em dm: ");
                    Console.WriteLine(valor / (Math.Pow(10,2)));

                    Console.WriteLine("Equivalente em cm: ");
                    Console.WriteLine(valor / (Math.Pow(10,1)));



                    break;

                }

                default: 

                {

                    Console.WriteLine("Não foi possível realizar a conversão. Tente novamente");

                    break;

                }

        }
       
    }
}
