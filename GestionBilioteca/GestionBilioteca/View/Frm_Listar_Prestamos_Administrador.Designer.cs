namespace GestionBilioteca.View
{
    partial class Frm_Listar_Prestamos_Administrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.dniComboBoxPanel = new System.Windows.Forms.Panel();
            this.filtrarButton = new System.Windows.Forms.Button();
            this.busquedaPanel = new System.Windows.Forms.Panel();
            this.busquedaTextBox = new System.Windows.Forms.TextBox();
            this.prestamosDataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Busquedabutton = new System.Windows.Forms.Button();
            this.dniComboBoxPanel.SuspendLayout();
            this.busquedaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.BackColor = System.Drawing.Color.Black;
            this.nuevoBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(66)))), ((int)(((byte)(234)))));
            this.nuevoBtn.FlatAppearance.BorderSize = 0;
            this.nuevoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoBtn.Font = new System.Drawing.Font("Anek Tamil", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.nuevoBtn.Location = new System.Drawing.Point(933, 123);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.Size = new System.Drawing.Size(124, 33);
            this.nuevoBtn.TabIndex = 57;
            this.nuevoBtn.Text = "nuevo";
            this.nuevoBtn.UseVisualStyleBackColor = false;
            this.nuevoBtn.Click += new System.EventHandler(this.nuevoBtn_Click);
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Anek Tamil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.ForeColor = System.Drawing.Color.Black;
            this.Titulo1.Location = new System.Drawing.Point(97, 117);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(216, 39);
            this.Titulo1.TabIndex = 50;
            this.Titulo1.Text = "listar prestamos";
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.tipoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoComboBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Items.AddRange(new object[] {
            "Prestamos sin devolver",
            "Prestamos devueltos",
            "Prestamos pendientes retrasados"});
            this.tipoComboBox.Location = new System.Drawing.Point(3, 4);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(316, 23);
            this.tipoComboBox.TabIndex = 22;
            // 
            // dniComboBoxPanel
            // 
            this.dniComboBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dniComboBoxPanel.Controls.Add(this.tipoComboBox);
            this.dniComboBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniComboBoxPanel.Location = new System.Drawing.Point(104, 183);
            this.dniComboBoxPanel.Name = "dniComboBoxPanel";
            this.dniComboBoxPanel.Size = new System.Drawing.Size(324, 33);
            this.dniComboBoxPanel.TabIndex = 56;
            // 
            // filtrarButton
            // 
            this.filtrarButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.filtrarButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.filtrarButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.filtrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrarButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarButton.Location = new System.Drawing.Point(437, 183);
            this.filtrarButton.Name = "filtrarButton";
            this.filtrarButton.Size = new System.Drawing.Size(80, 33);
            this.filtrarButton.TabIndex = 54;
            this.filtrarButton.Text = "Filtrar";
            this.filtrarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtrarButton.UseVisualStyleBackColor = true;
            this.filtrarButton.Click += new System.EventHandler(this.filtrarButton_Click);
            // 
            // busquedaPanel
            // 
            this.busquedaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busquedaPanel.Controls.Add(this.busquedaTextBox);
            this.busquedaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaPanel.Location = new System.Drawing.Point(536, 183);
            this.busquedaPanel.Name = "busquedaPanel";
            this.busquedaPanel.Size = new System.Drawing.Size(476, 33);
            this.busquedaPanel.TabIndex = 52;
            // 
            // busquedaTextBox
            // 
            this.busquedaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.busquedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.busquedaTextBox.Location = new System.Drawing.Point(12, 8);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(459, 13);
            this.busquedaTextBox.TabIndex = 17;
            // 
            // prestamosDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.prestamosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.prestamosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prestamosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.prestamosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prestamosDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.prestamosDataGridView.EnableHeadersVisualStyles = false;
            this.prestamosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.prestamosDataGridView.Location = new System.Drawing.Point(104, 234);
            this.prestamosDataGridView.Name = "prestamosDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prestamosDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.prestamosDataGridView.Size = new System.Drawing.Size(953, 370);
            this.prestamosDataGridView.TabIndex = 51;
            this.prestamosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prestamosDataGridView_CellContentClick);
            this.prestamosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prestamosDataGridView_CellDoubleClick);
            this.prestamosDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.prestamosDataGridView_CellFormatting);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBilioteca.Properties.Resources.logo_negro;
            this.pictureBox1.Location = new System.Drawing.Point(998, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionBilioteca.Properties.Resources.icono_filtrar_negro;
            this.pictureBox2.Location = new System.Drawing.Point(488, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // Busquedabutton
            // 
            this.Busquedabutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Busquedabutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.Busquedabutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.Busquedabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Busquedabutton.Image = global::GestionBilioteca.Properties.Resources.icono_buscar_negro;
            this.Busquedabutton.Location = new System.Drawing.Point(1022, 183);
            this.Busquedabutton.Name = "Busquedabutton";
            this.Busquedabutton.Size = new System.Drawing.Size(33, 33);
            this.Busquedabutton.TabIndex = 53;
            this.Busquedabutton.UseVisualStyleBackColor = true;
            this.Busquedabutton.Click += new System.EventHandler(this.Busquedabutton_Click);
            // 
            // Frm_Listar_Prestamos_Administrador
            // 
            this.AcceptButton = this.nuevoBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1152, 684);
            this.Controls.Add(this.nuevoBtn);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dniComboBoxPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.filtrarButton);
            this.Controls.Add(this.Busquedabutton);
            this.Controls.Add(this.busquedaPanel);
            this.Controls.Add(this.prestamosDataGridView);
            this.MaximizeBox = false;
            this.Name = "Frm_Listar_Prestamos_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Listar_Prestamos_Administrador";
            this.Load += new System.EventHandler(this.Frm_Listar_Prestamos_Administrador_Load);
            this.dniComboBoxPanel.ResumeLayout(false);
            this.busquedaPanel.ResumeLayout(false);
            this.busquedaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoBtn;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.Panel dniComboBoxPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button filtrarButton;
        private System.Windows.Forms.Button Busquedabutton;
        private System.Windows.Forms.Panel busquedaPanel;
        private System.Windows.Forms.TextBox busquedaTextBox;
        private System.Windows.Forms.DataGridView prestamosDataGridView;
    }
}