namespace CinemaApp.Cadastros
{
    partial class CadastroSessao
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
            lblData = new ReaLTaiizor.Controls.MaterialLabel();
            dtpData = new DateTimePicker();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            dtpHora = new DateTimePicker();
            cboFilme = new ReaLTaiizor.Controls.MaterialComboBox();
            cboSala = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPreco = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageCadastro.SuspendLayout();
            tabControlCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtPreco);
            tabPageCadastro.Controls.Add(cboSala);
            tabPageCadastro.Controls.Add(cboFilme);
            tabPageCadastro.Controls.Add(dtpHora);
            tabPageCadastro.Controls.Add(materialLabel1);
            tabPageCadastro.Controls.Add(dtpData);
            tabPageCadastro.Controls.Add(lblData);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Location = new Point(4, 29);
            tabPageCadastro.Size = new Size(786, 335);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(lblData, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpData, 0);
            tabPageCadastro.Controls.SetChildIndex(materialLabel1, 0);
            tabPageCadastro.Controls.SetChildIndex(dtpHora, 0);
            tabPageCadastro.Controls.SetChildIndex(cboFilme, 0);
            tabPageCadastro.Controls.SetChildIndex(cboSala, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPreco, 0);
            // 
            // tabControlCadastro
            // 
            tabControlCadastro.Size = new Size(794, 368);
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(688, 178);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 178);
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
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Depth = 0;
            lblData.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblData.Location = new Point(130, 22);
            lblData.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            lblData.Name = "lblData";
            lblData.Size = new Size(43, 24);
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(130, 55);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(99, 27);
            dtpData.TabIndex = 6;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 17.5F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(247, 22);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(44, 24);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Hora";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(247, 55);
            dtpHora.Name = "dtpHora";
            dtpHora.Size = new Size(99, 27);
            dtpHora.TabIndex = 8;
            // 
            // cboFilme
            // 
            cboFilme.AutoResize = false;
            cboFilme.BackColor = Color.FromArgb(255, 255, 255);
            cboFilme.Depth = 0;
            cboFilme.DrawMode = DrawMode.OwnerDrawVariable;
            cboFilme.DropDownHeight = 218;
            cboFilme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilme.DropDownWidth = 121;
            cboFilme.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFilme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFilme.FormattingEnabled = true;
            cboFilme.Hint = "Filme";
            cboFilme.IntegralHeight = false;
            cboFilme.ItemHeight = 54;
            cboFilme.Location = new Point(15, 104);
            cboFilme.MaxDropDownItems = 4;
            cboFilme.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboFilme.Name = "cboFilme";
            cboFilme.Size = new Size(485, 60);
            cboFilme.StartIndex = 0;
            cboFilme.TabIndex = 9;
            // 
            // cboSala
            // 
            cboSala.AutoResize = false;
            cboSala.BackColor = Color.FromArgb(255, 255, 255);
            cboSala.Depth = 0;
            cboSala.DrawMode = DrawMode.OwnerDrawVariable;
            cboSala.DropDownHeight = 218;
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.DropDownWidth = 121;
            cboSala.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSala.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSala.FormattingEnabled = true;
            cboSala.Hint = "Sala";
            cboSala.IntegralHeight = false;
            cboSala.ItemHeight = 54;
            cboSala.Location = new Point(525, 103);
            cboSala.MaxDropDownItems = 4;
            cboSala.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(158, 60);
            cboSala.StartIndex = 0;
            cboSala.TabIndex = 10;
            // 
            // txtPreco
            // 
            txtPreco.AllowPromptAsInput = true;
            txtPreco.AnimateReadOnly = false;
            txtPreco.AsciiOnly = false;
            txtPreco.BackgroundImageLayout = ImageLayout.None;
            txtPreco.BeepOnError = false;
            txtPreco.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.HidePromptOnLeave = false;
            txtPreco.HideSelection = true;
            txtPreco.Hint = "Preço";
            txtPreco.InsertKeyMode = InsertKeyMode.Default;
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(15, 187);
            txtPreco.Mask = "$ 000.00";
            txtPreco.MaxLength = 32767;
            txtPreco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPreco.Name = "txtPreco";
            txtPreco.PasswordChar = '\0';
            txtPreco.PrefixSuffixText = null;
            txtPreco.PromptChar = '_';
            txtPreco.ReadOnly = false;
            txtPreco.RejectInputOnFirstFailure = false;
            txtPreco.ResetOnPrompt = true;
            txtPreco.ResetOnSpace = true;
            txtPreco.RightToLeft = RightToLeft.No;
            txtPreco.SelectedText = "";
            txtPreco.SelectionLength = 0;
            txtPreco.SelectionStart = 0;
            txtPreco.ShortcutsEnabled = true;
            txtPreco.Size = new Size(214, 60);
            txtPreco.SkipLiterals = true;
            txtPreco.TabIndex = 11;
            txtPreco.TabStop = false;
            txtPreco.Text = "R$    ,";
            txtPreco.TextAlign = HorizontalAlignment.Left;
            txtPreco.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPreco.TrailingIcon = null;
            txtPreco.UseSystemPasswordChar = false;
            txtPreco.ValidatingType = null;
            // 
            // CadastroSessao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroSessao";
            Text = "CadastroSessao";
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControlCadastro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboSala;
        private ReaLTaiizor.Controls.MaterialComboBox cboFilme;
        private DateTimePicker dtpHora;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private DateTimePicker dtpData;
        private ReaLTaiizor.Controls.MaterialLabel lblData;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPreco;
    }
}