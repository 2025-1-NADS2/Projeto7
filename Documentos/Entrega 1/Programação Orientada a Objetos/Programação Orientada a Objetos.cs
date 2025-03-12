using System;
public class EventoDashboard
{
    public int IdUsuario { get; set; }
    public string NomeUsuario { get; set; }
    public List<Publicacao> Publicacoes { get; set; }
    public List<Relatorio> Relatorios { get; set; }

    public EventoDashboard(int idUsuario, string nomeUsuario)
    {
        IdUsuario = idUsuario;
        NomeUsuario = nomeUsuario;
        Publicacoes = new List<Publicacao>();
        Relatorios = new List<Relatorio>();
    }

    public void AdicionarPublicacao(Publicacao publicacao)
    {
        Publicacoes.Add(publicacao);
    }

    public void AdicionarRelatorio(Relatorio relatorio)
    {
        Relatorios.Add(relatorio);
    }

    public void ExibirPublicacoes()
    {
        foreach (var publicacao in Publicacoes)
        {
            Console.WriteLine($"ID: {publicacao.IdUsuario}, Usuário: {publicacao.NomeUsuario}, Título: {publicacao.Titulo}, Conteúdo: {publicacao.Conteudo}");
        }
    }

    public void ExibirRelatorios()
    {
        foreach (var relatorio in Relatorios)
        {
            Console.WriteLine($"ID: {relatorio.IdUsuario}, Usuário: {relatorio.NomeUsuario}, Título: {relatorio.Titulo}, Descrição: {relatorio.Descricao}");
        }
    }
}

public class Publicacao
{
    public int IdUsuario { get; set; }
    public string NomeUsuario { get; set; }
    public string Titulo { get; set; }
    public string Conteudo { get; set; }

    public Publicacao(int idUsuario, string nomeUsuario, string titulo, string conteudo)
    {
        IdUsuario = idUsuario;
        NomeUsuario = nomeUsuario;
        Titulo = titulo;
        Conteudo = conteudo;
    }
}

public class Relatorio
{
    public int IdUsuario { get; set; }
    public string NomeUsuario { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }

    public Relatorio(int idUsuario, string nomeUsuario, string titulo, string descricao)
    {
        IdUsuario = idUsuario;
        NomeUsuario = nomeUsuario;
        Titulo = titulo;
        Descricao = descricao;
    }
}

