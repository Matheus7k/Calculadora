double num1, num2;
int opcao = 0;

int Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opçao: ");
    return int.Parse(Console.ReadLine());
}

double Soma()
{
    return num1 + num2;
}

double Subtracao()
{
    return num1 - num2;
}

double Multiplicacao()
{
    return num1 * num2;
}

double Divisao()
{
    return num1 / num2;
}

Console.Write("Informe o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());
Console.Write("Informe o segundo numero: ");
num2 = double.Parse(Console.ReadLine());

while(opcao != 5)
{
    opcao = Menu();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"A soma dos numeros é: {Soma()}");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine($"A subtração dos numeros é: {Subtracao()}");
            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine($"A multiplicação dos numeros é: {Multiplicacao()}");
            Console.ReadLine();
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Impossivel dividir por zero!");
                Console.ReadLine();
                break;
            }
            Console.WriteLine($"A divisão dos numeros é: {Divisao()}");
            Console.ReadLine();
            break;
        case 5:
            Console.WriteLine($"Até mais!");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Console.ReadLine();
            break;
    }
}