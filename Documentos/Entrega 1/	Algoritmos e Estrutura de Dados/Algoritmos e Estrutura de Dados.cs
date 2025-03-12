
using System;
using System.Collections.Generic;

public class Evento
{
    public string NomeUsuario;
    public DateTime DataEvento;
    public string RepresentanteEvento;
    public string Legenda;

    public Evento(string nomeUsuario, DateTime dataEvento, string representanteEvento, string legenda)
    {
        NomeUsuario = nomeUsuario;
        DataEvento = dataEvento;
        RepresentanteEvento = representanteEvento;
        Legenda = legenda;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Evento> eventos = new List<Evento>();
        eventos.Add(new Evento("Alice Silva", new DateTime(2023, 10, 15), "Representante A", "Legenda A"));
        eventos.Add(new Evento("Bruno Costa", new DateTime(2023, 9, 10), "Representante B", "Legenda B"));
        eventos.Add(new Evento("Carla Oliveira", new DateTime(2023, 11, 5), "Representante C", "Legenda C"));
        eventos.Add(new Evento("Daniela Santos", new DateTime(2023, 8, 20), "Representante D", "Legenda D"));

        for (int i = 0; i < eventos.Count - 1; i++)
        {
            for (int j = 0; j < eventos.Count - 1 - i; j++)
            {
                if (eventos[j].DataEvento > eventos[j + 1].DataEvento)
                {
                    Evento temp = eventos[j];
                    eventos[j] = eventos[j + 1];
                    eventos[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < eventos.Count; i++)
        {
            Console.WriteLine($"Nome: {eventos[i].NomeUsuario}, Data: {eventos[i].DataEvento.ToShortDateString()}, Representante: {eventos[i].RepresentanteEvento}, Legenda: {eventos[i].Legenda}");
        }
    }
}
