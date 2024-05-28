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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoSecante)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(36, 33);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtx0
            // 
            this.txtx0.Location = new System.Drawing.Point(142, 33);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(100, 20);
            this.txtx0.TabIndex = 1;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(258, 33);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 2;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(375, 33);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 20);
            this.txtTolerancia.TabIndex = 3;
            // 
            // txtMaxiter
            // 
            this.txtMaxiter.Location = new System.Drawing.Point(481, 33);
            this.txtMaxiter.Name = "txtMaxiter";
            this.txtMaxiter.Size = new System.Drawing.Size(100, 20);
            this.txtMaxiter.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(131, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(231, 105);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 6;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(25, 243);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridViewResultadoSecante
            // 
            this.dataGridViewResultadoSecante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoSecante.Location = new System.Drawing.Point(341, 96);
            this.dataGridViewResultadoSecante.Name = "dataGridViewResultadoSecante";
            this.dataGridViewResultadoSecante.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultadoSecante.TabIndex = 8;
            // 
            // MetodoSecante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 412);
            this.Controls.Add(this.dataGridViewResultadoSecante);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMaxiter);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.txtFuncion);
            this.Name = "MetodoSecante";
            this.Text = "MetodoSecante";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoSecante)).EndInit();
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
    }
}