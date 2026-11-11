
using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroFilme : CadastroBase
    {
        private InterfaceBaseService<Filme> _filmeService;
        private InterfaceBaseService<Genero> _generoService;
        private List<GeneroViewModel> _generos;
        private List<FilmeViewModel> _filmes;

        public CadastroFilme(InterfaceBaseService<Filme> filmeService, InterfaceBaseService<Genero> generoService)
        {
            _filmeService = filmeService;
            _generoService = generoService;
            InitializeComponent();
            CarregaComboGeneros();
        }

        private void CarregaComboGeneros()
        {
            cmbGenero.DisplayMember = nameof(GeneroViewModel.Nome);
            cmbGenero.ValueMember = nameof(GeneroViewModel.Id);
            _generos = _generoService.ReadAll<GeneroViewModel>().ToList();
            cmbGenero.DataSource = null;
            cmbGenero.DataSource = _generos;
            cmbGenero.SelectedIndex = -1;
        }

        private void PreencheObjeto(Filme filme)
        {
            filme.Nome = txtNome.Text;
            filme.Classificacao = cmbClassificacao.SelectedItem?.ToString();
            filme.Genero = _generoService.ReadById<Genero>((int)cmbGenero.SelectedValue);
            filme.Duracao = Convert.ToInt32(numDuracao.Value);
        }

        private void PreencheTela(Filme filme)
        {
            txtNome.Text = filme.Nome;
            cmbClassificacao.SelectedItem = filme.Classificacao;
            cmbGenero.SelectedItem = _generos.FirstOrDefault(g => g.Id == filme.Genero?.Id);
            numDuracao.Value = filme.Duracao;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var filme = _filmeService.ReadById<Filme>(id);
                    PreencheObjeto(filme);
                    _filmeService.Update<Filme, Filme, FilmeValidator>(filme);
                }
                else
                {
                    var filme = new Filme();
                    PreencheObjeto(filme);
                    _filmeService.Create<Filme, Filme, FilmeValidator>(filme);
                }

                tabControlCadastro.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _filmeService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _filmes = _filmeService.ReadAll<FilmeViewModel>().ToList();
            dataGridViewConsulta.DataSource = _filmes;

            if (dataGridViewConsulta.Columns["Nome"] is not null)
                dataGridViewConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridViewConsulta.Columns["GeneroId"] is not null)
                dataGridViewConsulta.Columns["GeneroId"].Visible = false;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var filme = _filmeService.ReadById<Filme>(id);

            txtId.Text = filme.Id.ToString();
            PreencheTela(filme);
        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }
    }
}
