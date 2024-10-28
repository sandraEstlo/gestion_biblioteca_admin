namespace GestionBilioteca.View
{
    partial class Frm_Listar_Busqueda_Usuarios
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
            this.usuariosListBox = new System.Windows.Forms.ListBox();
            this.titulo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usuariosListBox
            // 
            this.usuariosListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.usuariosListBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosListBox.FormattingEnabled = true;
            this.usuariosListBox.ItemHeight = 15;
            this.usuariosListBox.Location = new System.Drawing.Point(61, 84);
            this.usuariosListBox.Name = "usuariosListBox";
            this.usuariosListBox.ScrollAlwaysVisible = true;
            this.usuariosListBox.Size = new System.Drawing.Size(632, 319);
            this.usuariosListBox.TabIndex = 0;
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Anek Tamil", 14.25F, System.Drawing.FontStyle.Bold);
            this.titulo1.ForeColor = System.Drawing.Color.Black;
            this.titulo1.Location = new System.Drawing.Point(57, 44);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(127, 27);
            this.titulo1.TabIndex = 58;
            this.titulo1.Text = "lista usuarios";
            // 
            // Frm_Listar_Busqueda_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(778, 463);
            this.Controls.Add(this.titulo1);
            this.Controls.Add(this.usuariosListBox);
            this.MaximizeBox = false;
            this.Name = "Frm_Listar_Busqueda_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Listar_Busqueda_Usuarios";
            this.Load += new System.EventHandler(this.Frm_Listar_Busqueda_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usuariosListBox;
        private System.Windows.Forms.Label titulo1;
    }
}