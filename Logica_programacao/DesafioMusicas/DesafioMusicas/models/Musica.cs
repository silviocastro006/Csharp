using System;

namespace DesafioMusica.Models.Musica;

class Musica
{
    public int Codigo { get; protected set; }
    public DateTime DataLancamento { get; protected set; } 
    public string Nome { get; protected set; } 
    public string Artista { get; protected set; } 
    public string Album { get; protected set; } 
    public string Genero { get; protected set; } 
    public double Duracao { get; protected set; } 
    public string Gravadora { get; protected set; } 
    public string Pais { get; protected set; } 
    public string Idioma { get; protected set; } 


    public Musica(int codigo, DateTime dataLancamento, string nome, string artista, string album, string genero, double duracao, string gravadora, string pais, string idioma)
    {
        SetCodigo(codigo);
        SetDataLancamento(dataLancamento);
        SetNome(nome);
        SetArtista(artista);
        SetAlbum(album);
        SetGenero(genero);
        SetDuracao(duracao);
        SetGravadora(gravadora);
        SetPais(pais);
        SetIdioma(idioma);
    }

    public void SetCodigo(int codigo)
    {   
        if(codigo <= 0){
            throw new ArgumentException("Código não pode ser 0!");
        }

        Codigo = codigo;
    }

    public void SetDataLancamento(DateTime dataLancamento)
    {
        if(dataLancamento == DateTime.MinValue)
        {
            throw new ArgumentException("Data precisa ser um valor válido!");
        }

        DataLancamento = dataLancamento;
    }

    public void SetNome(string nome)
    {
        if(string.IsNullOrEmpty(nome))
        {
            throw new ArgumentException("Nome não pode ser nulo!");
        }

        Nome = nome;
    }

    public void SetArtista(string artista)
    {
        if(string.IsNullOrEmpty(artista))
        {
            throw new ArgumentException("Artista não pode ser nulo!");
        }

        Artista = artista;
    }

    public void SetAlbum(string album)
    {
        if(string.IsNullOrEmpty(album))
        {
            throw new ArgumentException("Album não pode ser nulo!");
        }

        Album = album;
    }

    public void SetGenero(string genero)
    {
        if(string.IsNullOrEmpty(genero))
        {
            throw new ArgumentException("Genero não pode ser nulo!");
        }

        Genero = genero;
    }

    public void SetDuracao(double duracao)
    {
        if(duracao <= 0){
            throw new ArgumentException("Duração não pode ser 0!");
        }

        Duracao = duracao;
    }

    public void SetGravadora(string gravadora)
    {
        if(string.IsNullOrEmpty(gravadora))
        {
            throw new ArgumentException("Gravadora não pode ser nula!");
        }

        Gravadora = gravadora;
    }

    public void SetPais(string pais)
    {
        if(string.IsNullOrEmpty(pais))
        {
            throw new ArgumentException("País não pode ser nula!");
        }

        Pais = pais;
    }

    public void SetIdioma(string idioma)
    {
        if(string.IsNullOrEmpty(idioma))
        {
            throw new ArgumentException("Idioma não pode ser nula!");
        }

        Idioma = idioma;
    }

}