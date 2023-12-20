using System.Reflection.Metadata;
using projeto1_curso.net.Models;

Parking parking = new Parking();

Console.WriteLine("SEJA BEM VINDO AO NOSSO ESTACIONAMENTO!!");

parking.cost();

while (true)
{
    Console.WriteLine("");
    Console.WriteLine("OPÇÕES:");
    Console.WriteLine("[1] Cadastrar veículo");
    Console.WriteLine("[2] Remover veículo");
    Console.WriteLine("[3] Listar veículos");
    Console.WriteLine("[4] Sair");
    Console.WriteLine("Escolha uma das opções:");

    string? user = "0";
    while(true)
    {
        while(true)
        {
            user = Console.ReadLine();
            if (user == "")
            {
                Console.WriteLine("Escolha uma das opções acima:");
            }
            else
            {
                break;
            }
        }

        int user_for_int = 0;
        int.TryParse(user, out user_for_int);

        if(user_for_int > 0 && user_for_int < 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("OPS, tente novamente!");
        }
    }

    if(user == "1")
    {
        Console.WriteLine("Digite a placa do seu carro:");
        string? userLicensePlate = Console.ReadLine();

        parking.Register(userLicensePlate);
    }

    if(user == "2")
    {
        parking.exit();
    }

    if(user == "3")
    {
        parking.List();
    }

    if(user == "4")
    {
        break;
    }
}   