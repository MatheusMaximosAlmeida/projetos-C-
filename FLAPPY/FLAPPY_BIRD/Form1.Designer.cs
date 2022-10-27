namespace FLAPPY_BIRD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bird = new System.Windows.Forms.PictureBox();
            this.Jogo = new System.Windows.Forms.Timer(this.components);
            this.Ground = new System.Windows.Forms.PictureBox();
            this.tuboInferior = new System.Windows.Forms.PictureBox();
            this.tuboSuperior = new System.Windows.Forms.PictureBox();
            this.lbPlacar = new System.Windows.Forms.Label();
            this.lbMensagem = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboSuperior)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(97, 283);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(96, 96);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 0;
            this.Bird.TabStop = false;
            // 
            // Jogo
            // 
            this.Jogo.Enabled = true;
            this.Jogo.Interval = 10;
            this.Jogo.Tick += new System.EventHandler(this.Jogo_Tick);
            // 
            // Ground
            // 
            this.Ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(0, 598);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1286, 72);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 1;
            this.Ground.TabStop = false;
            // 
            // tuboInferior
            // 
            this.tuboInferior.Image = ((System.Drawing.Image)(resources.GetObject("tuboInferior.Image")));
            this.tuboInferior.Location = new System.Drawing.Point(1097, 359);
            this.tuboInferior.Name = "tuboInferior";
            this.tuboInferior.Size = new System.Drawing.Size(100, 240);
            this.tuboInferior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboInferior.TabIndex = 2;
            this.tuboInferior.TabStop = false;
            // 
            // tuboSuperior
            // 
            this.tuboSuperior.Image = ((System.Drawing.Image)(resources.GetObject("tuboSuperior.Image")));
            this.tuboSuperior.Location = new System.Drawing.Point(781, 0);
            this.tuboSuperior.Name = "tuboSuperior";
            this.tuboSuperior.Size = new System.Drawing.Size(100, 240);
            this.tuboSuperior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tuboSuperior.TabIndex = 2;
            this.tuboSuperior.TabStop = false;
            // 
            // lbPlacar
            // 
            this.lbPlacar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lbPlacar.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Bold);
            this.lbPlacar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(31)))));
            this.lbPlacar.Location = new System.Drawing.Point(721, 617);
            this.lbPlacar.Name = "lbPlacar";
            this.lbPlacar.Size = new System.Drawing.Size(553, 47);
            this.lbPlacar.TabIndex = 3;
            this.lbPlacar.Text = "Placar = 0";
            this.lbPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMensagem
            // 
            this.lbMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.lbMensagem.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.lbMensagem.Location = new System.Drawing.Point(39, 617);
            this.lbMensagem.Name = "lbMensagem";
            this.lbMensagem.Size = new System.Drawing.Size(676, 47);
            this.lbMensagem.TabIndex = 3;
            this.lbMensagem.Text = "ESC para sair";
            this.lbMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.ForeColor = System.Drawing.Color.White;
            this.lbRecord.Location = new System.Drawing.Point(1158, 9);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(116, 30);
            this.lbRecord.TabIndex = 4;
            this.lbRecord.Text = "Recorde: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1286, 670);
            this.Controls.Add(this.lbMensagem);
            this.Controls.Add(this.lbPlacar);
            this.Controls.Add(this.tuboSuperior);
            this.Controls.Add(this.tuboInferior);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.lbRecord);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboSuperior)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Timer Jogo;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox tuboInferior;
        private System.Windows.Forms.PictureBox tuboSuperior;
        private System.Windows.Forms.Label lbPlacar;
        private System.Windows.Forms.Label lbMensagem;
        private System.Windows.Forms.Label lbRecord;
    }
}

