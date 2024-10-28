namespace GestionBilioteca.View
{
    partial class Frm_Nuevo_Libro_Administrador
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
            this.components = new System.ComponentModel.Container();
            this.crearBtn = new System.Windows.Forms.Button();
            this.Titulo1 = new System.Windows.Forms.Label();
            this.tituloPanel = new System.Windows.Forms.Panel();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.imagenLibro = new System.Windows.Forms.PictureBox();
            this.autorPanel = new System.Windows.Forms.Panel();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.autorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePanel = new System.Windows.Forms.Panel();
            this.fechapublicacionDTP = new System.Windows.Forms.DateTimePicker();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.categoriaComboBoxPanel = new System.Windows.Forms.Panel();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.ejemplaresLabel = new System.Windows.Forms.Label();
            this.ejemplaresPanel = new System.Windows.Forms.Panel();
            this.ejemplaresNUD = new System.Windows.Forms.NumericUpDown();
            this.isbnPanel = new System.Windows.Forms.Panel();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.descripcionPanel = new System.Windows.Forms.Panel();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLibro)).BeginInit();
            this.autorPanel.SuspendLayout();
            this.dateTimePanel.SuspendLayout();
            this.categoriaComboBoxPanel.SuspendLayout();
            this.ejemplaresPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ejemplaresNUD)).BeginInit();
            this.isbnPanel.SuspendLayout();
            this.descripcionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // crearBtn
            // 
            this.crearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.crearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearBtn.Font = new System.Drawing.Font("Anek Tamil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearBtn.ForeColor = System.Drawing.Color.Black;
            this.crearBtn.Location = new System.Drawing.Point(804, 122);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(124, 38);
            this.crearBtn.TabIndex = 54;
            this.crearBtn.Text = "crear";
            this.crearBtn.UseVisualStyleBackColor = false;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Anek Tamil", 20F, System.Drawing.FontStyle.Bold);
            this.Titulo1.ForeColor = System.Drawing.Color.Black;
            this.Titulo1.Location = new System.Drawing.Point(377, 117);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(152, 39);
            this.Titulo1.TabIndex = 53;
            this.Titulo1.Text = "nuevo libro";
            // 
            // tituloPanel
            // 
            this.tituloPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tituloPanel.Controls.Add(this.tituloTextBox);
            this.tituloPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPanel.Location = new System.Drawing.Point(384, 214);
            this.tituloPanel.Name = "tituloPanel";
            this.tituloPanel.Size = new System.Drawing.Size(544, 38);
            this.tituloPanel.TabIndex = 52;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.tituloTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tituloTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloTextBox.Location = new System.Drawing.Point(12, 9);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(516, 14);
            this.tituloTextBox.TabIndex = 17;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.Black;
            this.tituloLabel.Location = new System.Drawing.Point(380, 187);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(41, 18);
            this.tituloLabel.TabIndex = 51;
            this.tituloLabel.Text = "titulo";
            // 
            // imagenLibro
            // 
            this.imagenLibro.Image = global::GestionBilioteca.Properties.Resources.seleccionar_imagen_rectagular;
            this.imagenLibro.Location = new System.Drawing.Point(215, 122);
            this.imagenLibro.Name = "imagenLibro";
            this.imagenLibro.Size = new System.Drawing.Size(156, 210);
            this.imagenLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenLibro.TabIndex = 55;
            this.imagenLibro.TabStop = false;
            this.imagenLibro.Click += new System.EventHandler(this.imagenLibro_Click);
            // 
            // autorPanel
            // 
            this.autorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autorPanel.Controls.Add(this.autorTextBox);
            this.autorPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorPanel.Location = new System.Drawing.Point(385, 294);
            this.autorPanel.Name = "autorPanel";
            this.autorPanel.Size = new System.Drawing.Size(543, 38);
            this.autorPanel.TabIndex = 57;
            // 
            // autorTextBox
            // 
            this.autorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.autorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.autorTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorTextBox.Location = new System.Drawing.Point(12, 9);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(516, 14);
            this.autorTextBox.TabIndex = 17;
            // 
            // autorLabel
            // 
            this.autorLabel.AutoSize = true;
            this.autorLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorLabel.ForeColor = System.Drawing.Color.Black;
            this.autorLabel.Location = new System.Drawing.Point(381, 266);
            this.autorLabel.Name = "autorLabel";
            this.autorLabel.Size = new System.Drawing.Size(43, 18);
            this.autorLabel.TabIndex = 56;
            this.autorLabel.Text = "autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(801, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 59;
            this.label5.Text = "fecha publicacion";
            // 
            // dateTimePanel
            // 
            this.dateTimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimePanel.Controls.Add(this.fechapublicacionDTP);
            this.dateTimePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePanel.Location = new System.Drawing.Point(804, 460);
            this.dateTimePanel.Name = "dateTimePanel";
            this.dateTimePanel.Size = new System.Drawing.Size(124, 38);
            this.dateTimePanel.TabIndex = 58;
            // 
            // fechapublicacionDTP
            // 
            this.fechapublicacionDTP.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.fechapublicacionDTP.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechapublicacionDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechapublicacionDTP.Location = new System.Drawing.Point(3, 7);
            this.fechapublicacionDTP.Name = "fechapublicacionDTP";
            this.fechapublicacionDTP.Size = new System.Drawing.Size(119, 21);
            this.fechapublicacionDTP.TabIndex = 0;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.ForeColor = System.Drawing.Color.Black;
            this.categoriaLabel.Location = new System.Drawing.Point(212, 348);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(69, 18);
            this.categoriaLabel.TabIndex = 61;
            this.categoriaLabel.Text = "categoria";
            // 
            // categoriaComboBoxPanel
            // 
            this.categoriaComboBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoriaComboBoxPanel.Controls.Add(this.categoriaComboBox);
            this.categoriaComboBoxPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaComboBoxPanel.Location = new System.Drawing.Point(216, 376);
            this.categoriaComboBoxPanel.Name = "categoriaComboBoxPanel";
            this.categoriaComboBoxPanel.Size = new System.Drawing.Size(318, 38);
            this.categoriaComboBoxPanel.TabIndex = 60;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.categoriaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriaComboBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "DNI",
            "NIE"});
            this.categoriaComboBox.Location = new System.Drawing.Point(3, 6);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(310, 23);
            this.categoriaComboBox.TabIndex = 22;
            // 
            // ejemplaresLabel
            // 
            this.ejemplaresLabel.AutoSize = true;
            this.ejemplaresLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemplaresLabel.ForeColor = System.Drawing.Color.Black;
            this.ejemplaresLabel.Location = new System.Drawing.Point(801, 511);
            this.ejemplaresLabel.Name = "ejemplaresLabel";
            this.ejemplaresLabel.Size = new System.Drawing.Size(81, 18);
            this.ejemplaresLabel.TabIndex = 63;
            this.ejemplaresLabel.Text = "ejemplares";
            // 
            // ejemplaresPanel
            // 
            this.ejemplaresPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ejemplaresPanel.Controls.Add(this.ejemplaresNUD);
            this.ejemplaresPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemplaresPanel.Location = new System.Drawing.Point(804, 539);
            this.ejemplaresPanel.Name = "ejemplaresPanel";
            this.ejemplaresPanel.Size = new System.Drawing.Size(124, 38);
            this.ejemplaresPanel.TabIndex = 62;
            // 
            // ejemplaresNUD
            // 
            this.ejemplaresNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ejemplaresNUD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ejemplaresNUD.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemplaresNUD.Location = new System.Drawing.Point(7, 9);
            this.ejemplaresNUD.Name = "ejemplaresNUD";
            this.ejemplaresNUD.Size = new System.Drawing.Size(107, 17);
            this.ejemplaresNUD.TabIndex = 64;
            // 
            // isbnPanel
            // 
            this.isbnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.isbnPanel.Controls.Add(this.isbnTextBox);
            this.isbnPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnPanel.Location = new System.Drawing.Point(562, 376);
            this.isbnPanel.Name = "isbnPanel";
            this.isbnPanel.Size = new System.Drawing.Size(366, 38);
            this.isbnPanel.TabIndex = 65;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.isbnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.isbnTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextBox.Location = new System.Drawing.Point(12, 9);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(347, 14);
            this.isbnTextBox.TabIndex = 17;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.ForeColor = System.Drawing.Color.Black;
            this.isbnLabel.Location = new System.Drawing.Point(559, 348);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(35, 18);
            this.isbnLabel.TabIndex = 64;
            this.isbnLabel.Text = "isbn";
            // 
            // descripcionPanel
            // 
            this.descripcionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descripcionPanel.Controls.Add(this.descripcionTextBox);
            this.descripcionPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionPanel.Location = new System.Drawing.Point(215, 460);
            this.descripcionPanel.Name = "descripcionPanel";
            this.descripcionPanel.Size = new System.Drawing.Size(565, 116);
            this.descripcionPanel.TabIndex = 66;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.descripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcionTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(12, 9);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(538, 97);
            this.descripcionTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(212, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "descripción";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBilioteca.Properties.Resources.logo_negro;
            this.pictureBox1.Location = new System.Drawing.Point(996, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Nuevo_Libro_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1152, 684);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descripcionPanel);
            this.Controls.Add(this.isbnPanel);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.ejemplaresLabel);
            this.Controls.Add(this.ejemplaresPanel);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.categoriaComboBoxPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePanel);
            this.Controls.Add(this.autorPanel);
            this.Controls.Add(this.autorLabel);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.tituloPanel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.imagenLibro);
            this.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Frm_Nuevo_Libro_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Nuevo_Libro_Administrador";
            this.Load += new System.EventHandler(this.Frm_Nuevo_Libro_Administrador_Load);
            this.tituloPanel.ResumeLayout(false);
            this.tituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenLibro)).EndInit();
            this.autorPanel.ResumeLayout(false);
            this.autorPanel.PerformLayout();
            this.dateTimePanel.ResumeLayout(false);
            this.categoriaComboBoxPanel.ResumeLayout(false);
            this.ejemplaresPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ejemplaresNUD)).EndInit();
            this.isbnPanel.ResumeLayout(false);
            this.isbnPanel.PerformLayout();
            this.descripcionPanel.ResumeLayout(false);
            this.descripcionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Panel tituloPanel;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.PictureBox imagenLibro;
        private System.Windows.Forms.Panel autorPanel;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.Label autorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel dateTimePanel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.Panel categoriaComboBoxPanel;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.DateTimePicker fechapublicacionDTP;
        private System.Windows.Forms.Label ejemplaresLabel;
        private System.Windows.Forms.Panel ejemplaresPanel;
        private System.Windows.Forms.NumericUpDown ejemplaresNUD;
        private System.Windows.Forms.Panel isbnPanel;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Panel descripcionPanel;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}