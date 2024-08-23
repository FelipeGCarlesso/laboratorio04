double total = 0.0;

bool continuar = true;

while (continuar)
{
    Console.WriteLine("1 - Adicionar item ao pedido");
    Console.WriteLine("2 - Exibir total do pedido");
    Console.WriteLine("3 - Finalizar pedido e sair");
    Console.Write("Escolha uma opção: ");
    
    string escolha = Console.ReadLine();

    if (escolha == "1")
    {
        Console.WriteLine("Escolha um produto:");
        Console.WriteLine("1 - Pizza (R$ 30.00)");
        Console.WriteLine("2 - Hamburguer (R$ 15.00)");
        Console.WriteLine("3 - Refrigerante (R$ 5.00)");
        Console.Write("Escolha uma opção: ");
        
        string produto = Console.ReadLine();

        if (produto == "1")
        {
            total += 30.00;
            Console.WriteLine("Você adicionou uma Pizza ao pedido.");
        }
        else if (produto == "2")
        {
            total += 15.00;
            Console.WriteLine("Você adicionou um Hamburguer ao pedido.");
        }
        else if (produto == "3")
        {
            total += 5.00;
            Console.WriteLine("Você adicionou um Refrigerante ao pedido.");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
    else if (escolha == "2")
    {
        Console.WriteLine($"Total do pedido: R$ {total:F2}");
    }
    else if (escolha == "3")
    {
        Console.WriteLine($"Total final do pedido: R$ {total:F2}");
        Console.WriteLine("Obrigado por utilizar o sistema!");
        continuar = false;
    }
    else
    {
        Console.WriteLine("Opção inválida! Tente novamente.");
    }

    Console.WriteLine();
}

