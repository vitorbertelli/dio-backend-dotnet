namespace DesafioFundamentos.Models;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<string>? veiculos = new List<string>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo(string placa)
    {
        this.veiculos?.Add(placa);
    }

    public bool RemoverVeiculo(string placa)
    {
        return this.veiculos?.Remove(placa) ?? false;
    }

    public void ListarVeiculos()
    {
        if (veiculos?.Any() ?? false)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in veiculos)
            {
                int i = veiculos.IndexOf(veiculo);
                Console.WriteLine($"{i + 1}. {veiculo}");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }

    public decimal CalcularPrecoTotal(int horas)
    {
        decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);
        return valorTotal;
    }
}
