namespace GestionBilioteca.View
{
    partial class Frm_Detalles_Libro
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelid = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ejemLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.disLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.fpLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBilioteca.Properties.Resources.seleccionar_imagen_rectagular;
            this.pictureBox1.Location = new System.Drawing.Point(47, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.descripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcionTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(12, 9);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ReadOnly = true;
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionTextBox.Size = new System.Drawing.Size(320, 102);
            this.descripcionTextBox.TabIndex = 17;
            this.descripcionTextBox.Text = "autor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.descripcionTextBox);
            this.panel1.Location = new System.Drawing.Point(378, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 126);
            this.panel1.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelid);
            this.panel2.Controls.Add(this.autorTextBox);
            this.panel2.Controls.Add(this.tituloTextBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(378, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 190);
            this.panel2.TabIndex = 76;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(249, 167);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(17, 15);
            this.labelid.TabIndex = 14;
            this.labelid.Text = "id";
            // 
            // autorTextBox
            // 
            this.autorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.autorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autorTextBox.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTextBox.Location = new System.Drawing.Point(32, 102);
            this.autorTextBox.Multiline = true;
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.ReadOnly = true;
            this.autorTextBox.Size = new System.Drawing.Size(280, 66);
            this.autorTextBox.TabIndex = 13;
            this.autorTextBox.Text = "autor";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.Font = new System.Drawing.Font("Anek Tamil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(30, 30);
            this.tituloTextBox.Multiline = true;
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(280, 66);
            this.tituloTextBox.TabIndex = 12;
            this.tituloTextBox.Text = "titulo";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ejemLabel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(378, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 45);
            this.panel3.TabIndex = 77;
            // 
            // ejemLabel
            // 
            this.ejemLabel.AutoSize = true;
            this.ejemLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemLabel.ForeColor = System.Drawing.Color.Black;
            this.ejemLabel.Location = new System.Drawing.Point(42, 22);
            this.ejemLabel.Name = "ejemLabel";
            this.ejemLabel.Size = new System.Drawing.Size(14, 15);
            this.ejemLabel.TabIndex = 13;
            this.ejemLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ejemplares";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.disLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(479, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 45);
            this.panel4.TabIndex = 78;
            // 
            // disLabel
            // 
            this.disLabel.AutoSize = true;
            this.disLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disLabel.ForeColor = System.Drawing.Color.Black;
            this.disLabel.Location = new System.Drawing.Point(40, 22);
            this.disLabel.Name = "disLabel";
            this.disLabel.Size = new System.Drawing.Size(14, 15);
            this.disLabel.TabIndex = 14;
            this.disLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Disponibles";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.fpLabel);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(580, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(138, 45);
            this.panel5.TabIndex = 79;
            // 
            // fpLabel
            // 
            this.fpLabel.AutoSize = true;
            this.fpLabel.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpLabel.ForeColor = System.Drawing.Color.Black;
            this.fpLabel.Location = new System.Drawing.Point(56, 22);
            this.fpLabel.Name = "fpLabel";
            this.fpLabel.Size = new System.Drawing.Size(14, 15);
            this.fpLabel.TabIndex = 15;
            this.fpLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha publicacion";
            // 
            // Frm_Detalles_Libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Frm_Detalles_Libro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Detalles_Libro";
            this.Load += new System.EventHandler(this.Frm_Detalles_Libro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ejemLabel;
        private System.Windows.Forms.Label disLabel;
        private System.Windows.Forms.Label fpLabel;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.Label labelid;
    }
}