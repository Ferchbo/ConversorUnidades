namespace Conversor_de_unidades
{
    partial class Form1
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
            label1 = new Label();
            txtCantidad = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            cmbTipo = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lstHacia = new ListBox();
            lstDesde = new ListBox();
            panel2 = new Panel();
            txtConvertida = new TextBox();
            label5 = new Label();
            btnConvertir = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(99, 15);
            label1.Name = "label1";
            label1.Size = new Size(134, 38);
            label1.TabIndex = 0;
            label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(3, 56);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(346, 27);
            txtCantidad.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtCantidad);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 114);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(58, 132);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(306, 28);
            cmbTipo.TabIndex = 4;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 338);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 5;
            label3.Text = "Desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(304, 338);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 6;
            label4.Text = "Hacia";
            // 
            // lstHacia
            // 
            lstHacia.FormattingEnabled = true;
            lstHacia.ItemHeight = 20;
            lstHacia.Location = new Point(187, 166);
            lstHacia.Name = "lstHacia";
            lstHacia.Size = new Size(177, 164);
            lstHacia.TabIndex = 7;
            // 
            // lstDesde
            // 
            lstDesde.FormattingEnabled = true;
            lstDesde.ItemHeight = 20;
            lstDesde.Location = new Point(12, 166);
            lstDesde.Name = "lstDesde";
            lstDesde.Size = new Size(169, 164);
            lstDesde.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtConvertida);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(10, 375);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 119);
            panel2.TabIndex = 3;
            // 
            // txtConvertida
            // 
            txtConvertida.Location = new Point(2, 56);
            txtConvertida.Name = "txtConvertida";
            txtConvertida.Size = new Size(349, 27);
            txtConvertida.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 15);
            label5.Name = "label5";
            label5.Size = new Size(282, 38);
            label5.TabIndex = 0;
            label5.Text = "Cantidad convertida";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(111, 334);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(151, 37);
            btnConvertir.TabIndex = 9;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 506);
            Controls.Add(btnConvertir);
            Controls.Add(panel2);
            Controls.Add(lstDesde);
            Controls.Add(lstHacia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbTipo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Conversor de unidades";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCantidad;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbTipo;
        private Label label3;
        private Label label4;
        private ListBox lstHacia;
        private ListBox lstDesde;
        private Panel panel2;
        private TextBox txtConvertida;
        private Label label5;
        private Button btnConvertir;
    }
}