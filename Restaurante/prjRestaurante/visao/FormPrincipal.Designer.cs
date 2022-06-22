namespace prjRestaurante.visao
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnProdutos,
            this.mnMesas,
            this.mnComandas,
            this.mnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1428, 44);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnProdutos
            // 
            this.mnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnProdutos.Image")));
            this.mnProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Padding = new System.Windows.Forms.Padding(16, 8, 4, 8);
            this.mnProdutos.Size = new System.Drawing.Size(103, 44);
            this.mnProdutos.Text = "Produtos";
            this.mnProdutos.Click += new System.EventHandler(this.mnProdutos_Click);
            // 
            // mnMesas
            // 
            this.mnMesas.Image = ((System.Drawing.Image)(resources.GetObject("mnMesas.Image")));
            this.mnMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnMesas.Name = "mnMesas";
            this.mnMesas.Padding = new System.Windows.Forms.Padding(16, 8, 4, 8);
            this.mnMesas.Size = new System.Drawing.Size(88, 44);
            this.mnMesas.Text = "Mesas";
            // 
            // mnComandas
            // 
            this.mnComandas.Image = ((System.Drawing.Image)(resources.GetObject("mnComandas.Image")));
            this.mnComandas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnComandas.Name = "mnComandas";
            this.mnComandas.Padding = new System.Windows.Forms.Padding(16, 8, 4, 8);
            this.mnComandas.Size = new System.Drawing.Size(112, 44);
            this.mnComandas.Text = "Comandas";
            // 
            // mnSair
            // 
            this.mnSair.Image = ((System.Drawing.Image)(resources.GetObject("mnSair.Image")));
            this.mnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnSair.Name = "mnSair";
            this.mnSair.Padding = new System.Windows.Forms.Padding(16, 8, 4, 8);
            this.mnSair.Size = new System.Drawing.Size(74, 44);
            this.mnSair.Text = "Sair";
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 826);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.Text = "Controle de restaurante";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnMesas;
        private System.Windows.Forms.ToolStripMenuItem mnComandas;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}