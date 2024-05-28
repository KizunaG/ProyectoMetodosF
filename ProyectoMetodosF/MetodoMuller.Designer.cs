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
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtMaxiter = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dataGridViewResultadoMuller = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoMuller)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(12, 43);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtx0
            // 
            this.txtx0.Location = new System.Drawing.Point(135, 43);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(100, 20);
            this.txtx0.TabIndex = 1;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(251, 43);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 2;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(362, 43);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 20);
            this.txtx2.TabIndex = 3;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(135, 102);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 20);
            this.txtTolerancia.TabIndex = 4;
            // 
            // txtMaxiter
            // 
            this.txtMaxiter.Location = new System.Drawing.Point(251, 102);
            this.txtMaxiter.Name = "txtMaxiter";
            this.txtMaxiter.Size = new System.Drawing.Size(100, 20);
            this.txtMaxiter.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(135, 159);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataGridViewResultadoMuller
            // 
            this.dataGridViewResultadoMuller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoMuller.Location = new System.Drawing.Point(385, 102);
            this.dataGridViewResultadoMuller.Name = "dataGridViewResultadoMuller";
            this.dataGridViewResultadoMuller.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultadoMuller.TabIndex = 7;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(241, 159);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 8;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(37, 253);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MetodoMuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 412);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dataGridViewResultadoMuller);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMaxiter);
            this.Controls.Add(this.txtTolerancia);
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
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtMaxiter;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dataGridViewResultadoMuller;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}