namespace GestionBilioteca
{
    partial class Frm_Login
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
            this.claveLabel = new System.Windows.Forms.Label();
            this.correoLabel = new System.Windows.Forms.Label();
            this.registroBtn = new System.Windows.Forms.Button();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.correoTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagotipo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagotipo)).BeginInit();
            this.SuspendLayout();
            // 
            // claveLabel
            // 
            this.claveLabel.AutoSize = true;
            this.claveLabel.Font = new System.Drawing.Font("Montserrat", 10F);
            this.claveLabel.ForeColor = System.Drawing.Color.Black;
            this.claveLabel.Location = new System.Drawing.Point(447, 258);
            this.claveLabel.Name = "claveLabel";
            this.claveLabel.Size = new System.Drawing.Size(86, 20);
            this.claveLabel.TabIndex = 12;
            this.claveLabel.Text = "contraseña";
            // 
            // correoLabel
            // 
            this.correoLabel.AutoSize = true;
            this.correoLabel.Font = new System.Drawing.Font("Montserrat", 10F);
            this.correoLabel.ForeColor = System.Drawing.Color.Black;
            this.correoLabel.Location = new System.Drawing.Point(447, 192);
            this.correoLabel.Name = "correoLabel";
            this.correoLabel.Size = new System.Drawing.Size(55, 20);
            this.correoLabel.TabIndex = 11;
            this.correoLabel.Text = "correo";
            // 
            // registroBtn
            // 
            this.registroBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.registroBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.registroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registroBtn.Font = new System.Drawing.Font("Anek Tamil SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.registroBtn.ForeColor = System.Drawing.Color.Black;
            this.registroBtn.Location = new System.Drawing.Point(605, 33);
            this.registroBtn.Name = "registroBtn";
            this.registroBtn.Size = new System.Drawing.Size(124, 33);
            this.registroBtn.TabIndex = 10;
            this.registroBtn.Text = "registro";
            this.registroBtn.UseVisualStyleBackColor = false;
            this.registroBtn.Click += new System.EventHandler(this.registroBtn_Click);
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Anek Tamil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.ForeColor = System.Drawing.Color.Black;
            this.Titulo1.Location = new System.Drawing.Point(475, 116);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(174, 39);
            this.Titulo1.TabIndex = 9;
            this.Titulo1.Text = "Iniciar sesión";
            // 
            // entrarBtn
            // 
            this.entrarBtn.BackColor = System.Drawing.Color.Black;
            this.entrarBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.entrarBtn.FlatAppearance.BorderSize = 0;
            this.entrarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarBtn.Font = new System.Drawing.Font("Anek Tamil SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.entrarBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.entrarBtn.Location = new System.Drawing.Point(497, 343);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(124, 33);
            this.entrarBtn.TabIndex = 8;
            this.entrarBtn.Text = "entrar";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // claveTextBox
            // 
            this.claveTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.claveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claveTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8F);
            this.claveTextBox.Location = new System.Drawing.Point(12, 8);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(182, 14);
            this.claveTextBox.TabIndex = 13;
            this.claveTextBox.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.claveTextBox);
            this.panel2.Location = new System.Drawing.Point(451, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 33);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBilioteca.Properties.Resources.visibility_off_FILL0_wght400_GRAD0_opsz24;
            this.pictureBox1.Location = new System.Drawing.Point(201, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // correoTextBox
            // 
            this.correoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.correoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correoTextBox.Font = new System.Drawing.Font("Montserrat Medium", 8F);
            this.correoTextBox.Location = new System.Drawing.Point(12, 8);
            this.correoTextBox.Name = "correoTextBox";
            this.correoTextBox.Size = new System.Drawing.Size(207, 14);
            this.correoTextBox.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.correoTextBox);
            this.panel1.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(451, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 33);
            this.panel1.TabIndex = 15;
            // 
            // imagotipo
            // 
            this.imagotipo.Image = global::GestionBilioteca.Properties.Resources.logo_2;
            this.imagotipo.Location = new System.Drawing.Point(116, 56);
            this.imagotipo.Name = "imagotipo";
            this.imagotipo.Size = new System.Drawing.Size(208, 329);
            this.imagotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagotipo.TabIndex = 3;
            this.imagotipo.TabStop = false;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.entrarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.claveLabel);
            this.Controls.Add(this.correoLabel);
            this.Controls.Add(this.registroBtn);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.entrarBtn);
            this.Controls.Add(this.imagotipo);
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagotipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagotipo;
        private System.Windows.Forms.Label claveLabel;
        private System.Windows.Forms.Label correoLabel;
        private System.Windows.Forms.Button registroBtn;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox correoTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

