namespace CinemaApp.Cadastros
{
    partial class CadastroFilme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmbGenero = new ReaLTaiizor.Controls.MaterialComboBox();
            numDuracao = new NumericUpDown();
            lblDuracao = new ReaLTaiizor.Controls.MaterialLabel();
            cmbClassificacao = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracao).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cmbClassificacao);
            tabPageCadastro.Controls.Add(lblDuracao);
            tabPageCadastro.Controls.Add(numDuracao);
            tabPageCadastro.Controls.Add(cmbGenero);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Size = new Size(786, 335);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(cmbGenero, 0);
            tabPageCadastro.Controls.SetChildIndex(numDuracao, 0);
            tabPageCadastro.Controls.SetChildIndex(lblDuracao, 0);
            tabPageCadastro.Controls.SetChildIndex(cmbClassificacao, 0);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(794, 368);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(688, 78);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 78);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(15, 22);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(93, 60);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Filme";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(126, 22);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(312, 60);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // cmbGenero
            // 
            cmbGenero.AutoResize = false;
            cmbGenero.BackColor = Color.FromArgb(255, 255, 255);
            cmbGenero.Depth = 0;
            cmbGenero.DrawMode = DrawMode.OwnerDrawVariable;
            cmbGenero.DropDownHeight = 218;
            cmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGenero.DropDownWidth = 121;
            cmbGenero.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbGenero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Hint = "Gênero";
            cmbGenero.IntegralHeight = false;
            cmbGenero.ItemHeight = 54;
            cmbGenero.Location = new Point(15, 178);
            cmbGenero.MaxDropDownItems = 4;
            cmbGenero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(312, 60);
            cmbGenero.StartIndex = 0;
            cmbGenero.TabIndex = 5;
            // 
            // numDuracao
            // 
            numDuracao.Location = new Point(455, 55);
            numDuracao.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuracao.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuracao.Name = "numDuracao";
            numDuracao.Size = new Size(150, 27);
            numDuracao.TabIndex = 6;
            numDuracao.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Depth = 0;
            lblDuracao.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblDuracao.Location = new Point(455, 22);
            lblDuracao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(75, 24);
            lblDuracao.TabIndex = 7;
            lblDuracao.Text = "Duração";
            // 
            // cmbClassificacao
            // 
            cmbClassificacao.AutoResize = false;
            cmbClassificacao.BackColor = Color.FromArgb(255, 255, 255);
            cmbClassificacao.Depth = 0;
            cmbClassificacao.DrawMode = DrawMode.OwnerDrawVariable;
            cmbClassificacao.DropDownHeight = 218;
            cmbClassificacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClassificacao.DropDownWidth = 121;
            cmbClassificacao.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmbClassificacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmbClassificacao.FormattingEnabled = true;
            cmbClassificacao.Hint = "Classificação";
            cmbClassificacao.IntegralHeight = false;
            cmbClassificacao.ItemHeight = 54;
            cmbClassificacao.Items.AddRange(new object[] { "Livre", "6 anos", "10 anos", "12 anos", "14 anos", "16 anos", "18 anos" });
            cmbClassificacao.Location = new Point(15, 98);
            cmbClassificacao.MaxDropDownItems = 4;
            cmbClassificacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmbClassificacao.Name = "cmbClassificacao";
            cmbClassificacao.Size = new Size(312, 60);
            cmbClassificacao.StartIndex = 0;
            cmbClassificacao.TabIndex = 8;
            // 
            // CadastroFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroFilme";
            Text = "CadastroFilme";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numDuracao).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialLabel lblDuracao;
        private NumericUpDown numDuracao;
        private ReaLTaiizor.Controls.MaterialComboBox cmbGenero;
        private ReaLTaiizor.Controls.MaterialComboBox cmbClassificacao;
    }
}