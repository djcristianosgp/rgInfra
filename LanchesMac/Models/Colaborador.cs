using rginfra.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rginfra.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColaboradorId { get; set; }

        [StringLength(100, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name = "Nome")]
        public string? ColaboradorNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        [DefaultValue("true")]
        [Display(Name = "Ativo")]
        public bool? Ativo { get; set; }

        [Display(Name = "Setor")]
        public int SetorId { get; set; }
        public virtual Setor? Setor { get; set; }
    }
}
