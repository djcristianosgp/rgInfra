using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace rginfra.Models
{
    [Table("Setores")]
    public class Setor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SetorId { get; set; }

        [StringLength(50, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome do Setor")]
        [Display(Name = "Descrição")]
        public string? DescricaoSetor { get; set; }

        [DefaultValue("true")]
        [Display(Name = "Ativo")]
        public bool? Ativo { get; set; }

        public List<Colaborador>? Colaborados { get; set; }
    }
}
