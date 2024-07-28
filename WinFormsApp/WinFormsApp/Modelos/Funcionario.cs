using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WinFormsApp.Modelos
{
    internal class Funcionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFuncionario { get; set; }
        public string nomeFuncionario { get; set; } = string.Empty;
        public int idFuncaoFuncionario { get; set; }
        public FuncaoFuncionario FuncaoFuncionario { get; set; }
    }
}
