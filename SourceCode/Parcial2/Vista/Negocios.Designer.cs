using System.ComponentModel;

namespace Parcial2
{
    partial class Negocios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregarNegocio = new System.Windows.Forms.Button();
            this.txtDescripcionAgregar = new System.Windows.Forms.TextBox();
            this.txtNombreAgregar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarNegocio = new System.Windows.Forms.Button();
            this.comboNombreEliminar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage1.Controls.Add(this.btnAgregarNegocio);
            this.tabPage1.Controls.Add(this.txtDescripcionAgregar);
            this.tabPage1.Controls.Add(this.txtNombreAgregar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(648, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar negocio";
            // 
            // btnAgregarNegocio
            // 
            this.btnAgregarNegocio.BackColor = System.Drawing.Color.Black;
            this.btnAgregarNegocio.Font = new System.Drawing.Font("Lucida Bright", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarNegocio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarNegocio.Location = new System.Drawing.Point(259, 421);
            this.btnAgregarNegocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarNegocio.Name = "btnAgregarNegocio";
            this.btnAgregarNegocio.Size = new System.Drawing.Size(159, 72);
            this.btnAgregarNegocio.TabIndex = 4;
            this.btnAgregarNegocio.Text = "Agregar negocio";
            this.btnAgregarNegocio.UseVisualStyleBackColor = false;
            this.btnAgregarNegocio.Click += new System.EventHandler(this.btnAgregarNegocio_Click);
            // 
            // txtDescripcionAgregar
            // 
            this.txtDescripcionAgregar.Location = new System.Drawing.Point(169, 319);
            this.txtDescripcionAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcionAgregar.Name = "txtDescripcionAgregar";
            this.txtDescripcionAgregar.Size = new System.Drawing.Size(331, 27);
            this.txtDescripcionAgregar.TabIndex = 3;
            // 
            // txtNombreAgregar
            // 
            this.txtNombreAgregar.Location = new System.Drawing.Point(169, 168);
            this.txtNombreAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreAgregar.Name = "txtNombreAgregar";
            this.txtNombreAgregar.Size = new System.Drawing.Size(331, 27);
            this.txtNombreAgregar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Negocio";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkViolet;
            this.tabPage2.Controls.Add(this.btnEliminarNegocio);
            this.tabPage2.Controls.Add(this.comboNombreEliminar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(648, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar negocio";
            // 
            // btnEliminarNegocio
            // 
            this.btnEliminarNegocio.BackColor = System.Drawing.Color.Black;
            this.btnEliminarNegocio.Font = new System.Drawing.Font("Lucida Bright", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarNegocio.ForeColor = System.Drawing.Color.White;
            this.btnEliminarNegocio.Location = new System.Drawing.Point(229, 308);
            this.btnEliminarNegocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarNegocio.Name = "btnEliminarNegocio";
            this.btnEliminarNegocio.Size = new System.Drawing.Size(145, 71);
            this.btnEliminarNegocio.TabIndex = 3;
            this.btnEliminarNegocio.Text = "Eliminar negocio";
            this.btnEliminarNegocio.UseVisualStyleBackColor = false;
            this.btnEliminarNegocio.Click += new System.EventHandler(this.btnEliminarNegocio_Click);
            // 
            // comboNombreEliminar
            // 
            this.comboNombreEliminar.FormattingEnabled = true;
            this.comboNombreEliminar.Location = new System.Drawing.Point(184, 180);
            this.comboNombreEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboNombreEliminar.Name = "comboNombreEliminar";
            this.comboNombreEliminar.Size = new System.Drawing.Size(244, 28);
            this.comboNombreEliminar.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(175, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre del negocio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Negocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(656, 556);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Negocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Negocios";
            this.Load += new System.EventHandler(this.Negocios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNombreEliminar;
        private System.Windows.Forms.TextBox txtNombreAgregar;
        private System.Windows.Forms.TextBox txtDescripcionAgregar;
        private System.Windows.Forms.Button btnEliminarNegocio;
        private System.Windows.Forms.Button btnAgregarNegocio;
    }
}