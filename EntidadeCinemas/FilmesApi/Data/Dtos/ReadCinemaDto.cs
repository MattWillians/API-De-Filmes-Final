
namespace FilmesApi.Data.Dtos
{
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public ReadEnderecoDto ReadEndereco { get; set; }
        public ICollection<ReadSessaoDto> ReadSessoes { get; set; }
    }
}
