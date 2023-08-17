
namespace Conver
{
    partial class Form1
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
            this.lblConversor1 = new System.Windows.Forms.Label();
            this.cboAconversores = new System.Windows.Forms.ComboBox();
            this.btnCantidadConversores = new System.Windows.Forms.Button();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.lblConversores2 = new System.Windows.Forms.Label();
            this.cmbCantidad2 = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblRespuestaConversores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConversor1
            // 
            this.lblConversor1.AutoSize = true;
            this.lblConversor1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor1.Location = new System.Drawing.Point(32, 44);
            this.lblConversor1.Name = "lblConversor1";
            this.lblConversor1.Size = new System.Drawing.Size(38, 19);
            this.lblConversor1.TabIndex = 0;
            this.lblConversor1.Text = "DE:";
            // 
            // cboAconversores
            // 
            this.cboAconversores.FormattingEnabled = true;
            this.cboAconversores.Location = new System.Drawing.Point(76, 42);
            this.cboAconversores.Name = "cboAconversores";
            this.cboAconversores.Size = new System.Drawing.Size(221, 21);
            this.cboAconversores.TabIndex = 1;
            this.cboAconversores.SelectedIndexChanged += new System.EventHandler(this.cmbCantidad1_SelectedIndexChanged);
            // 
            // btnCantidadConversores
            // 
            this.btnCantidadConversores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadConversores.Location = new System.Drawing.Point(213, 230);
            this.btnCantidadConversores.Name = "btnCantidadConversores";
            this.btnCantidadConversores.Size = new System.Drawing.Size(112, 35);
            this.btnCantidadConversores.TabIndex = 2;
            this.btnCantidadConversores.Text = "Convertir";
            this.btnCantidadConversores.UseVisualStyleBackColor = true;
            this.btnCantidadConversores.Click += new System.EventHandler(this.btnCantidadConversores_Click);
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Location = new System.Drawing.Point(122, 166);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(175, 20);
            this.txtCantidadConversores.TabIndex = 3;
            // 
            // lblConversores2
            // 
            this.lblConversores2.AutoSize = true;
            this.lblConversores2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversores2.Location = new System.Drawing.Point(32, 106);
            this.lblConversores2.Name = "lblConversores2";
            this.lblConversores2.Size = new System.Drawing.Size(38, 19);
            this.lblConversores2.TabIndex = 4;
            this.lblConversores2.Text = "DE:";
            // 
            // cmbCantidad2
            // 
            this.cmbCantidad2.FormattingEnabled = true;
            this.cmbCantidad2.Location = new System.Drawing.Point(76, 104);
            this.cmbCantidad2.Name = "cmbCantidad2";
            this.cmbCantidad2.Size = new System.Drawing.Size(221, 21);
            this.cmbCantidad2.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(32, 167);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(84, 19);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblRespuestaConversores
            // 
            this.lblRespuestaConversores.AutoSize = true;
            this.lblRespuestaConversores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversores.Location = new System.Drawing.Point(32, 238);
            this.lblRespuestaConversores.Name = "lblRespuestaConversores";
            this.lblRespuestaConversores.Size = new System.Drawing.Size(107, 19);
            this.lblRespuestaConversores.TabIndex = 7;
            this.lblRespuestaConversores.Text = "Respuesta:?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 300);
            this.Controls.Add(this.lblRespuestaConversores);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.cmbCantidad2);
            this.Controls.Add(this.lblConversores2);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.btnCantidadConversores);
            this.Controls.Add(this.cboAconversores);
            this.Controls.Add(this.lblConversor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversor1;
        private System.Windows.Forms.ComboBox cboAconversores;
        private System.Windows.Forms.Button btnCantidadConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.Label lblConversores2;
        private System.Windows.Forms.ComboBox cmbCantidad2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblRespuestaConversores;
    }
}

