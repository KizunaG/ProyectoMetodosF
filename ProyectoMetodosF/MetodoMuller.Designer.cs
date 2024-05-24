namespace ProyectoMetodosF
{
    partial class MetodoMuller
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
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFunction
            // 
            this.txtFunction.Location = new System.Drawing.Point(135, 57);
            this.txtFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size(132, 22);
            this.txtFunction.TabIndex = 0;
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(293, 57);
            this.txtX0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(132, 22);
            this.txtX0.TabIndex = 1;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(463, 57);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(132, 22);
            this.txtX1.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(635, 57);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(132, 22);
            this.txtX2.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(327, 154);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(472, 172);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(327, 171);
            this.txtResult.TabIndex = 5;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(60, 298);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 28);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // MetodoMuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtX0);
            this.Controls.Add(this.txtFunction);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MetodoMuller";
            this.Text = "MetodoMuller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFunction;
        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnclose;
    }
}