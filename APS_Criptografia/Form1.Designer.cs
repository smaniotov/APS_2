namespace APS_Criptografia
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxEncriptar = new System.Windows.Forms.TextBox();
            this.txtDecriptar = new System.Windows.Forms.TextBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.cbmDoc = new System.Windows.Forms.ComboBox();
            this.tbDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbAPSDataSet = new APS_Criptografia.dbAPSDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dbAPSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDocumentTableAdapter = new APS_Criptografia.dbAPSDataSetTableAdapters.tbDocumentTableAdapter();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAPSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAPSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxEncriptar
            // 
            this.txtBoxEncriptar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxEncriptar.Location = new System.Drawing.Point(15, 166);
            this.txtBoxEncriptar.Multiline = true;
            this.txtBoxEncriptar.Name = "txtBoxEncriptar";
            this.txtBoxEncriptar.Size = new System.Drawing.Size(565, 63);
            this.txtBoxEncriptar.TabIndex = 1;
            this.txtBoxEncriptar.TextChanged += new System.EventHandler(this.txtBoxEncriptar_TextChanged);
            // 
            // txtDecriptar
            // 
            this.txtDecriptar.Location = new System.Drawing.Point(15, 269);
            this.txtDecriptar.Multiline = true;
            this.txtDecriptar.Name = "txtDecriptar";
            this.txtDecriptar.Size = new System.Drawing.Size(565, 63);
            this.txtDecriptar.TabIndex = 1;
            this.txtDecriptar.TextChanged += new System.EventHandler(this.txtDecriptar_TextChanged);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(15, 360);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(565, 63);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(393, 27);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(91, 35);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "Encriptografar";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(501, 27);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(91, 35);
            this.btn_Decrypt.TabIndex = 3;
            this.btn_Decrypt.Text = "Descriptografar";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // cbmDoc
            // 
            this.cbmDoc.DataSource = this.tbDocumentBindingSource;
            this.cbmDoc.DisplayMember = "DocNome";
            this.cbmDoc.FormattingEnabled = true;
            this.cbmDoc.Location = new System.Drawing.Point(182, 108);
            this.cbmDoc.Name = "cbmDoc";
            this.cbmDoc.Size = new System.Drawing.Size(103, 21);
            this.cbmDoc.TabIndex = 5;
            this.cbmDoc.ValueMember = "DocNome";
            this.cbmDoc.SelectedIndexChanged += new System.EventHandler(this.cbmDoc_SelectedIndexChanged);
            // 
            // tbDocumentBindingSource
            // 
            this.tbDocumentBindingSource.DataMember = "tbDocument";
            this.tbDocumentBindingSource.DataSource = this.dbAPSDataSet;
            // 
            // dbAPSDataSet
            // 
            this.dbAPSDataSet.DataSetName = "dbAPSDataSet";
            this.dbAPSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contéudo Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conteúdo Criptografado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Conteúdo Descriptografado";
            // 
            // dbAPSDataSetBindingSource
            // 
            this.dbAPSDataSetBindingSource.DataSource = this.dbAPSDataSet;
            this.dbAPSDataSetBindingSource.Position = 0;
            // 
            // tbDocumentTableAdapter
            // 
            this.tbDocumentTableAdapter.ClearBeforeFill = true;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Location = new System.Drawing.Point(288, 106);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 8;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(288, 27);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 35);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir Documento";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(182, 27);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 35);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo Documento";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(492, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome do Documento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(296, 444);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(139, 35);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(441, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 109);
            this.panel1.TabIndex = 18;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(146, 444);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(139, 35);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 485);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmDoc);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.txtDecriptar);
            this.Controls.Add(this.txtBoxEncriptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAPSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAPSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEncriptar;
        private System.Windows.Forms.TextBox txtDecriptar;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.ComboBox cbmDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource dbAPSDataSetBindingSource;
        private dbAPSDataSet dbAPSDataSet;
        private System.Windows.Forms.BindingSource tbDocumentBindingSource;
        private dbAPSDataSetTableAdapters.tbDocumentTableAdapter tbDocumentTableAdapter;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
    }
}

