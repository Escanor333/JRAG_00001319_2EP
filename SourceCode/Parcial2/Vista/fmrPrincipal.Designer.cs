using System.ComponentModel;

namespace Parcial2
{
    partial class fmrPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(fmrPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AgregarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.checkAdmi = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EliminarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUsuarioEliminar = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 621);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.AgregarUsuario);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.txtNombreCompleto);
            this.tabPage1.Controls.Add(this.checkAdmi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(762, 588);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar usuario";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(449, 135);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.BackColor = System.Drawing.Color.Black;
            this.AgregarUsuario.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.AgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.AgregarUsuario.Location = new System.Drawing.Point(58, 399);
            this.AgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Size = new System.Drawing.Size(190, 81);
            this.AgregarUsuario.TabIndex = 5;
            this.AgregarUsuario.Text = "Agregar usuario";
            this.AgregarUsuario.UseVisualStyleBackColor = false;
            this.AgregarUsuario.Click += new System.EventHandler(this.AgregarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(369, 249);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(323, 27);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(369, 175);
            this.txtNombreCompleto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(323, 27);
            this.txtNombreCompleto.TabIndex = 3;
            // 
            // checkAdmi
            // 
            this.checkAdmi.BackColor = System.Drawing.Color.Black;
            this.checkAdmi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkAdmi.ForeColor = System.Drawing.Color.White;
            this.checkAdmi.Location = new System.Drawing.Point(369, 399);
            this.checkAdmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkAdmi.Name = "checkAdmi";
            this.checkAdmi.Size = new System.Drawing.Size(323, 81);
            this.checkAdmi.TabIndex = 2;
            this.checkAdmi.Text = "Administrador";
            this.checkAdmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAdmi.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(73, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(73, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre completo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.EliminarUsuario);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbUsuarioEliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(762, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 138);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.BackColor = System.Drawing.Color.Black;
            this.EliminarUsuario.Font = new System.Drawing.Font("Lucida Bright", 13.8F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.EliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.EliminarUsuario.Location = new System.Drawing.Point(232, 388);
            this.EliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Size = new System.Drawing.Size(258, 88);
            this.EliminarUsuario.TabIndex = 2;
            this.EliminarUsuario.Text = "Eliminar usuario";
            this.EliminarUsuario.UseVisualStyleBackColor = false;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Seleccione Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbUsuarioEliminar
            // 
            this.cmbUsuarioEliminar.FormattingEnabled = true;
            this.cmbUsuarioEliminar.Location = new System.Drawing.Point(456, 221);
            this.cmbUsuarioEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsuarioEliminar.Name = "cmbUsuarioEliminar";
            this.cmbUsuarioEliminar.Size = new System.Drawing.Size(186, 28);
            this.cmbUsuarioEliminar.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(762, 592);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ver usuarios";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 569);
            this.dataGridView1.TabIndex = 0;
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(770, 621);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmrPrincipal";
            this.Load += new System.EventHandler(this.fmrPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AgregarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.CheckBox checkAdmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuarioEliminar;
        private System.Windows.Forms.Button EliminarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}