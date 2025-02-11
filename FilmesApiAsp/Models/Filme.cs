using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApiAsp.Models
{
    public class Filme
    {
        [Required]
        [Key]
        public long id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo Gênero deve ter no máximo 50 caracteres")]
        public String Genero { get; set; }

        [Required(ErrorMessage = "O campo Duração é obrigatório")]
        [Range(60,600,ErrorMessage = "A duração deve ter no mínimo 60 e no máximo 600 minutos")]
        public int Duracao { get; set; }


    }
}