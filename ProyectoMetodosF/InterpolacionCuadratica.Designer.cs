namespace ProyectoMetodosF
{
    partial class MetodoGauss
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
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.x1TextBox = new System.Windows.Forms.TextBox();
            this.x2TextBox = new System.Windows.Forms.TextBox();
            this.xTargetTextBox = new System.Windows.Forms.TextBox();
            this.f_x0TextBox = new System.Windows.Forms.TextBox();
            this.f_x1TextBox = new System.Windows.Forms.TextBox();
            this.f_x2TextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(53, 55);
            this.x0TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(132, 22);
            this.x0TextBox.TabIndex = 0;
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(290, 55);
            this.x1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(132, 22);
            this.x1TextBox.TabIndex = 1;
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(475, 55);
            this.x2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(132, 22);
            this.x2TextBox.TabIndex = 2;
            // 
            // xTargetTextBox
            // 
            this.xTargetTextBox.Location = new System.Drawing.Point(669, 55);
            this.xTargetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.xTargetTextBox.Name = "xTargetTextBox";
            this.xTargetTextBox.Size = new System.Drawing.Size(132, 22);
            this.xTargetTextBox.TabIndex = 3;
            // 
            // f_x0TextBox
            // 
            this.f_x0TextBox.Location = new System.Drawing.Point(199, 138);
            this.f_x0TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_x0TextBox.Name = "f_x0TextBox";
            this.f_x0TextBox.Size = new System.Drawing.Size(132, 22);
            this.f_x0TextBox.TabIndex = 4;
            // 
            // f_x1TextBox
            // 
            this.f_x1TextBox.Location = new System.Drawing.Point(384, 138);
            this.f_x1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_x1TextBox.Name = "f_x1TextBox";
            this.f_x1TextBox.Size = new System.Drawing.Size(132, 22);
            this.f_x1TextBox.TabIndex = 5;
            // 
            // f_x2TextBox
            // 
            this.f_x2TextBox.Location = new System.Drawing.Point(583, 138);
            this.f_x2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.f_x2TextBox.Name = "f_x2TextBox";
            this.f_x2TextBox.Size = new System.Drawing.Size(132, 22);
            this.f_x2TextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(287, 199);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(44, 16);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "label1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(656, 199);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(44, 16);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "label2";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(436, 277);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 28);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calcular";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(16, 326);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 28);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(568, 277);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // MetodoGauss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.f_x2TextBox);
            this.Controls.Add(this.f_x1TextBox);
            this.Controls.Add(this.f_x0TextBox);
            this.Controls.Add(this.xTargetTextBox);
            this.Controls.Add(this.x2TextBox);
            this.Controls.Add(this.x1TextBox);
            this.Controls.Add(this.x0TextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MetodoGauss";
            this.Text = "MetodoGauss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.TextBox x1TextBox;
        private System.Windows.Forms.TextBox x2TextBox;
        private System.Windows.Forms.TextBox xTargetTextBox;
        private System.Windows.Forms.TextBox f_x0TextBox;
        private System.Windows.Forms.TextBox f_x1TextBox;
        private System.Windows.Forms.TextBox f_x2TextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnlimpiar;
    }
}