using CinemaApp.Cadastros;
using CinemaApp.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace CinemaApp
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGenero cadastroGenero = ConfigureDI.ServiceProvider.GetService<CadastroGenero>();
            cadastroGenero.MdiParent = this;
            cadastroGenero.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFilme cadastroFilme = ConfigureDI.ServiceProvider.GetService<CadastroFilme>();
            cadastroFilme.MdiParent = this;
            cadastroFilme.Show();
        }
    }
}