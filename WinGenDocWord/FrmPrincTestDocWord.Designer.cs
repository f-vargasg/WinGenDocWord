
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
            this.genFromTemplateBut = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butDo
            // 
            this.butDo.Location = new System.Drawing.Point(13, 13);
            this.butDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butDo.Name = "butDo";
            this.butDo.Size = new System.Drawing.Size(117, 63);
            this.butDo.TabIndex = 0;
            this.butDo.Text = "button1";
            this.butDo.UseVisualStyleBackColor = true;
            this.butDo.Click += new System.EventHandler(this.ButDo_Click);
            // 
            // genFromTemplateBut
            // 
            this.genFromTemplateBut.Location = new System.Drawing.Point(157, 13);
            this.genFromTemplateBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.genFromTemplateBut.Name = "genFromTemplateBut";
            this.genFromTemplateBut.Size = new System.Drawing.Size(109, 63);
            this.genFromTemplateBut.TabIndex = 1;
            this.genFromTemplateBut.Text = "Gen. Doc From Template";
            this.genFromTemplateBut.UseVisualStyleBackColor = true;
            this.genFromTemplateBut.Click += new System.EventHandler(this.genFromTemplateBut_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 83);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(1155, 522);
            this.txtOutput.TabIndex = 2;
            // 
            // FrmPrincTestDocWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 602);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.genFromTemplateBut);
            this.Controls.Add(this.butDo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPrincTestDocWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDo;
        private System.Windows.Forms.Button genFromTemplateBut;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

