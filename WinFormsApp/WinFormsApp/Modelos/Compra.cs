using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp.Modelos
{
    internal class Compra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCompra { get; set; }
        public string dataCompra { get; set; } = string.Empty;
    }
}
