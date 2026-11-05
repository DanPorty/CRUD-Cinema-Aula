using CinemaApp.Base;
using CinemaApp.Models;
using CinemaDomain;
using CinemaService.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CinemaApp.Cadastros
{
    public partial class CadastroFilme : CadastroBase
    {
        private InterfaceBaseService<Filme> _filmeService;
        private InterfaceBaseService<Genero> _generoService;
        private List<GeneroViewModel> _generos;

        public CadastroFilme(InterfaceBaseService<Filme> filmeService, InterfaceBaseService<Genero> generoService)
        {
            _filmeService = filmeService;
            _generoService = generoService;
            InitializeComponent();
            CarregaComboGeneros();
        }

        private void CarregaComboGeneros()
        {
            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "Id";
            _generos = _generoService.ReadAll<GeneroViewModel>().ToList();
            cmbGenero.DataSource = _generos;
            cmbGenero.SelectedIndex = -1;
        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }
    }
}
