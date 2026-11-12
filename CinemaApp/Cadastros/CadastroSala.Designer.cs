namespace CinemaApp.Cadastros
{
    partial class CadastroSala
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
            nudCapacidade = new NumericUpDown();
            lblCapacidade = new ReaLTaiizor.Controls.MaterialLabel();
            lblAssentos = new ReaLTaiizor.Controls.MaterialLabel();
            nudAssentos = new NumericUpDown();
            nudFileiras = new NumericUpDown();
            lblFileiras = new ReaLTaiizor.Controls.MaterialLabel();
            lblNumero = new ReaLTaiizor.Controls.MaterialLabel();
            nudNumero = new NumericUpDown();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAssentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFileiras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumero).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(nudNumero);
            tabPageCadastro.Controls.Add(lblNumero);
            tabPageCadastro.Controls.Add(lblFileiras);
            tabPageCadastro.Controls.Add(nudFileiras);
            tabPageCadastro.Controls.Add(nudAssentos);
            tabPageCadastro.Controls.Add(lblAssentos);
            tabPageCadastro.Controls.Add(lblCapacidade);
            tabPageCadastro.Controls.Add(nudCapacidade);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Size = new Size(786, 335);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(nudCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(lblCapacidade, 0);
            tabPageCadastro.Controls.SetChildIndex(lblAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(nudAssentos, 0);
            tabPageCadastro.Controls.SetChildIndex(nudFileiras, 0);
            tabPageCadastro.Controls.SetChildIndex(lblFileiras, 0);
            tabPageCadastro.Controls.SetChildIndex(lblNumero, 0);
            tabPageCadastro.Controls.SetChildIndex(nudNumero, 0);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(794, 368);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(688, 278);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 278);
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
            txtId.TabIndex = 3;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // nudCapacidade
            // 
            nudCapacidade.Location = new Point(212, 132);
            nudCapacidade.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudCapacidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacidade.Name = "nudCapacidade";
            nudCapacidade.Size = new Size(150, 27);
            nudCapacidade.TabIndex = 4;
            nudCapacidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCapacidade
            // 
            lblCapacidade.AutoSize = true;
            lblCapacidade.Depth = 0;
            lblCapacidade.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCapacidade.Location = new Point(212, 105);
            lblCapacidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblCapacidade.Name = "lblCapacidade";
            lblCapacidade.Size = new Size(157, 24);
            lblCapacidade.TabIndex = 5;
            lblCapacidade.Text = "Capacidade Total";
            // 
            // lblAssentos
            // 
            lblAssentos.AutoSize = true;
            lblAssentos.Depth = 0;
            lblAssentos.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblAssentos.Location = new Point(15, 173);
            lblAssentos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblAssentos.Name = "lblAssentos";
            lblAssentos.Size = new Size(84, 24);
            lblAssentos.TabIndex = 6;
            lblAssentos.Text = "Assentos";
            // 
            // nudAssentos
            // 
            nudAssentos.Location = new Point(15, 200);
            nudAssentos.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudAssentos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAssentos.Name = "nudAssentos";
            nudAssentos.Size = new Size(150, 27);
            nudAssentos.TabIndex = 7;
            nudAssentos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudFileiras
            // 
            nudFileiras.Location = new Point(212, 200);
            nudFileiras.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudFileiras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFileiras.Name = "nudFileiras";
            nudFileiras.Size = new Size(150, 27);
            nudFileiras.TabIndex = 8;
            nudFileiras.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblFileiras
            // 
            lblFileiras.AutoSize = true;
            lblFileiras.Depth = 0;
            lblFileiras.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblFileiras.Location = new Point(212, 173);
            lblFileiras.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblFileiras.Name = "lblFileiras";
            lblFileiras.Size = new Size(66, 24);
            lblFileiras.TabIndex = 9;
            lblFileiras.Text = "Fileiras";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Depth = 0;
            lblNumero.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblNumero.Location = new Point(15, 105);
            lblNumero.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(144, 24);
            lblNumero.TabIndex = 10;
            lblNumero.Text = "Número da Sala";
            // 
            // nudNumero
            // 
            nudNumero.Location = new Point(15, 132);
            nudNumero.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumero.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumero.Name = "nudNumero";
            nudNumero.Size = new Size(150, 27);
            nudNumero.TabIndex = 11;
            nudNumero.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CadastroSala
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroSala";
            Text = "CadastroSala";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudCapacidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAssentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFileiras).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumero).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private NumericUpDown nudNumero;
        private ReaLTaiizor.Controls.MaterialLabel lblNumero;
        private ReaLTaiizor.Controls.MaterialLabel lblFileiras;
        private NumericUpDown nudFileiras;
        private NumericUpDown nudAssentos;
        private ReaLTaiizor.Controls.MaterialLabel lblAssentos;
        private ReaLTaiizor.Controls.MaterialLabel lblCapacidade;
        private NumericUpDown nudCapacidade;
    }
}