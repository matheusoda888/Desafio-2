namespace WinFormsFabricio
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_NomeFornecedor = new System.Windows.Forms.TextBox();
            this.buttonGravarFornecedor = new System.Windows.Forms.Button();
            this.buttonGravarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FornecedorProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_IdCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_IdProduto = new System.Windows.Forms.TextBox();
            this.buttonGravarCompra = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_GerarNota = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(12, 65);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(100, 23);
            this.textBox_Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(12, 93);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 4;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // textBox_NomeFornecedor
            // 
            this.textBox_NomeFornecedor.Location = new System.Drawing.Point(118, 65);
            this.textBox_NomeFornecedor.Name = "textBox_NomeFornecedor";
            this.textBox_NomeFornecedor.Size = new System.Drawing.Size(100, 23);
            this.textBox_NomeFornecedor.TabIndex = 9;
            // 
            // buttonGravarFornecedor
            // 
            this.buttonGravarFornecedor.Location = new System.Drawing.Point(118, 93);
            this.buttonGravarFornecedor.Name = "buttonGravarFornecedor";
            this.buttonGravarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarFornecedor.TabIndex = 11;
            this.buttonGravarFornecedor.Text = "Gravar";
            this.buttonGravarFornecedor.UseVisualStyleBackColor = true;
            this.buttonGravarFornecedor.Click += new System.EventHandler(this.buttonGravarFornecedor_Click);
            // 
            // buttonGravarProduto
            // 
            this.buttonGravarProduto.Location = new System.Drawing.Point(235, 144);
            this.buttonGravarProduto.Name = "buttonGravarProduto";
            this.buttonGravarProduto.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarProduto.TabIndex = 14;
            this.buttonGravarProduto.Text = "Gravar";
            this.buttonGravarProduto.UseVisualStyleBackColor = true;
            this.buttonGravarProduto.Click += new System.EventHandler(this.buttonGravarProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nome";
            // 
            // textBox_NomeProduto
            // 
            this.textBox_NomeProduto.Location = new System.Drawing.Point(235, 65);
            this.textBox_NomeProduto.Name = "textBox_NomeProduto";
            this.textBox_NomeProduto.Size = new System.Drawing.Size(100, 23);
            this.textBox_NomeProduto.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fornecedor";
            // 
            // textBox_FornecedorProduto
            // 
            this.textBox_FornecedorProduto.Location = new System.Drawing.Point(235, 115);
            this.textBox_FornecedorProduto.Name = "textBox_FornecedorProduto";
            this.textBox_FornecedorProduto.Size = new System.Drawing.Size(100, 23);
            this.textBox_FornecedorProduto.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID Cliente";
            // 
            // textBox_IdCliente
            // 
            this.textBox_IdCliente.Location = new System.Drawing.Point(493, 65);
            this.textBox_IdCliente.Name = "textBox_IdCliente";
            this.textBox_IdCliente.Size = new System.Drawing.Size(100, 23);
            this.textBox_IdCliente.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID Protudo";
            // 
            // textBox_IdProduto
            // 
            this.textBox_IdProduto.Location = new System.Drawing.Point(493, 115);
            this.textBox_IdProduto.Name = "textBox_IdProduto";
            this.textBox_IdProduto.Size = new System.Drawing.Size(100, 23);
            this.textBox_IdProduto.TabIndex = 19;
            // 
            // buttonGravarCompra
            // 
            this.buttonGravarCompra.Location = new System.Drawing.Point(494, 144);
            this.buttonGravarCompra.Name = "buttonGravarCompra";
            this.buttonGravarCompra.Size = new System.Drawing.Size(99, 42);
            this.buttonGravarCompra.TabIndex = 21;
            this.buttonGravarCompra.Text = "Adicionar ao carrinho";
            this.buttonGravarCompra.UseVisualStyleBackColor = true;
            this.buttonGravarCompra.Click += new System.EventHandler(this.buttonGravarCompra_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(494, 192);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 22;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WinFormsFabricio.Form1);
            // 
            // button_GerarNota
            // 
            this.button_GerarNota.Location = new System.Drawing.Point(659, 163);
            this.button_GerarNota.Name = "button_GerarNota";
            this.button_GerarNota.Size = new System.Drawing.Size(75, 23);
            this.button_GerarNota.TabIndex = 23;
            this.button_GerarNota.Text = "Gerar nota";
            this.button_GerarNota.UseVisualStyleBackColor = true;
            this.button_GerarNota.Click += new System.EventHandler(this.button_GerarNota_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(659, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cliente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(118, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Fornecedor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(235, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(494, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 28);
            this.label10.TabIndex = 28;
            this.label10.Text = "Efetuar compra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_GerarNota);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonGravarCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_IdProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_IdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_FornecedorProduto);
            this.Controls.Add(this.buttonGravarProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NomeProduto);
            this.Controls.Add(this.buttonGravarFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NomeFornecedor);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Nome;
        private Label label1;
        private Button buttonGravar;
        private Label label2;
        private TextBox textBox_NomeFornecedor;
        private Button buttonGravarFornecedor;
        private Button buttonGravarProduto;
        private Label label3;
        private TextBox textBox_NomeProduto;
        private Label label4;
        private TextBox textBox_FornecedorProduto;
        private Label label5;
        private TextBox textBox_IdCliente;
        private Label label6;
        private TextBox textBox_IdProduto;
        private Button buttonGravarCompra;
        private DataGridView dataGridView;
        private BindingSource form1BindingSource;
        private Button button_GerarNota;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}