using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_Api.Models;

public class Filme
{   
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage ="O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório")]
    [Range(70,600, ErrorMessage = "A duração deve ter entre 70 a 600 minutos")]
    public int Duracao { get; set; }

    public Filme(string titulo, string genero, int duracao)
    {
        Titulo = titulo;
        Genero = genero;
        Duracao = duracao;
    }
}