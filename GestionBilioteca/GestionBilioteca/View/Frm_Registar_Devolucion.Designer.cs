namespace GestionBilioteca.View
{
    partial class Frm_Registar_Devolucion
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
            this.Titulo1 = new System.Windows.Forms.Label();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.busquedaPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.devolverBtn = new System.Windows.Forms.Button();
            this.busquedaPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Anek Tamil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.ForeColor = System.Drawing.Color.Black;
            this.Titulo1.Location = new System.Drawing.Point(163, 96);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(259, 39);
            this.Titulo1.TabIndex = 51;
            this.Titulo1.Text = "registrar devolucion";
            // 
            // autorTextBox
            // 
            this.autorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.autorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autorTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTextBox.Location = new System.Drawing.Point(12, 8);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.ReadOnly = true;
            this.autorTextBox.Size = new System.Drawing.Size(427, 14);
            this.autorTextBox.TabIndex = 17;
            // 
            // busquedaPanel
            // 
            this.busquedaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busquedaPanel.Controls.Add(this.autorTextBox);
            this.busquedaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaPanel.Location = new System.Drawing.Point(169, 263);
            this.busquedaPanel.Name = "busquedaPanel";
            this.busquedaPanel.Size = new System.Drawing.Size(445, 33);
            this.busquedaPanel.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tituloTextBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(169, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 33);
            this.panel1.TabIndex = 54;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(12, 8);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.ReadOnly = true;
            this.tituloTextBox.Size = new System.Drawing.Size(427, 14);
            this.tituloTextBox.TabIndex = 17;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.Black;
            this.tituloLabel.Location = new System.Drawing.Point(166, 163);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(41, 18);
            this.tituloLabel.TabIndex = 57;
            this.tituloLabel.Text = "titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(166, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(166, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "usuario";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.usuarioTextBox);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(169, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 33);
            this.panel2.TabIndex = 59;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(12, 8);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.ReadOnly = true;
            this.usuarioTextBox.Size = new System.Drawing.Size(427, 14);
            this.usuarioTextBox.TabIndex = 17;
            // 
            // devolverBtn
            // 
            this.devolverBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.devolverBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.devolverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devolverBtn.Font = new System.Drawing.Font("Anek Tamil SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devolverBtn.ForeColor = System.Drawing.Color.Black;
            this.devolverBtn.Location = new System.Drawing.Point(490, 100);
            this.devolverBtn.Name = "devolverBtn";
            this.devolverBtn.Size = new System.Drawing.Size(124, 33);
            this.devolverBtn.TabIndex = 72;
            this.devolverBtn.Text = "devolver";
            this.devolverBtn.UseVisualStyleBackColor = false;
            this.devolverBtn.Click += new System.EventHandler(this.devolverBtn_Click);
            // 
            // Frm_Registar_Devolucion
            // 
            this.AcceptButton = this.devolverBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.devolverBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.busquedaPanel);
            this.Controls.Add(this.Titulo1);
            this.MaximizeBox = false;
            this.Name = "Frm_Registar_Devolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva devolución";
            this.Load += new System.EventHandler(this.Frm_Registar_Devolucion_Load);
            this.busquedaPanel.ResumeLayout(false);
            this.busquedaPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.Panel busquedaPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Button devolverBtn;
    }
}