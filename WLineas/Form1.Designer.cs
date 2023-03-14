namespace WLineas
{
    partial class frmLineas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXinicial = new System.Windows.Forms.Label();
            this.lblXfinal = new System.Windows.Forms.Label();
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.lblYinicial = new System.Windows.Forms.Label();
            this.lblYfinal = new System.Windows.Forms.Label();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.lblCantidadLineas = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblXinicial
            // 
            this.lblXinicial.AutoSize = true;
            this.lblXinicial.Location = new System.Drawing.Point(85, 70);
            this.lblXinicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXinicial.Name = "lblXinicial";
            this.lblXinicial.Size = new System.Drawing.Size(52, 16);
            this.lblXinicial.TabIndex = 0;
            this.lblXinicial.Text = "X inicial";
            // 
            // lblXfinal
            // 
            this.lblXfinal.AutoSize = true;
            this.lblXfinal.Location = new System.Drawing.Point(85, 128);
            this.lblXfinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXfinal.Name = "lblXfinal";
            this.lblXfinal.Size = new System.Drawing.Size(42, 16);
            this.lblXfinal.TabIndex = 1;
            this.lblXfinal.Text = "X final";
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(163, 70);
            this.txtXInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(91, 22);
            this.txtXInicial.TabIndex = 2;
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(163, 119);
            this.txtXFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(91, 22);
            this.txtXFinal.TabIndex = 3;
            // 
            // lblYinicial
            // 
            this.lblYinicial.AutoSize = true;
            this.lblYinicial.Location = new System.Drawing.Point(356, 74);
            this.lblYinicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYinicial.Name = "lblYinicial";
            this.lblYinicial.Size = new System.Drawing.Size(53, 16);
            this.lblYinicial.TabIndex = 4;
            this.lblYinicial.Text = "Y inicial";
            // 
            // lblYfinal
            // 
            this.lblYfinal.AutoSize = true;
            this.lblYfinal.Location = new System.Drawing.Point(356, 128);
            this.lblYfinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYfinal.Name = "lblYfinal";
            this.lblYfinal.Size = new System.Drawing.Size(43, 16);
            this.lblYfinal.TabIndex = 5;
            this.lblYfinal.Text = "Y final";
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(440, 70);
            this.txtYInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(91, 22);
            this.txtYInicial.TabIndex = 6;
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(440, 128);
            this.txtYFinal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(91, 22);
            this.txtYFinal.TabIndex = 7;
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.Location = new System.Drawing.Point(360, 230);
            this.btnDibujarLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(115, 39);
            this.btnDibujarLinea.TabIndex = 8;
            this.btnDibujarLinea.Text = "Dibujar Linea";
            this.btnDibujarLinea.UseVisualStyleBackColor = true;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // lblCantidadLineas
            // 
            this.lblCantidadLineas.AutoSize = true;
            this.lblCantidadLineas.Location = new System.Drawing.Point(108, 230);
            this.lblCantidadLineas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadLineas.Name = "lblCantidadLineas";
            this.lblCantidadLineas.Size = new System.Drawing.Size(123, 16);
            this.lblCantidadLineas.TabIndex = 9;
            this.lblCantidadLineas.Text = "Cantidad de Lineas";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(127, 277);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(91, 22);
            this.txtResultado.TabIndex = 10;
            // 
            // frmLineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblCantidadLineas);
            this.Controls.Add(this.btnDibujarLinea);
            this.Controls.Add(this.txtYFinal);
            this.Controls.Add(this.txtYInicial);
            this.Controls.Add(this.lblYfinal);
            this.Controls.Add(this.lblYinicial);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.txtXInicial);
            this.Controls.Add(this.lblXfinal);
            this.Controls.Add(this.lblXinicial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLineas";
            this.Text = "Lineas";
            this.Load += new System.EventHandler(this.frmLineas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXinicial;
        private System.Windows.Forms.Label lblXfinal;
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.Label lblYinicial;
        private System.Windows.Forms.Label lblYfinal;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.Button btnDibujarLinea;
        private System.Windows.Forms.Label lblCantidadLineas;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

