﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo NOME é obrigatório.")]
        [StringLength(50)] 
        public String Nome { get; set; }

        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual ICollection<Sessao> Sessoes {  get; set; } 
    }
}
