namespace CRUD2_0.View
{
    partial class ListarProdutos
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
            this.dgListProds = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListProds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListProds
            // 
            this.dgListProds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListProds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListProds.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgListProds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgListProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListProds.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgListProds.Location = new System.Drawing.Point(41, 144);
            this.dgListProds.Name = "dgListProds";
            this.dgListProds.ReadOnly = true;
            this.dgListProds.Size = new System.Drawing.Size(1137, 176);
            this.dgListProds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA DE PRODUTOS CADASTRADOS";
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListProds);
            this.Name = "ListarProdutos";
            this.Text = "ListarProdutos";
            this.Load += new System.EventHandler(this.ListarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListProds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListProds;
        private System.Windows.Forms.Label label1;
    }
}