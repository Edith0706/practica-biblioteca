namespace Biblioteca
{
    partial class FormPrestamo
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
            this.labelPrestamoId = new System.Windows.Forms.Label();
            this.labelUsuarioId = new System.Windows.Forms.Label();
            this.labelLibroId = new System.Windows.Forms.Label();
            this.labelFechaPrestamo = new System.Windows.Forms.Label();
            this.labelFechaDevolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(307, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 126);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelPrestamoId
            // 
            this.labelPrestamoId.AutoSize = true;
            this.labelPrestamoId.Location = new System.Drawing.Point(54, 31);
            this.labelPrestamoId.Name = "labelPrestamoId";
            this.labelPrestamoId.Size = new System.Drawing.Size(35, 13);
            this.labelPrestamoId.TabIndex = 6;
            this.labelPrestamoId.Text = "label1";
            // 
            // labelUsuarioId
            // 
            this.labelUsuarioId.AutoSize = true;
            this.labelUsuarioId.Location = new System.Drawing.Point(54, 57);
            this.labelUsuarioId.Name = "labelUsuarioId";
            this.labelUsuarioId.Size = new System.Drawing.Size(35, 13);
            this.labelUsuarioId.TabIndex = 7;
            this.labelUsuarioId.Text = "label2";
            // 
            // labelLibroId
            // 
            this.labelLibroId.AutoSize = true;
            this.labelLibroId.Location = new System.Drawing.Point(54, 80);
            this.labelLibroId.Name = "labelLibroId";
            this.labelLibroId.Size = new System.Drawing.Size(35, 13);
            this.labelLibroId.TabIndex = 8;
            this.labelLibroId.Text = "label3";
            // 
            // labelFechaPrestamo
            // 
            this.labelFechaPrestamo.AutoSize = true;
            this.labelFechaPrestamo.Location = new System.Drawing.Point(54, 113);
            this.labelFechaPrestamo.Name = "labelFechaPrestamo";
            this.labelFechaPrestamo.Size = new System.Drawing.Size(35, 13);
            this.labelFechaPrestamo.TabIndex = 9;
            this.labelFechaPrestamo.Text = "label4";
            // 
            // labelFechaDevolucion
            // 
            this.labelFechaDevolucion.AutoSize = true;
            this.labelFechaDevolucion.Location = new System.Drawing.Point(54, 147);
            this.labelFechaDevolucion.Name = "labelFechaDevolucion";
            this.labelFechaDevolucion.Size = new System.Drawing.Size(35, 13);
            this.labelFechaDevolucion.TabIndex = 10;
            this.labelFechaDevolucion.Text = "label5";
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 307);
            this.Controls.Add(this.labelFechaDevolucion);
            this.Controls.Add(this.labelFechaPrestamo);
            this.Controls.Add(this.labelLibroId);
            this.Controls.Add(this.labelUsuarioId);
            this.Controls.Add(this.labelPrestamoId);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrestamoId;
        private System.Windows.Forms.Label labelUsuarioId;
        private System.Windows.Forms.Label labelLibroId;
        private System.Windows.Forms.Label labelFechaPrestamo;
        private System.Windows.Forms.Label labelFechaDevolucion;
    }
}