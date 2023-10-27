using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GranTiete_Devs.Models;

[Table("area_atuacao")]
public class AreaAtuacao
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required(ErrorMessage ="Informe o Nome")]
    [StringLength(30, ErrorMessage ="O nome deve possuir no maximo 30 caracteres")]
    public string Nome { get; set; }
}
