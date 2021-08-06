using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAppVS.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage ="Preencha o campo Avaliação")]
        [Display(Name ="Avaliação")]
        [RegularExpression(@"^[0,5]*$", ErrorMessage = "Somente números")]
        public int Avaliacao { get; set; }
    }
}
