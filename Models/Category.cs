using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] // marcado como notnull
        [MinLength(3)]
        [MaxLength(80)] // tamanho maximo igual do banco
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }

        [Required] // marcado como notnull
        [MinLength(3)]
        [MaxLength(80)] // tamanho maximo igual do banco
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}