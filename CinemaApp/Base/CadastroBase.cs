using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace CinemaApp.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsEditMode = false;
        #endregion

        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos de tela
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente cancelar?", "Cancelar",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimpaCampos();
                tabControlCadastro.SelectedIndex = 1;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void dataGridViewConsulta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro ?", "Excluir",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var id = (int)dataGridViewConsulta.SelectedRows[0].Cells["Id"].Value;
                    Deletar(id);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir!", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        #endregion

        #region Métodos

        protected virtual void CarregaGrid()
        {
            throw new NotImplementedException();
        }

        protected virtual void Salvar()
        {
            throw new NotImplementedException();
        }

        protected virtual void Novo()
        {
            LimpaCampos();
            tabControlCadastro.SelectedIndex = 0;
            tabControlCadastro.Focus();
        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsEditMode = true;
                var row = dataGridViewConsulta.SelectedRows[0];
                CarregarRegistro(row);
                tabControlCadastro.SelectedIndex = 0;
                tabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um registro para editar!", "Editar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected virtual void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        protected virtual void CarregarRegistro(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        private void LimpaCampos()
        {
            IsEditMode = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                    ((MaterialTextBoxEdit)control).Clear();

                if (control is MaterialMaskedTextBox)
                    ((MaterialMaskedTextBox)control).Clear();
            }
        }
        #endregion
    }
}