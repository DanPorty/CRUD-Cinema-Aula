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

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSala cadastroSala = ConfigureDI.ServiceProvider.GetService<CadastroSala>();
            cadastroSala.MdiParent = this;
            cadastroSala.Show();
        }

        private void sessaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSessao cadastroSessao = ConfigureDI.ServiceProvider.GetService<CadastroSessao>();
            cadastroSessao.MdiParent = this;
            cadastroSessao.Show();
        }
    }
}