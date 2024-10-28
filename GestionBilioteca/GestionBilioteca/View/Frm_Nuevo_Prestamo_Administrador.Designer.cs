namespace GestionBilioteca.View
{
    partial class Frm_Nuevo_Prestamo_Administrador
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
            this.Titulo1 = new System.Windows.Forms.Label();
            this.busquedaUsuariobutton = new System.Windows.Forms.Button();
            this.busquedaPanel = new System.Windows.Forms.Panel();
            this.busquedaUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.criterioUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.busquedaLibroButton = new System.Windows.Forms.Button();
            this.busquedaLibroPanel = new System.Windows.Forms.Panel();
            this.libroBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codLibroPanel = new System.Windows.Forms.Panel();
            this.codLibroTextBox = new System.Windows.Forms.TextBox();
            this.codUsuarioPanel = new System.Windows.Forms.Panel();
            this.codUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.fechaPrestamoPanel = new System.Windows.Forms.Panel();
            this.fechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.crearBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.busquedaPanel.SuspendLayout();
            this.busquedaLibroPanel.SuspendLayout();
            this.codLibroPanel.SuspendLayout();
            this.codUsuarioPanel.SuspendLayout();
            this.fechaPrestamoPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionBilioteca.Properties.Resources.logo_negro;
            this.pictureBox1.Location = new System.Drawing.Point(998, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Anek Tamil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.ForeColor = System.Drawing.Color.Black;
            this.Titulo1.Location = new System.Drawing.Point(97, 117);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(216, 39);
            this.Titulo1.TabIndex = 51;
            this.Titulo1.Text = "listar prestamos";
            // 
            // busquedaUsuariobutton
            // 
            this.busquedaUsuariobutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.busquedaUsuariobutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.busquedaUsuariobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.busquedaUsuariobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busquedaUsuariobutton.Image = global::GestionBilioteca.Properties.Resources.icono_buscar_negro;
            this.busquedaUsuariobutton.Location = new System.Drawing.Point(496, 109);
            this.busquedaUsuariobutton.Name = "busquedaUsuariobutton";
            this.busquedaUsuariobutton.Size = new System.Drawing.Size(33, 33);
            this.busquedaUsuariobutton.TabIndex = 56;
            this.busquedaUsuariobutton.UseVisualStyleBackColor = true;
            this.busquedaUsuariobutton.Click += new System.EventHandler(this.BusquedaUsuariobutton_Click);
            // 
            // busquedaPanel
            // 
            this.busquedaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busquedaPanel.Controls.Add(this.busquedaUsuarioTextBox);
            this.busquedaPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaPanel.Location = new System.Drawing.Point(53, 109);
            this.busquedaPanel.Name = "busquedaPanel";
            this.busquedaPanel.Size = new System.Drawing.Size(434, 33);
            this.busquedaPanel.TabIndex = 55;
            // 
            // busquedaUsuarioTextBox
            // 
            this.busquedaUsuarioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.busquedaUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaUsuarioTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaUsuarioTextBox.Location = new System.Drawing.Point(12, 8);
            this.busquedaUsuarioTextBox.Name = "busquedaUsuarioTextBox";
            this.busquedaUsuarioTextBox.Size = new System.Drawing.Size(400, 14);
            this.busquedaUsuarioTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Anek Tamil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(151, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 57;
            this.label1.Text = "libro";
            // 
            // criterioUsuario
            // 
            this.criterioUsuario.AutoSize = true;
            this.criterioUsuario.Font = new System.Drawing.Font("Montserrat", 10F);
            this.criterioUsuario.ForeColor = System.Drawing.Color.Black;
            this.criterioUsuario.Location = new System.Drawing.Point(151, 270);
            this.criterioUsuario.Name = "criterioUsuario";
            this.criterioUsuario.Size = new System.Drawing.Size(153, 20);
            this.criterioUsuario.TabIndex = 58;
            this.criterioUsuario.Text = "criterio de busqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "criterio de busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Anek Tamil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(151, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 62;
            this.label3.Text = "usuario";
            // 
            // busquedaLibroButton
            // 
            this.busquedaLibroButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.busquedaLibroButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.busquedaLibroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.busquedaLibroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.busquedaLibroButton.Image = global::GestionBilioteca.Properties.Resources.icono_buscar_negro;
            this.busquedaLibroButton.Location = new System.Drawing.Point(496, 109);
            this.busquedaLibroButton.Name = "busquedaLibroButton";
            this.busquedaLibroButton.Size = new System.Drawing.Size(33, 33);
            this.busquedaLibroButton.TabIndex = 61;
            this.busquedaLibroButton.UseVisualStyleBackColor = true;
            this.busquedaLibroButton.Click += new System.EventHandler(this.busquedaLibroButton_Click);
            // 
            // busquedaLibroPanel
            // 
            this.busquedaLibroPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busquedaLibroPanel.Controls.Add(this.libroBusquedaTextBox);
            this.busquedaLibroPanel.Controls.Add(this.textBox1);
            this.busquedaLibroPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaLibroPanel.Location = new System.Drawing.Point(53, 109);
            this.busquedaLibroPanel.Name = "busquedaLibroPanel";
            this.busquedaLibroPanel.Size = new System.Drawing.Size(434, 33);
            this.busquedaLibroPanel.TabIndex = 60;
            // 
            // libroBusquedaTextBox
            // 
            this.libroBusquedaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.libroBusquedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.libroBusquedaTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libroBusquedaTextBox.Location = new System.Drawing.Point(12, 8);
            this.libroBusquedaTextBox.Name = "libroBusquedaTextBox";
            this.libroBusquedaTextBox.Size = new System.Drawing.Size(400, 14);
            this.libroBusquedaTextBox.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox1.Location = new System.Drawing.Point(12, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 13);
            this.textBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Anek Tamil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(764, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 64;
            this.label4.Text = "prestamo";
            // 
            // codLibroPanel
            // 
            this.codLibroPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codLibroPanel.Controls.Add(this.codLibroTextBox);
            this.codLibroPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codLibroPanel.Location = new System.Drawing.Point(768, 310);
            this.codLibroPanel.Name = "codLibroPanel";
            this.codLibroPanel.Size = new System.Drawing.Size(230, 33);
            this.codLibroPanel.TabIndex = 65;
            // 
            // codLibroTextBox
            // 
            this.codLibroTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.codLibroTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codLibroTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codLibroTextBox.Location = new System.Drawing.Point(12, 8);
            this.codLibroTextBox.Name = "codLibroTextBox";
            this.codLibroTextBox.ReadOnly = true;
            this.codLibroTextBox.Size = new System.Drawing.Size(213, 14);
            this.codLibroTextBox.TabIndex = 17;
            // 
            // codUsuarioPanel
            // 
            this.codUsuarioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codUsuarioPanel.Controls.Add(this.codUsuarioTextBox);
            this.codUsuarioPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codUsuarioPanel.Location = new System.Drawing.Point(768, 391);
            this.codUsuarioPanel.Name = "codUsuarioPanel";
            this.codUsuarioPanel.Size = new System.Drawing.Size(230, 33);
            this.codUsuarioPanel.TabIndex = 66;
            // 
            // codUsuarioTextBox
            // 
            this.codUsuarioTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.codUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codUsuarioTextBox.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codUsuarioTextBox.Location = new System.Drawing.Point(12, 8);
            this.codUsuarioTextBox.Name = "codUsuarioTextBox";
            this.codUsuarioTextBox.ReadOnly = true;
            this.codUsuarioTextBox.Size = new System.Drawing.Size(213, 14);
            this.codUsuarioTextBox.TabIndex = 17;
            // 
            // fechaPrestamoPanel
            // 
            this.fechaPrestamoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fechaPrestamoPanel.Controls.Add(this.fechaPrestamo);
            this.fechaPrestamoPanel.Controls.Add(this.textBox4);
            this.fechaPrestamoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPrestamoPanel.Location = new System.Drawing.Point(768, 473);
            this.fechaPrestamoPanel.Name = "fechaPrestamoPanel";
            this.fechaPrestamoPanel.Size = new System.Drawing.Size(230, 33);
            this.fechaPrestamoPanel.TabIndex = 67;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.fechaPrestamo.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaPrestamo.Location = new System.Drawing.Point(7, 5);
            this.fechaPrestamo.Name = "fechaPrestamo";
            this.fechaPrestamo.Size = new System.Drawing.Size(218, 21);
            this.fechaPrestamo.TabIndex = 72;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox4.Location = new System.Drawing.Point(12, 8);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 13);
            this.textBox4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(764, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "código libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(764, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "código usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(764, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 70;
            this.label7.Text = "fecha prestamo";
            // 
            // crearBtn
            // 
            this.crearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.crearBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.crearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearBtn.Font = new System.Drawing.Font("Anek Tamil SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearBtn.ForeColor = System.Drawing.Color.Black;
            this.crearBtn.Location = new System.Drawing.Point(924, 117);
            this.crearBtn.Name = "crearBtn";
            this.crearBtn.Size = new System.Drawing.Size(124, 33);
            this.crearBtn.TabIndex = 71;
            this.crearBtn.Text = "crear";
            this.crearBtn.UseVisualStyleBackColor = false;
            this.crearBtn.Click += new System.EventHandler(this.crearBtn_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.busquedaLibroPanel);
            this.panel5.Controls.Add(this.busquedaLibroButton);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(101, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(595, 194);
            this.panel5.TabIndex = 72;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.textBox2.Location = new System.Drawing.Point(12, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 13);
            this.textBox2.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.busquedaPanel);
            this.panel6.Controls.Add(this.busquedaUsuariobutton);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(101, 399);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(595, 194);
            this.panel6.TabIndex = 73;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(713, 188);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(335, 405);
            this.panel7.TabIndex = 74;
            // 
            // Frm_Nuevo_Prestamo_Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1152, 684);
            this.Controls.Add(this.crearBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fechaPrestamoPanel);
            this.Controls.Add(this.codUsuarioPanel);
            this.Controls.Add(this.codLibroPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.criterioUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.MaximizeBox = false;
            this.Name = "Frm_Nuevo_Prestamo_Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Nuevo_Prestamo_Administrador";
            this.Load += new System.EventHandler(this.Frm_Nuevo_Prestamo_Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.busquedaPanel.ResumeLayout(false);
            this.busquedaPanel.PerformLayout();
            this.busquedaLibroPanel.ResumeLayout(false);
            this.busquedaLibroPanel.PerformLayout();
            this.codLibroPanel.ResumeLayout(false);
            this.codLibroPanel.PerformLayout();
            this.codUsuarioPanel.ResumeLayout(false);
            this.codUsuarioPanel.PerformLayout();
            this.fechaPrestamoPanel.ResumeLayout(false);
            this.fechaPrestamoPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Button busquedaUsuariobutton;
        private System.Windows.Forms.Panel busquedaPanel;
        private System.Windows.Forms.TextBox busquedaUsuarioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label criterioUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button busquedaLibroButton;
        private System.Windows.Forms.Panel busquedaLibroPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel codLibroPanel;
        private System.Windows.Forms.TextBox codLibroTextBox;
        private System.Windows.Forms.Panel codUsuarioPanel;
        private System.Windows.Forms.TextBox codUsuarioTextBox;
        private System.Windows.Forms.Panel fechaPrestamoPanel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button crearBtn;
        private System.Windows.Forms.DateTimePicker fechaPrestamo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox libroBusquedaTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}