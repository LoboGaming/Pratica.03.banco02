
using Microsoft.EntityFrameworkCore;
using WinFormsApp.BancoDeDados;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }

        private void CriarBancoDeDados()
        {
            using(var banco = new BancoContext())
            {
                banco.Database.Migrate();
            }

        }
    }
}
