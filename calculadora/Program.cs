internal class Program
{
    private static void Main(string[] args)
    {
        float n1, n2;

        Console.WriteLine("Informe o primeiro numero: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo numero: ");
        n2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"A soma dos numeros é: {n1 + n2}");
        Console.WriteLine($"A subtração dos numeros é: {n1 - n2}");
        Console.WriteLine($"A multiplicação dos numeros é: {n1 * n2}");

        if (n2 == 0)
        {
            Console.WriteLine("Impossivel dividir por zero!");
        }else Console.WriteLine($"A divisão dos numeros é: {n1/n2}");
    }
}