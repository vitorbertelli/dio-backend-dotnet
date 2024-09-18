﻿namespace SistemaHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (this.Suite.Capacidade >= hospedes.Count())
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Suite não tem espaço o suficiente. Crie outra reserva.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return this.Hospedes.Count();
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = this.DiasReservados * this.Suite.ValorDiaria;

        if (this.DiasReservados >= 10)
        {
            valor *= 0.9m;
        }

        return valor;
    }
}
