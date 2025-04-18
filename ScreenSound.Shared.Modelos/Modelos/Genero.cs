using ScreenSound.Modelos;

namespace ScreenSound.Shared.Modelos.Modelos
{
    public class Genero
    {
        public virtual int Id { get; set; }
        public virtual string? Nome { get; set; }
        public virtual string? Descricao { get; set; }
        public virtual ICollection<Musica> Musicas { get; set; }

        public Genero(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Descrição: {Descricao}";
        }

    }
}