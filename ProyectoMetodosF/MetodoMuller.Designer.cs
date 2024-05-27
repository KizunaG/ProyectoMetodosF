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
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtx0 = new System.Windows.Forms.TextBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridViewResultadoMuller = new System.Windows.Forms.DataGridView();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtMaxiter = new System.Windows.Forms.TextBox();
            this.btnPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoMuller)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(101, 46);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtx0
            // 
            this.txtx0.Location = new System.Drawing.Point(220, 46);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(100, 20);
            this.txtx0.TabIndex = 1;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(347, 46);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 2;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(476, 46);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 20);
            this.txtx2.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(151, 168);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(45, 242);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // dataGridViewResultadoMuller
            // 
            this.dataGridViewResultadoMuller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoMuller.Location = new System.Drawing.Point(359, 125);
            this.dataGridViewResultadoMuller.Name = "dataGridViewResultadoMuller";
            this.dataGridViewResultadoMuller.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultadoMuller.TabIndex = 7;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(101, 90);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 20);
            this.txtTolerancia.TabIndex = 8;
            // 
            // txtMaxiter
            // 
            this.txtMaxiter.Location = new System.Drawing.Point(220, 90);
            this.txtMaxiter.Name = "txtMaxiter";
            this.txtMaxiter.Size = new System.Drawing.Size(100, 20);
            this.txtMaxiter.TabIndex = 9;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(220, 242);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 10;
            this.btnPdf.Text = "Pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // MetodoMuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 412);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.txtMaxiter);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.dataGridViewResultadoMuller);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.txtFuncion);
            this.Name = "MetodoMuller";
            this.Text = "MetodoMuller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoMuller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtx0;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridViewResultadoMuller;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtMaxiter;
        private System.Windows.Forms.Button btnPdf;

    }
}