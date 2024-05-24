namespace ProyectoMetodosF
{
    partial class MetodoSecante
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
            this.txtX0 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtLogX0 = new System.Windows.Forms.TextBox();
            this.txtLogX1 = new System.Windows.Forms.TextBox();
            this.txtXTarget = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtX0
            // 
            this.txtX0.Location = new System.Drawing.Point(13, 82);
            this.txtX0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX0.Name = "txtX0";
            this.txtX0.Size = new System.Drawing.Size(132, 22);
            this.txtX0.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(184, 82);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(132, 22);
            this.txtX1.TabIndex = 1;
            // 
            // txtLogX0
            // 
            this.txtLogX0.Location = new System.Drawing.Point(345, 82);
            this.txtLogX0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogX0.Name = "txtLogX0";
            this.txtLogX0.Size = new System.Drawing.Size(132, 22);
            this.txtLogX0.TabIndex = 2;
            // 
            // txtLogX1
            // 
            this.txtLogX1.Location = new System.Drawing.Point(497, 82);
            this.txtLogX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogX1.Name = "txtLogX1";
            this.txtLogX1.Size = new System.Drawing.Size(132, 22);
            this.txtLogX1.TabIndex = 3;
            // 
            // txtXTarget
            // 
            this.txtXTarget.Location = new System.Drawing.Point(660, 82);
            this.txtXTarget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXTarget.Name = "txtXTarget";
            this.txtXTarget.Size = new System.Drawing.Size(132, 22);
            this.txtXTarget.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(399, 149);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 5;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(541, 149);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 324);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MetodoSecante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtXTarget);
            this.Controls.Add(this.txtLogX1);
            this.Controls.Add(this.txtLogX0);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtX0);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MetodoSecante";
            this.Text = "MetodoSecante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtX0;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtLogX0;
        private System.Windows.Forms.TextBox txtLogX1;
        private System.Windows.Forms.TextBox txtXTarget;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}