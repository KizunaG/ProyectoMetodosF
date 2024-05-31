namespace ProyectoMetodosF
{
    partial class MetodoNewton
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
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtMaxiter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewResultadoNewtonRaphson = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoNewtonRaphson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncion
            // 
            this.txtFuncion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtFuncion.Location = new System.Drawing.Point(40, 62);
            this.txtFuncion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(132, 22);
            this.txtFuncion.TabIndex = 0;
            // 
            // txtx0
            // 
            this.txtx0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtx0.Location = new System.Drawing.Point(181, 62);
            this.txtx0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtx0.Name = "txtx0";
            this.txtx0.Size = new System.Drawing.Size(132, 22);
            this.txtx0.TabIndex = 1;
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTolerancia.Location = new System.Drawing.Point(323, 62);
            this.txtTolerancia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(132, 22);
            this.txtTolerancia.TabIndex = 2;
            // 
            // txtMaxiter
            // 
            this.txtMaxiter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtMaxiter.Location = new System.Drawing.Point(464, 62);
            this.txtMaxiter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaxiter.Name = "txtMaxiter";
            this.txtMaxiter.Size = new System.Drawing.Size(132, 22);
            this.txtMaxiter.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCalculate.Location = new System.Drawing.Point(159, 159);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPdf.Location = new System.Drawing.Point(296, 159);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(100, 28);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClose.Location = new System.Drawing.Point(17, 329);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridViewResultadoNewtonRaphson
            // 
            this.dataGridViewResultadoNewtonRaphson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultadoNewtonRaphson.Location = new System.Drawing.Point(464, 143);
            this.dataGridViewResultadoNewtonRaphson.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewResultadoNewtonRaphson.Name = "dataGridViewResultadoNewtonRaphson";
            this.dataGridViewResultadoNewtonRaphson.RowHeadersWidth = 51;
            this.dataGridViewResultadoNewtonRaphson.Size = new System.Drawing.Size(320, 185);
            this.dataGridViewResultadoNewtonRaphson.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLimpiar.Location = new System.Drawing.Point(215, 236);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ingrese la funcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ingrese X0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ingrese tolerancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Maximo de integraciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoMetodosF.Properties.Resources.ccccccccccccccccccccccc;
            this.pictureBox1.Location = new System.Drawing.Point(726, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 124);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // MetodoNewton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(849, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dataGridViewResultadoNewtonRaphson);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMaxiter);
            this.Controls.Add(this.txtTolerancia);
            this.Controls.Add(this.txtx0);
            this.Controls.Add(this.txtFuncion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MetodoNewton";
            this.Text = "MetodoNewton";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultadoNewtonRaphson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.TextBox txtx0;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtMaxiter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridViewResultadoNewtonRaphson;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}