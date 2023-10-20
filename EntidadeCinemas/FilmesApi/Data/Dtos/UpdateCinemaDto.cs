using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo NOME é obrigatório.")]
        [StringLength(50)]
        public String Nome { get; set; }
    }
}
