using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WinFormsApp.Modelos
{
    internal class FuncaoFuncionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFuncaoFuncionario { get; set; }
        public string nomeFuncaoFuncionario { get; set; } = string.Empty;
    }
}
