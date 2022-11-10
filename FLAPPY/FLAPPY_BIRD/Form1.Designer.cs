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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuboSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // Bird
            // 
            this.Bird.Image = ((System.Drawing.Image)(resources.GetObject("Bird.Image")));
            this.Bird.Location = new System.Drawing.Point(122, 249);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(66, 52);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.lbRecord.BackColor = System.Drawing.Color.Transparent;
            this.lbRecord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.ForeColor = System.Drawing.Color.White;
            this.lbRecord.Location = new System.Drawing.Point(1158, 9);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(116, 30);
            this.lbRecord.TabIndex = 4;
            this.lbRecord.Text = "Recorde: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-34, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(527, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-103, 496);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(181, 144);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(563, 578);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(181, 144);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(926, -82);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(181, 144);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1228, 310);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1237, 577);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(103, 81);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
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
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

