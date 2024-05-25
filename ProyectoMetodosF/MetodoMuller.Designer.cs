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
            this.btnclose = new System.Windows.Forms.Button();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.txtx0 = new System.Windows.Forms.TextBox();
            this.txtx1 = new System.Windows.Forms.TextBox();
            this.txtx2 = new System.Windows.Forms.TextBox();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtMaxiter = new System.Windows.Forms.TextBox();
            this.dataGridViewResultadoMuller = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoMuller)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(45, 242);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(310, 175);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 7;
            this.bntCalcular.Text = "button1";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(100, 44);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(100, 20);
            this.txtFuncion.TabIndex = 8;
            // 
            // txtx0
            // 
            this.txtx0.Location = new System.Drawing.Point(219, 44);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(100, 20);
            this.txtx0.TabIndex = 9;
            // 
            // txtx1
            // 
            this.txtx1.Location = new System.Drawing.Point(358, 44);
            this.txtx1.Name = "txtx1";
            this.txtx1.Size = new System.Drawing.Size(100, 20);
            this.txtx1.TabIndex = 10;
            // 
            // txtx2
            // 
            this.txtx2.Location = new System.Drawing.Point(484, 44);
            this.txtx2.Name = "txtx2";
            this.txtx2.Size = new System.Drawing.Size(100, 20);
            this.txtx2.TabIndex = 11;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Location = new System.Drawing.Point(270, 98);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(100, 20);
            this.txtTolerancia.TabIndex = 12;
            // 
            // txtMaxiter
            // 
            this.txtMaxiter.Location = new System.Drawing.Point(388, 98);
            this.txtMaxiter.Name = "txtMaxiter";
            this.txtMaxiter.Size = new System.Drawing.Size(100, 20);
            this.txtMaxiter.TabIndex = 13;
            // 
            // dataGridViewResultadoMuller
            // 
            this.dataGridViewResultadoMuller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoMuller.Location = new System.Drawing.Point(510, 115);
            this.dataGridViewResultadoMuller.Name = "dataGridViewResultadoMuller";
            this.dataGridViewResultadoMuller.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewResultadoMuller.TabIndex = 14;
            // 
            // MetodoMuller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewResultadoMuller);
            this.Controls.Add(this.txtMaxiter);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.txtx2);
            this.Controls.Add(this.txtx1);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.btnclose);
            this.Name = "MetodoMuller";
            this.Text = "MetodoMuller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoMuller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtx0;
        private System.Windows.Forms.TextBox txtx1;
        private System.Windows.Forms.TextBox txtx2;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtMaxiter;
        private System.Windows.Forms.DataGridView dataGridViewResultadoMuller;
    }
}