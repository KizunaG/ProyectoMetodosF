namespace ProyectoMetodosF
{
    partial class CalculoErrores
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
            this.longitudPuenteVerdaderaTextBox = new System.Windows.Forms.TextBox();
            this.longitudPuenteMedidaTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.mensajeLabel = new System.Windows.Forms.Label();
            this.errorPuenteLabel = new System.Windows.Forms.Label();
            this.errorRelativoPuenteLabel = new System.Windows.Forms.Label();
            this.longitudRemacheVerdaderaTextBox = new System.Windows.Forms.TextBox();
            this.longitudRemacheMedidaTextBox = new System.Windows.Forms.TextBox();
            this.errorRemacheLabel = new System.Windows.Forms.Label();
            this.errorRelativoRemacheLabel = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // longitudPuenteVerdaderaTextBox
            // 
            this.longitudPuenteVerdaderaTextBox.Location = new System.Drawing.Point(144, 64);
            this.longitudPuenteVerdaderaTextBox.Name = "longitudPuenteVerdaderaTextBox";
            this.longitudPuenteVerdaderaTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudPuenteVerdaderaTextBox.TabIndex = 0;
            // 
            // longitudPuenteMedidaTextBox
            // 
            this.longitudPuenteMedidaTextBox.Location = new System.Drawing.Point(275, 64);
            this.longitudPuenteMedidaTextBox.Name = "longitudPuenteMedidaTextBox";
            this.longitudPuenteMedidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudPuenteMedidaTextBox.TabIndex = 1;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(349, 122);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // mensajeLabel
            // 
            this.mensajeLabel.AutoSize = true;
            this.mensajeLabel.Location = new System.Drawing.Point(152, 178);
            this.mensajeLabel.Name = "mensajeLabel";
            this.mensajeLabel.Size = new System.Drawing.Size(35, 13);
            this.mensajeLabel.TabIndex = 3;
            this.mensajeLabel.Text = "label1";
            // 
            // errorPuenteLabel
            // 
            this.errorPuenteLabel.AutoSize = true;
            this.errorPuenteLabel.Location = new System.Drawing.Point(263, 178);
            this.errorPuenteLabel.Name = "errorPuenteLabel";
            this.errorPuenteLabel.Size = new System.Drawing.Size(35, 13);
            this.errorPuenteLabel.TabIndex = 4;
            this.errorPuenteLabel.Text = "label1";
            // 
            // errorRelativoPuenteLabel
            // 
            this.errorRelativoPuenteLabel.AutoSize = true;
            this.errorRelativoPuenteLabel.Location = new System.Drawing.Point(263, 216);
            this.errorRelativoPuenteLabel.Name = "errorRelativoPuenteLabel";
            this.errorRelativoPuenteLabel.Size = new System.Drawing.Size(35, 13);
            this.errorRelativoPuenteLabel.TabIndex = 5;
            this.errorRelativoPuenteLabel.Text = "label2";
            // 
            // longitudRemacheVerdaderaTextBox
            // 
            this.longitudRemacheVerdaderaTextBox.Location = new System.Drawing.Point(403, 64);
            this.longitudRemacheVerdaderaTextBox.Name = "longitudRemacheVerdaderaTextBox";
            this.longitudRemacheVerdaderaTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudRemacheVerdaderaTextBox.TabIndex = 6;
            // 
            // longitudRemacheMedidaTextBox
            // 
            this.longitudRemacheMedidaTextBox.Location = new System.Drawing.Point(537, 64);
            this.longitudRemacheMedidaTextBox.Name = "longitudRemacheMedidaTextBox";
            this.longitudRemacheMedidaTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudRemacheMedidaTextBox.TabIndex = 7;
            // 
            // errorRemacheLabel
            // 
            this.errorRemacheLabel.AutoSize = true;
            this.errorRemacheLabel.Location = new System.Drawing.Point(549, 178);
            this.errorRemacheLabel.Name = "errorRemacheLabel";
            this.errorRemacheLabel.Size = new System.Drawing.Size(35, 13);
            this.errorRemacheLabel.TabIndex = 8;
            this.errorRemacheLabel.Text = "label1";
            // 
            // errorRelativoRemacheLabel
            // 
            this.errorRelativoRemacheLabel.AutoSize = true;
            this.errorRelativoRemacheLabel.Location = new System.Drawing.Point(549, 216);
            this.errorRelativoRemacheLabel.Name = "errorRelativoRemacheLabel";
            this.errorRelativoRemacheLabel.Size = new System.Drawing.Size(35, 13);
            this.errorRelativoRemacheLabel.TabIndex = 9;
            this.errorRelativoRemacheLabel.Text = "label2";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(455, 122);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Limpiar";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(81, 272);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CalculoErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.errorRelativoRemacheLabel);
            this.Controls.Add(this.errorRemacheLabel);
            this.Controls.Add(this.longitudRemacheMedidaTextBox);
            this.Controls.Add(this.longitudRemacheVerdaderaTextBox);
            this.Controls.Add(this.errorRelativoPuenteLabel);
            this.Controls.Add(this.errorPuenteLabel);
            this.Controls.Add(this.mensajeLabel);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.longitudPuenteMedidaTextBox);
            this.Controls.Add(this.longitudPuenteVerdaderaTextBox);
            this.Name = "CalculoErrores";
            this.Text = "CalculoErrores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox longitudPuenteVerdaderaTextBox;
        private System.Windows.Forms.TextBox longitudPuenteMedidaTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Label mensajeLabel;
        private System.Windows.Forms.Label errorPuenteLabel;
        private System.Windows.Forms.Label errorRelativoPuenteLabel;
        private System.Windows.Forms.TextBox longitudRemacheVerdaderaTextBox;
        private System.Windows.Forms.TextBox longitudRemacheMedidaTextBox;
        private System.Windows.Forms.Label errorRemacheLabel;
        private System.Windows.Forms.Label errorRelativoRemacheLabel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnClose;
    }
}