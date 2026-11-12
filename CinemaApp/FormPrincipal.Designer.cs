namespace CinemaApp
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            gêneroToolStripMenuItem = new ToolStripMenuItem();
            filmeToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            sessãoToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            ingressoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, vendaToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(534, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gêneroToolStripMenuItem, filmeToolStripMenuItem, salaToolStripMenuItem, sessãoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";

            // 
            // gêneroToolStripMenuItem
            // 
            gêneroToolStripMenuItem.Name = "gêneroToolStripMenuItem";
            gêneroToolStripMenuItem.Size = new Size(180, 22);
            gêneroToolStripMenuItem.Text = "Gênero";
            gêneroToolStripMenuItem.Click += gêneroToolStripMenuItem_Click;

            // 
            // filmeToolStripMenuItem
            // 
            filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            filmeToolStripMenuItem.Size = new Size(180, 22);
            filmeToolStripMenuItem.Text = "Filme";
            filmeToolStripMenuItem.Click += filmeToolStripMenuItem_Click;

            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(180, 22);
            salaToolStripMenuItem.Text = "Sala";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click;

            // 
            // sessãoToolStripMenuItem
            // 
            sessãoToolStripMenuItem.Name = "sessãoToolStripMenuItem";
            sessãoToolStripMenuItem.Size = new Size(180, 22);
            sessãoToolStripMenuItem.Text = "Sessão";

            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ingressoToolStripMenuItem });
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(51, 20);
            vendaToolStripMenuItem.Text = "Venda";

            // 
            // ingressoToolStripMenuItem
            // 
            ingressoToolStripMenuItem.Name = "ingressoToolStripMenuItem";
            ingressoToolStripMenuItem.Size = new Size(118, 22);
            ingressoToolStripMenuItem.Text = "Ingresso";

            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 356);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Sistema de Gerencimento de Cinemas";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem gêneroToolStripMenuItem;
        private ToolStripMenuItem filmeToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem sessãoToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem ingressoToolStripMenuItem;
    }
}