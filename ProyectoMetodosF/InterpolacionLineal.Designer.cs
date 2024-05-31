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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtx0 = new System.Windows.Forms.TextBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtMaxiter = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridViewResultadoSecante = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoSecante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFuncion.Location = new System.Drawing.Point(38, 140);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(132, 22);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtx0
            // 
            this.txtx0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtx0.Location = new System.Drawing.Point(179, 140);
            this.txtx0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(132, 22);
            this.txtx0.TabIndex = 1;
            // 
            // txtx1
            // 
            this.txtx1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtx1.Location = new System.Drawing.Point(334, 140);
            this.txtx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(132, 22);
            this.txtx1.TabIndex = 2;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTolerancia.Location = new System.Drawing.Point(490, 140);
            this.txtTolerancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(132, 22);
            this.txtTolerancia.TabIndex = 3;
            // 
            // txtMaxiter
            // 
            this.txtMaxiter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaxiter.Location = new System.Drawing.Point(631, 140);
            this.txtMaxiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxiter.Name = "txtMaxiter";
            this.txtMaxiter.Size = new System.Drawing.Size(132, 22);
            this.txtMaxiter.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCalcular.Location = new System.Drawing.Point(96, 220);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPdf.Location = new System.Drawing.Point(229, 220);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(100, 28);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnclose.Location = new System.Drawing.Point(38, 383);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 28);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridViewResultadoSecante
            // 
            this.dataGridViewResultadoSecante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoSecante.Location = new System.Drawing.Point(631, 186);
            this.dataGridViewResultadoSecante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResultadoSecante.Name = "dataGridViewResultadoSecante";
            this.dataGridViewResultadoSecante.RowHeadersWidth = 51;
            this.dataGridViewResultadoSecante.Size = new System.Drawing.Size(320, 185);
            this.dataGridViewResultadoSecante.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnClear.Location = new System.Drawing.Point(168, 274);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(252, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 32);
            this.label13.TabIndex = 30;
            this.label13.Text = "Ingrese los valores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Ingrese la funcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ingrese X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ingrese tolerancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Maximo de integraciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoMetodosF.Properties.Resources.ccccccccccccccccccccccc;
            this.pictureBox1.Location = new System.Drawing.Point(873, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 124);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // MetodoSecante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridViewResultadoSecante);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMaxiter);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.txtFuncion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MetodoSecante";
            this.Text = "MetodoSecante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoSecante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtx0;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtMaxiter;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridViewResultadoSecante;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}