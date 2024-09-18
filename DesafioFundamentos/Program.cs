using DesafioFundamentos.Models;


decimal precoInicial = 0;
decimal precoPorHora = 7.50m;

Estacionamento estacinamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
string? placa = string.Empty;
int horas = 0;
decimal valorTotal = 0;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Convert.ToString(Console.ReadLine());
            if (placa != null && placa.Trim() != "")
            {
                estacinamento.AdicionarVeiculo(placa);
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente!");
            }
            break;

        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Convert.ToString(Console.ReadLine());
            if (placa != null && placa.Trim() != "")
            {
                if (estacinamento.RemoverVeiculo(placa))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    horas = Convert.ToInt16(Console.ReadLine());
                    valorTotal = estacinamento.CalcularPrecoTotal(horas);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine($"O veículo {placa} não foi encontrado.");
                }

            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente!");
            }
            break;

        case "3":
            estacinamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");