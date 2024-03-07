namespace WinFormsNetForeMostTest.Forms
{
    partial class RegVentas
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
            cbproducto = new ComboBox();
            txtcantidad = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbproducto
            // 
            cbproducto.FormattingEnabled = true;
            cbproducto.Location = new Point(215, 34);
            cbproducto.Name = "cbproducto";
            cbproducto.Size = new Size(264, 23);
            cbproducto.TabIndex = 14;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(220, 70);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(110, 23);
            txtcantidad.TabIndex = 12;
            txtcantidad.KeyPress += txtcantidad_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(320, 157);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(159, 29);
            button1.TabIndex = 11;
            button1.Text = "Registrar Venta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 72);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 9;
            label2.Text = "Cantidad Vendida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 37);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 8;
            label1.Text = "Producto";
            // 
            // RegVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 232);
            Controls.Add(cbproducto);
            Controls.Add(txtcantidad);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegVentas";
            Text = "Ventas";
            FormClosed += RegVentas_FormClosed;
            Load += RegVentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbproducto;
        private TextBox txtcantidad;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}