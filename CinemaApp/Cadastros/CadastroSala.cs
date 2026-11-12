
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
    public partial class CadastroSala : CadastroBase
    {
        private readonly InterfaceBaseService<Sala> _salaService;
        private List<SalaViewModel> _salas;

        public CadastroSala(InterfaceBaseService<Sala> salaService)
        {
            _salaService = salaService;
            InitializeComponent();
        }

        private void PreencheObjeto(Sala sala)
        {
            sala.Numero = (int)nudNumero.Value;
            sala.Capacidade = (int)nudCapacidade.Value;
            sala.Fileiras = (int)nudFileiras.Value;
            sala.Assentos = (int)nudAssentos.Value;
        }

        private void PreencheTela(Sala sala)
        {
            nudNumero.Value = sala.Numero;
            nudCapacidade.Value = sala.Capacidade;
            nudFileiras.Value = sala.Fileiras;
            nudAssentos.Value = sala.Assentos;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var sala = _salaService.ReadById<Sala>(id);
                    PreencheObjeto(sala);
                    _salaService.Update<Sala, Sala, SalaValidator>(sala);
                }
                else
                {
                    var sala = new Sala();
                    PreencheObjeto(sala);
                    _salaService.Create<Sala, Sala, SalaValidator>(sala);
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
                _salaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _salas = _salaService.ReadAll<SalaViewModel>().ToList();
            dataGridViewConsulta.DataSource = _salas;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            var id = Convert.ToInt32(row.Cells["Id"].Value);
            var sala = _salaService.ReadById<Sala>(id);

            txtId.Text = sala.Id.ToString();
            PreencheTela(sala);
        }
    }
}
