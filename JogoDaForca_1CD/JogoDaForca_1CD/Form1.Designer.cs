namespace JogoDaForca_1CD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btJogoar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btJogarNovamente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btTentar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLetra = new System.Windows.Forms.TextBox();
            this.lbSobre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btJogoar
            // 
            this.btJogoar.Location = new System.Drawing.Point(12, 12);
            this.btJogoar.Name = "btJogoar";
            this.btJogoar.Size = new System.Drawing.Size(132, 23);
            this.btJogoar.TabIndex = 1;
            this.btJogoar.Text = "JOGAR";
            this.btJogoar.UseVisualStyleBackColor = true;
            this.btJogoar.Click += new System.EventHandler(this.btJogoar_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(150, 12);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(132, 23);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btJogarNovamente
            // 
            this.btJogarNovamente.Location = new System.Drawing.Point(288, 12);
            this.btJogarNovamente.Name = "btJogarNovamente";
            this.btJogarNovamente.Size = new System.Drawing.Size(132, 23);
            this.btJogarNovamente.TabIndex = 3;
            this.btJogarNovamente.Text = "JOGAR NOVAMENTE";
            this.btJogarNovamente.UseVisualStyleBackColor = true;
            this.btJogarNovamente.Click += new System.EventHandler(this.btJogarNovamente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // btTentar
            // 
            this.btTentar.Location = new System.Drawing.Point(132, 205);
            this.btTentar.Name = "btTentar";
            this.btTentar.Size = new System.Drawing.Size(114, 23);
            this.btTentar.TabIndex = 5;
            this.btTentar.Text = "TENTAR";
            this.btTentar.UseVisualStyleBackColor = true;
            this.btTentar.Click += new System.EventHandler(this.btTentar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // tbLetra
            // 
            this.tbLetra.Location = new System.Drawing.Point(12, 208);
            this.tbLetra.Name = "tbLetra";
            this.tbLetra.Size = new System.Drawing.Size(114, 20);
            this.tbLetra.TabIndex = 7;
            // 
            // lbSobre
            // 
            this.lbSobre.AutoSize = true;
            this.lbSobre.Location = new System.Drawing.Point(441, 17);
            this.lbSobre.Name = "lbSobre";
            this.lbSobre.Size = new System.Drawing.Size(44, 13);
            this.lbSobre.TabIndex = 8;
            this.lbSobre.Text = "SOBRE";
            this.lbSobre.Click += new System.EventHandler(this.lbSobre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "LETRA:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JogoDaForca_1CD.Properties.Resources._459px_Vraagteken_svg;
            this.pictureBox1.Location = new System.Drawing.Point(347, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSobre);
            this.Controls.Add(this.tbLetra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btJogarNovamente);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btJogoar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ADVINHE A PALAVRA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btJogoar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btJogarNovamente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTentar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLetra;
        private System.Windows.Forms.Label lbSobre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

