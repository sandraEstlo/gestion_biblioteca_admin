namespace GestionBilioteca.View
{
    partial class Frm_Listar_Busqueda_Libros
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
            this.titulo1 = new System.Windows.Forms.Label();
            this.librosListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Anek Tamil", 14.25F, System.Drawing.FontStyle.Bold);
            this.titulo1.ForeColor = System.Drawing.Color.Black;
            this.titulo1.Location = new System.Drawing.Point(71, 47);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(102, 27);
            this.titulo1.TabIndex = 60;
            this.titulo1.Text = "lista libros";
            // 
            // librosListBox
            // 
            this.librosListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.librosListBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librosListBox.FormattingEnabled = true;
            this.librosListBox.ItemHeight = 15;
            this.librosListBox.Location = new System.Drawing.Point(75, 87);
            this.librosListBox.Name = "librosListBox";
            this.librosListBox.ScrollAlwaysVisible = true;
            this.librosListBox.Size = new System.Drawing.Size(632, 319);
            this.librosListBox.TabIndex = 59;
            // 
            // Frm_Listar_Busqueda_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.titulo1);
            this.Controls.Add(this.librosListBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Frm_Listar_Busqueda_Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Listar_Busqueda_Libros";
            this.Load += new System.EventHandler(this.Frm_Listar_Busqueda_Libros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.ListBox librosListBox;
    }
}