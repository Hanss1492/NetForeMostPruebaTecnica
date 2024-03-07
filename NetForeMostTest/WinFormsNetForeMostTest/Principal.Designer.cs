namespace WinFormsNetForeMostTest
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            registrToolStripMenuItem = new ToolStripMenuItem();
            registrarVentaToolStripMenuItem = new ToolStripMenuItem();
            informeTransacciónToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            dgInventario = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgInventario).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrToolStripMenuItem, registrarVentaToolStripMenuItem, informeTransacciónToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(937, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrToolStripMenuItem
            // 
            registrToolStripMenuItem.Name = "registrToolStripMenuItem";
            registrToolStripMenuItem.Size = new Size(116, 20);
            registrToolStripMenuItem.Text = "Registrar Compras";
            registrToolStripMenuItem.Click += registrToolStripMenuItem_Click;
            // 
            // registrarVentaToolStripMenuItem
            // 
            registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            registrarVentaToolStripMenuItem.Size = new Size(97, 20);
            registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            registrarVentaToolStripMenuItem.Click += registrarVentaToolStripMenuItem_Click;
            // 
            // informeTransacciónToolStripMenuItem
            // 
            informeTransacciónToolStripMenuItem.Name = "informeTransacciónToolStripMenuItem";
            informeTransacciónToolStripMenuItem.Size = new Size(126, 20);
            informeTransacciónToolStripMenuItem.Text = "Informe Transacción";
            informeTransacciónToolStripMenuItem.Click += informeTransacciónToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // dgInventario
            // 
            dgInventario.AllowUserToAddRows = false;
            dgInventario.AllowUserToDeleteRows = false;
            dgInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInventario.Location = new Point(25, 107);
            dgInventario.Name = "dgInventario";
            dgInventario.ReadOnly = true;
            dgInventario.RowTemplate.Height = 25;
            dgInventario.Size = new Size(862, 265);
            dgInventario.TabIndex = 1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 462);
            Controls.Add(dgInventario);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            Text = "NetForeMostTest";
            Load += Principal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrToolStripMenuItem;
        private ToolStripMenuItem registrarVentaToolStripMenuItem;
        private ToolStripMenuItem informeTransacciónToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private DataGridView dgInventario;
    }
}