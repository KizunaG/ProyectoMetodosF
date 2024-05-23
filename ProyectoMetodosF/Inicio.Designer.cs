namespace ProyectoMetodosF
{
    partial class Inicio
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMetodos = new System.Windows.Forms.Button();
            this.panelMetodosSubmenu = new System.Windows.Forms.Panel();
            this.btnNewton = new System.Windows.Forms.Button();
            this.btnSecante = new System.Windows.Forms.Button();
            this.btnMuller = new System.Windows.Forms.Button();
            this.btnGauss = new System.Windows.Forms.Button();
            this.btnIntegrantes = new System.Windows.Forms.Button();
            this.btnAcercade = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelMetodosSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.btnCerrarSesion);
            this.panelSideMenu.Controls.Add(this.btnAcercade);
            this.panelSideMenu.Controls.Add(this.btnIntegrantes);
            this.panelSideMenu.Controls.Add(this.panelMetodosSubmenu);
            this.panelSideMenu.Controls.Add(this.btnMetodos);
            this.panelSideMenu.Controls.Add(this.button1);
            this.panelSideMenu.Controls.Add(this.panel2);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 554);
            this.panelSideMenu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inicio ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMetodos
            // 
            this.btnMetodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMetodos.Location = new System.Drawing.Point(0, 145);
            this.btnMetodos.Name = "btnMetodos";
            this.btnMetodos.Size = new System.Drawing.Size(200, 45);
            this.btnMetodos.TabIndex = 2;
            this.btnMetodos.Text = "Métodos";
            this.btnMetodos.UseVisualStyleBackColor = true;
            this.btnMetodos.Click += new System.EventHandler(this.btnMetodos_Click);
            // 
            // panelMetodosSubmenu
            // 
            this.panelMetodosSubmenu.Controls.Add(this.btnGauss);
            this.panelMetodosSubmenu.Controls.Add(this.btnMuller);
            this.panelMetodosSubmenu.Controls.Add(this.btnSecante);
            this.panelMetodosSubmenu.Controls.Add(this.btnNewton);
            this.panelMetodosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMetodosSubmenu.Location = new System.Drawing.Point(0, 190);
            this.panelMetodosSubmenu.Name = "panelMetodosSubmenu";
            this.panelMetodosSubmenu.Size = new System.Drawing.Size(200, 204);
            this.panelMetodosSubmenu.TabIndex = 3;
            // 
            // btnNewton
            // 
            this.btnNewton.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewton.Location = new System.Drawing.Point(0, 0);
            this.btnNewton.Name = "btnNewton";
            this.btnNewton.Size = new System.Drawing.Size(200, 45);
            this.btnNewton.TabIndex = 0;
            this.btnNewton.Text = "Método de Newton Raphson";
            this.btnNewton.UseVisualStyleBackColor = true;
            this.btnNewton.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSecante
            // 
            this.btnSecante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecante.Location = new System.Drawing.Point(0, 45);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(200, 45);
            this.btnSecante.TabIndex = 1;
            this.btnSecante.Text = "Método de la Secante";
            this.btnSecante.UseVisualStyleBackColor = true;
            this.btnSecante.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnMuller
            // 
            this.btnMuller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuller.Location = new System.Drawing.Point(0, 90);
            this.btnMuller.Name = "btnMuller";
            this.btnMuller.Size = new System.Drawing.Size(200, 45);
            this.btnMuller.TabIndex = 2;
            this.btnMuller.Text = "Método de Müller";
            this.btnMuller.UseVisualStyleBackColor = true;
            this.btnMuller.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnGauss
            // 
            this.btnGauss.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGauss.Location = new System.Drawing.Point(0, 135);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(200, 45);
            this.btnGauss.TabIndex = 3;
            this.btnGauss.Text = "Método de Gauss";
            this.btnGauss.UseVisualStyleBackColor = true;
            this.btnGauss.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnIntegrantes
            // 
            this.btnIntegrantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIntegrantes.Location = new System.Drawing.Point(0, 394);
            this.btnIntegrantes.Name = "btnIntegrantes";
            this.btnIntegrantes.Size = new System.Drawing.Size(200, 45);
            this.btnIntegrantes.TabIndex = 4;
            this.btnIntegrantes.Text = "Integrantes";
            this.btnIntegrantes.UseVisualStyleBackColor = true;
            this.btnIntegrantes.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnAcercade
            // 
            this.btnAcercade.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercade.Location = new System.Drawing.Point(0, 439);
            this.btnAcercade.Name = "btnAcercade";
            this.btnAcercade.Size = new System.Drawing.Size(200, 45);
            this.btnAcercade.TabIndex = 5;
            this.btnAcercade.Text = "Acerca de";
            this.btnAcercade.UseVisualStyleBackColor = true;
            this.btnAcercade.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 484);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 45);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button10_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(867, 554);
            this.panelChildForm.TabIndex = 4;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.panelSideMenu.ResumeLayout(false);
            this.panelMetodosSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnAcercade;
        private System.Windows.Forms.Button btnIntegrantes;
        private System.Windows.Forms.Panel panelMetodosSubmenu;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.Button btnMuller;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Button btnNewton;
        private System.Windows.Forms.Button btnMetodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
    }
}