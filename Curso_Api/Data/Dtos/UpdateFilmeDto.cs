using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Curso_Api.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public virtual string? Titulo { get; set; }

        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        [StringLength(50, ErrorMessage ="O tamanho do gênero não pode exceder 50 caracteres")] 
        public virtual string? Genero { get; set; }

        [Required(ErrorMessage = "A duração do filme é obrigatório")]
        [Range(70,600, ErrorMessage = "A duração deve ter entre 70 a 600 minutos")]
        public virtual int Duracao { get; set; }
    }
}