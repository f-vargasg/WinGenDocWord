﻿
namespace WinGenDocWord
{
    partial class FrmPrincTestDocWord
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
            this.butDo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButDo
            // 
            this.butDo.Location = new System.Drawing.Point(306, 91);
            this.butDo.Name = "ButDo";
            this.butDo.Size = new System.Drawing.Size(204, 106);
            this.butDo.TabIndex = 0;
            this.butDo.Text = "button1";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.ButDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 489);
            this.Controls.Add(this.butDo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butDo;
    }
}
