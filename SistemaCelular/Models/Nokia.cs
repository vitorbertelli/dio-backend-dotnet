namespace SistemaCelular.Models;

public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
    {
    }

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Aplicativo {nomeApp} instalado no Nokia com sucesso!");
    }
}
