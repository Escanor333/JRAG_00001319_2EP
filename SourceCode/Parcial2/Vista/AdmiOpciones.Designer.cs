using System.ComponentModel;

namespace Parcial2
{
    partial class AdmiOpciones
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
                new System.ComponentModel.ComponentResourceManager(typeof(AdmiOpciones));
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnNegocios = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnUsuarios.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(49, 71);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(174, 84);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnNegocios
            // 
            this.btnNegocios.BackColor = System.Drawing.Color.Black;
            this.btnNegocios.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNegocios.ForeColor = System.Drawing.Color.White;
            this.btnNegocios.Location = new System.Drawing.Point(451, 71);
            this.btnNegocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNegocios.Name = "btnNegocios";
            this.btnNegocios.Size = new System.Drawing.Size(174, 84);
            this.btnNegocios.TabIndex = 1;
            this.btnNegocios.Text = "Negocios";
            this.btnNegocios.UseVisualStyleBackColor = false;
            this.btnNegocios.Click += new System.EventHandler(this.btnNegocios_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Black;
            this.btnProductos.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(49, 509);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(174, 82);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.Black;
            this.btnOrdenes.Font = new System.Drawing.Font("Lucida Bright", 13.8F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnOrdenes.Location = new System.Drawing.Point(451, 509);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(174, 82);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Ver ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(106, 186);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 291);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AdmiOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(651, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOrdenes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnNegocios);
            this.Controls.Add(this.btnUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdmiOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmiOpciones";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnNegocios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}