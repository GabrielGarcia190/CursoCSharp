namespace CRUD2_0
{
    partial class btnListar
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalvar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.numCusto = new System.Windows.Forms.NumericUpDown();
            this.numVenda = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.checkTeste = new System.Windows.Forms.CheckBox();
            this.dtPTeste = new System.Windows.Forms.DateTimePicker();
            this.cbTeste = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalvar.Location = new System.Drawing.Point(456, 354);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 41);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(534, 174);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(315, 26);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // numCusto
            // 
            this.numCusto.Location = new System.Drawing.Point(677, 231);
            this.numCusto.Name = "numCusto";
            this.numCusto.Size = new System.Drawing.Size(172, 20);
            this.numCusto.TabIndex = 2;
            // 
            // numVenda
            // 
            this.numVenda.Location = new System.Drawing.Point(677, 279);
            this.numVenda.Name = "numVenda";
            this.numVenda.Size = new System.Drawing.Size(172, 20);
            this.numVenda.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Preço de Venda (R$):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preço de Cutso (R$):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "LISTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(1074, 50);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(165, 49);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // checkTeste
            // 
            this.checkTeste.AutoSize = true;
            this.checkTeste.Location = new System.Drawing.Point(1074, 246);
            this.checkTeste.Name = "checkTeste";
            this.checkTeste.Size = new System.Drawing.Size(80, 17);
            this.checkTeste.TabIndex = 6;
            this.checkTeste.Text = "checkBox1";
            this.checkTeste.UseVisualStyleBackColor = true;
            // 
            // dtPTeste
            // 
            this.dtPTeste.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPTeste.Location = new System.Drawing.Point(975, 318);
            this.dtPTeste.Name = "dtPTeste";
            this.dtPTeste.Size = new System.Drawing.Size(252, 20);
            this.dtPTeste.TabIndex = 7;
            // 
            // cbTeste
            // 
            this.cbTeste.FormattingEnabled = true;
            this.cbTeste.Items.AddRange(new object[] {
            "",
            "Teste 1",
            "Teste 2 ",
            "Teste 3"});
            this.cbTeste.Location = new System.Drawing.Point(1000, 390);
            this.cbTeste.Name = "cbTeste";
            this.cbTeste.Size = new System.Drawing.Size(121, 21);
            this.cbTeste.TabIndex = 8;
            // 
            // btnListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.cbTeste);
            this.Controls.Add(this.dtPTeste);
            this.Controls.Add(this.checkTeste);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numVenda);
            this.Controls.Add(this.numCusto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.btnSalvar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "btnListar";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.NumericUpDown numCusto;
        private System.Windows.Forms.NumericUpDown numVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.CheckBox checkTeste;
        private System.Windows.Forms.DateTimePicker dtPTeste;
        private System.Windows.Forms.ComboBox cbTeste;
    }
}

