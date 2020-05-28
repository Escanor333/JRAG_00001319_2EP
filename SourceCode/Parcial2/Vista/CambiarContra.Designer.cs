using System.ComponentModel;

namespace Parcial2.Properties
{
    partial class CambiarContra
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
                new System.ComponentModel.ComponentResourceManager(typeof(CambiarContra));
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.Nuevacontraseña = new System.Windows.Forms.Label();
            this.RepetirNuevaContraseña = new System.Windows.Forms.Label();
            this.txtRepetirNueva = new System.Windows.Forms.TextBox();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(259, 209);
            this.txtNueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(171, 27);
            this.txtNueva.TabIndex = 0;
            // 
            // Nuevacontraseña
            // 
            this.Nuevacontraseña.BackColor = System.Drawing.Color.Black;
            this.Nuevacontraseña.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Nuevacontraseña.ForeColor = System.Drawing.Color.White;
            this.Nuevacontraseña.Location = new System.Drawing.Point(259, 162);
            this.Nuevacontraseña.Name = "Nuevacontraseña";
            this.Nuevacontraseña.Size = new System.Drawing.Size(196, 28);
            this.Nuevacontraseña.TabIndex = 1;
            this.Nuevacontraseña.Text = "Nueva contraseña";
            // 
            // RepetirNuevaContraseña
            // 
            this.RepetirNuevaContraseña.BackColor = System.Drawing.Color.Black;
            this.RepetirNuevaContraseña.Font = new System.Drawing.Font("Lucida Bright", 12F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.RepetirNuevaContraseña.ForeColor = System.Drawing.Color.White;
            this.RepetirNuevaContraseña.Location = new System.Drawing.Point(239, 251);
            this.RepetirNuevaContraseña.Name = "RepetirNuevaContraseña";
            this.RepetirNuevaContraseña.Size = new System.Drawing.Size(202, 28);
            this.RepetirNuevaContraseña.TabIndex = 3;
            this.RepetirNuevaContraseña.Text = "Repetir contraseña";
            this.RepetirNuevaContraseña.Click += new System.EventHandler(this.RepetirNuevaContraseña_Click);
            // 
            // txtRepetirNueva
            // 
            this.txtRepetirNueva.Location = new System.Drawing.Point(259, 296);
            this.txtRepetirNueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepetirNueva.Name = "txtRepetirNueva";
            this.txtRepetirNueva.PasswordChar = '*';
            this.txtRepetirNueva.Size = new System.Drawing.Size(171, 27);
            this.txtRepetirNueva.TabIndex = 2;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.Location = new System.Drawing.Point(259, 346);
            this.btnCambiarContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(168, 32);
            this.btnCambiarContraseña.TabIndex = 4;
            this.btnCambiarContraseña.Text = "Cambiar contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(239, 111);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(229, 28);
            this.cmbUsuario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(239, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione su usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage =
                ((System.Drawing.Image) (resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 215);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.RepetirNuevaContraseña);
            this.Controls.Add(this.txtRepetirNueva);
            this.Controls.Add(this.Nuevacontraseña);
            this.Controls.Add(this.txtNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CambiarContra";
            this.Text = "CambiarContra";
            this.Load += new System.EventHandler(this.CambiarContra_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label RepetirNuevaContraseña;
        private System.Windows.Forms.Label Nuevacontraseña;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txtRepetirNueva;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}