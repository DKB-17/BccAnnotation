using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BccAnnotation.Models
{
    [Table("Cidades")]
    public class Cidade
    {
        [Display(Name = "ID: ")]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Cria uma geração do codigo id em sequencia graças ao annotation "Identity"  
        public int id { get; set; }
        [Display(Name = "Nome: ")]
        [Required]
        [StringLength(40)]
        public string nome { get; set; }
        [Display(Name = "Estado: ")]
        [StringLength(25)]
        public string estado { get; set; }
        [Display(Name = "Quantidade Habitantes: ")]
        public int populacao { get; set; }

    }
}
