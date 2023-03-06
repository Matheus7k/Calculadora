double num1, num2;
int continua = 1;

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

while(continua == 1)
{
    switch (Menu())
    {
        case 1:
            Console.WriteLine($"A soma dos numeros é: {Soma()}");           
            break;
        case 2:
            Console.WriteLine($"A subtração dos numeros é: {Subtracao()}");           
            break;
        case 3:
            Console.WriteLine($"A multiplicação dos numeros é: {Multiplicacao()}");           
            break;
        case 4:
            if (num2 == 0)
            {
                Console.WriteLine("Impossivel dividir por zero!");               
                break;
            }
            Console.WriteLine($"A divisão dos numeros é: {Divisao()}");          
            break;
        case 5:
            Console.WriteLine($"Até mais!");          
            continua = 0;
            break;
        default:
            Console.WriteLine("Opção inválida!");           
            break;
    }
    Console.WriteLine("Pressione a tecla ENTER para continuar!");
    Console.ReadLine();
}