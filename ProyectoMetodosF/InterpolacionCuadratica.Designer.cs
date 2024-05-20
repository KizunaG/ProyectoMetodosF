namespace ProyectoMetodosF
{
    partial class InterpolacionCuadratica
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
            this.x0TextBox.Location = new System.Drawing.Point(150, 45);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(100, 20);
            this.x0TextBox.TabIndex = 0;
            // 
            // x1TextBox
            // 
            this.x1TextBox.Location = new System.Drawing.Point(282, 45);
            this.x1TextBox.Name = "x1TextBox";
            this.x1TextBox.Size = new System.Drawing.Size(100, 20);
            this.x1TextBox.TabIndex = 1;
            // 
            // x2TextBox
            // 
            this.x2TextBox.Location = new System.Drawing.Point(415, 45);
            this.x2TextBox.Name = "x2TextBox";
            this.x2TextBox.Size = new System.Drawing.Size(100, 20);
            this.x2TextBox.TabIndex = 2;
            // 
            // xTargetTextBox
            // 
            this.xTargetTextBox.Location = new System.Drawing.Point(550, 45);
            this.xTargetTextBox.Name = "xTargetTextBox";
            this.xTargetTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTargetTextBox.TabIndex = 3;
            // 
            // f_x0TextBox
            // 
            this.f_x0TextBox.Location = new System.Drawing.Point(194, 112);
            this.f_x0TextBox.Name = "f_x0TextBox";
            this.f_x0TextBox.Size = new System.Drawing.Size(100, 20);
            this.f_x0TextBox.TabIndex = 4;
            // 
            // f_x1TextBox
            // 
            this.f_x1TextBox.Location = new System.Drawing.Point(317, 112);
            this.f_x1TextBox.Name = "f_x1TextBox";
            this.f_x1TextBox.Size = new System.Drawing.Size(100, 20);
            this.f_x1TextBox.TabIndex = 5;
            // 
            // f_x2TextBox
            // 
            this.f_x2TextBox.Location = new System.Drawing.Point(448, 112);
            this.f_x2TextBox.Name = "f_x2TextBox";
            this.f_x2TextBox.Size = new System.Drawing.Size(100, 20);
            this.f_x2TextBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(215, 162);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(35, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "label1";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(492, 162);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(35, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "label2";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(327, 225);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calcular";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(12, 265);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 10;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(426, 225);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // InterpolacionCuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "InterpolacionCuadratica";
            this.Text = "InterpolacionCuadratica";
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