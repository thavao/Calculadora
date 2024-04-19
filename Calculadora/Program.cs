double numero1 = 0, numero2 = 0;
int opcao = 0;

while (true)
{
    Console.WriteLine("Escolha uma operação: ");
    Console.WriteLine("[0] - sair | [1] - adição | [2] - subtração | [3] - multiplicação | [4] - divisão");

    opcao = int.Parse(Console.ReadLine());

    if (opcao != 0)
    {
        Console.Write("Digite o 1º numero: ");
        numero1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o 2º numero: ");
        numero2 = double.Parse(Console.ReadLine());

        if (opcao == 1)
            Console.WriteLine($"\n{numero1} + {numero2} = {numero1 + numero2}\n");

        if (opcao == 2)
            Console.WriteLine($"\n{numero1} - {numero2} = {numero1 - numero2}\n");

        if (opcao == 3)
            Console.WriteLine($"\n{numero1} * {numero2} = {numero1 * numero2}\n");

        if (opcao == 4)
            if (numero2 != 0)
                Console.WriteLine($"\n{numero1} / {numero2} = {numero1 / numero2}\n");
            else
                Console.WriteLine("\nNão é possível dividir por 0\n");

    }
    else if(opcao > 4 || opcao < 0)
        Console.WriteLine("Opção inválida, digite novamente...");
    else
        break;
}

Console.WriteLine("Pressione Enter para encerrar...");

Console.ReadLine();