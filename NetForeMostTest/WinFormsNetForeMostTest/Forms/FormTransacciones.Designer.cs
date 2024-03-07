namespace WinFormsNetForeMostTest.Forms
{
    partial class Transacciones
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
            dgInformeTransaccion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgInformeTransaccion).BeginInit();
            SuspendLayout();
            // 
            // dgInformeTransaccion
            // 
            dgInformeTransaccion.AllowUserToAddRows = false;
            dgInformeTransaccion.AllowUserToDeleteRows = false;
            dgInformeTransaccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgInformeTransaccion.Dock = DockStyle.Fill;
            dgInformeTransaccion.Location = new Point(0, 0);
            dgInformeTransaccion.Name = "dgInformeTransaccion";
            dgInformeTransaccion.ReadOnly = true;
            dgInformeTransaccion.RowTemplate.Height = 25;
            dgInformeTransaccion.Size = new Size(991, 455);
            dgInformeTransaccion.TabIndex = 2;
            // 
            // Transacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 455);
            Controls.Add(dgInformeTransaccion);
            Name = "Transacciones";
            Text = "Transacciones";
            Load += Transacciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgInformeTransaccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgInformeTransaccion;
    }
}