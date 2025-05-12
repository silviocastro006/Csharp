
using System.ComponentModel.DataAnnotations;

namespace Curso_Api.Data.Dtos;

public class ReadFilmeDto
{
    public virtual string? Titulo { get; set; }
    public virtual string? Genero { get; set; }
    public virtual int Duracao { get; set; }
    public DateTime HoraConsulta { get; set; } = DateTime.Now;
}