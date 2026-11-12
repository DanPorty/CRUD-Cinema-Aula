using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using CinemaService.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroSessao : CadastroBase
    {
        private readonly InterfaceBaseService<Sessao> _sessaoService;
        private readonly InterfaceBaseService<Filme> _filmeService;
        private readonly InterfaceBaseService<Sala> _salaService;
        private List<SessaoViewModel> _sessoes;
        private List<FilmeViewModel> _filmes;
        private List<SalaViewModel> _salas;

        public CadastroSessao(
            InterfaceBaseService<Sessao> sessaoService,
            InterfaceBaseService<Filme> filmeService,
            InterfaceBaseService<Sala> salaService)
        {
            _sessaoService = sessaoService;
            _filmeService = filmeService;
            _salaService = salaService;
            InitializeComponent();
            txtPreco.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            CarregaCombos();
        }

        private void CarregaCombos()
        {
            _filmes = _filmeService.ReadAll<FilmeViewModel>().ToList();
            cboFilme.DisplayMember = nameof(FilmeViewModel.Nome);
            cboFilme.ValueMember = nameof(FilmeViewModel.Id);
            cboFilme.DataSource = _filmes;
            cboFilme.SelectedIndex = -1;

            _salas = _salaService.ReadAll<SalaViewModel>().ToList();
            cboSala.DisplayMember = nameof(SalaViewModel.Numero);
            cboSala.ValueMember = nameof(SalaViewModel.Id);
            cboSala.DataSource = _salas;
            cboSala.SelectedIndex = -1;
        }

        private void PreencheObjeto(Sessao sessao)
        {
            //_generoService.ReadById<Genero>((int)cboGenero.SelectedValue);
            sessao.Filme = _filmeService.ReadById<Filme>((int)cboFilme.SelectedValue);
            sessao.Sala = _salaService.ReadById<Sala>((int)cboSala.SelectedValue);
            sessao.Data = dtpData.Value.Date;
            sessao.Data += dtpHora.Value.TimeOfDay;
            decimal.TryParse(txtPreco.Text, out decimal preco);
            sessao.Preco = preco / 100;
        }

        private void PreencheTela(Sessao sessao)
        {
            cboFilme.SelectedItem = _filmes.FirstOrDefault(f => f.Id == sessao.Filme?.Id);
            cboSala.SelectedItem = _salas.FirstOrDefault(s => s.Id == sessao.Sala?.Id);
            dtpData.Value = sessao.Data;
            dtpHora.Value = DateTime.Today.Add(sessao.Data.TimeOfDay);
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var sessao = _sessaoService.ReadById<Sessao>(id);
                    PreencheObjeto(sessao);
                    _sessaoService.Update<Sessao, Sessao, SessaoValidator>(sessao);
                }
                else
                {
                    var sessao = new Sessao();
                    PreencheObjeto(sessao);
                    _sessaoService.Create<Sessao, Sessao, SessaoValidator>(sessao);
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
                _sessaoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _sessoes = _sessaoService.ReadAll<SessaoViewModel>().ToList();
            dataGridViewConsulta.DataSource = _sessoes;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var sessao = _sessaoService.ReadById<Sessao>(id);

            txtId.Text = sessao.Id.ToString();
            PreencheTela(sessao);
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
