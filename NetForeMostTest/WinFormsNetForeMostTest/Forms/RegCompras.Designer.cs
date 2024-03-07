namespace WinFormsNetForeMostTest
{
    partial class RegCompras
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtcantidad = new TextBox();
            txtprecio = new TextBox();
            cbproducto = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 82);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad Comprada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 116);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio Unitario";
            // 
            // button1
            // 
            button1.Location = new Point(318, 167);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(159, 26);
            button1.TabIndex = 3;
            button1.Text = "Registrar Compra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(218, 80);
            txtcantidad.Margin = new Padding(3, 2, 3, 2);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(110, 23);
            txtcantidad.TabIndex = 5;
            txtcantidad.KeyPress += txtcantidad_KeyPress;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(218, 116);
            txtprecio.Margin = new Padding(3, 2, 3, 2);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(110, 23);
            txtprecio.TabIndex = 6;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // cbproducto
            // 
            cbproducto.FormattingEnabled = true;
            cbproducto.Location = new Point(213, 44);
            cbproducto.Name = "cbproducto";
            cbproducto.Size = new Size(264, 23);
            cbproducto.TabIndex = 7;
            // 
            // RegCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 262);
            Controls.Add(cbproducto);
            Controls.Add(txtprecio);
            Controls.Add(txtcantidad);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegCompras";
            Text = "RegCompras";
            FormClosed += RegCompras_FormClosed;
            Load += RegCompras_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox txtcantidad;
        private TextBox txtprecio;
        private ComboBox cbproducto;
    }
}