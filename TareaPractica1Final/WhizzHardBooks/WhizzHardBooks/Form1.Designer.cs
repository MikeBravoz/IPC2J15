namespace WhizzHardBooks
{
    partial class Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Biblioteca));
            this.btninscribir = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.btnprestar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmasprestados = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btninscribir
            // 
            this.btninscribir.Location = new System.Drawing.Point(12, 12);
            this.btninscribir.Name = "btninscribir";
            this.btninscribir.Size = new System.Drawing.Size(154, 45);
            this.btninscribir.TabIndex = 0;
            this.btninscribir.Text = "INSCRIBIR LIBRO";
            this.btninscribir.UseVisualStyleBackColor = true;
            this.btninscribir.Click += new System.EventHandler(this.btninscribir_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(172, 12);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(154, 45);
            this.btnconsultar.TabIndex = 1;
            this.btnconsultar.Text = "CONSULTAR LIBRO";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // btnprestar
            // 
            this.btnprestar.Location = new System.Drawing.Point(332, 12);
            this.btnprestar.Name = "btnprestar";
            this.btnprestar.Size = new System.Drawing.Size(123, 45);
            this.btnprestar.TabIndex = 2;
            this.btnprestar.Text = "PRESTAR LIBRO";
            this.btnprestar.UseVisualStyleBackColor = true;
            this.btnprestar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(461, 12);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(154, 45);
            this.btnregistrar.TabIndex = 3;
            this.btnregistrar.Text = "REGISTRAR MIEMBRO";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnmasprestados
            // 
            this.btnmasprestados.Location = new System.Drawing.Point(621, 12);
            this.btnmasprestados.Name = "btnmasprestados";
            this.btnmasprestados.Size = new System.Drawing.Size(154, 45);
            this.btnmasprestados.TabIndex = 4;
            this.btnmasprestados.Text = "LIBROS (+) PRESTADOS";
            this.btnmasprestados.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(12, 328);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(148, 45);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(787, 385);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnmasprestados);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnprestar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btninscribir);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btninscribir;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button btnprestar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnmasprestados;
        private System.Windows.Forms.Button btnsalir;
    }
}

