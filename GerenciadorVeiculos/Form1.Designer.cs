namespace GerenciadorVeiculos
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
            txtModelo = new TextBox();
            txtDiaria = new TextBox();
            txtEspecifico = new TextBox();
            cmbTipo = new ComboBox();
            modelo = new Label();
            diaria = new Label();
            lblEspecifico = new Label();
            label3 = new Label();
            label1 = new Label();
            btnLimpar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(200, 76);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(188, 23);
            txtModelo.TabIndex = 0;
            // 
            // txtDiaria
            // 
            txtDiaria.Location = new Point(200, 148);
            txtDiaria.Name = "txtDiaria";
            txtDiaria.Size = new Size(188, 23);
            txtDiaria.TabIndex = 1;
            // 
            // txtEspecifico
            // 
            txtEspecifico.Location = new Point(200, 222);
            txtEspecifico.Name = "txtEspecifico";
            txtEspecifico.Size = new Size(188, 23);
            txtEspecifico.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Carro", "Moto" });
            cmbTipo.Location = new Point(200, 284);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(188, 23);
            cmbTipo.TabIndex = 3;
            cmbTipo.SelectionChangeCommitted += cmbTipo_SelectedIndexChanged;
            // 
            // modelo
            // 
            modelo.Location = new Point(0, 0);
            modelo.Name = "modelo";
            modelo.Size = new Size(100, 23);
            modelo.TabIndex = 8;
            // 
            // diaria
            // 
            diaria.AutoSize = true;
            diaria.Location = new Point(75, 156);
            diaria.Name = "diaria";
            diaria.Size = new Size(37, 15);
            diaria.TabIndex = 5;
            diaria.Text = "Diaria";
            // 
            // lblEspecifico
            // 
            lblEspecifico.AutoSize = true;
            lblEspecifico.Location = new Point(75, 230);
            lblEspecifico.Name = "lblEspecifico";
            lblEspecifico.Size = new Size(40, 15);
            lblEspecifico.TabIndex = 6;
            lblEspecifico.Text = "Portas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 287);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 79);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 9;
            label1.Text = "Modelo";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(61, 384);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(130, 51);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar Campos";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(258, 384);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(130, 51);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "Cadastrar Veículo";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 680);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblEspecifico);
            Controls.Add(diaria);
            Controls.Add(modelo);
            Controls.Add(cmbTipo);
            Controls.Add(txtEspecifico);
            Controls.Add(txtDiaria);
            Controls.Add(txtModelo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtModelo;
        private TextBox txtDiaria;
        private TextBox txtEspecifico;
        private ComboBox cmbTipo;
        private Label modelo;
        private Label diaria;
        private Label lblEspecifico;
        private Label label3;
        private Label label1;
        private Button btnLimpar;
        private Button btnSalvar;
    }
}
