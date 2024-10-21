namespace VeiculosApp
{
    partial class CadastroVeiculoForm
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
            txt_titulo = new TextBox();
            label2 = new Label();
            txt_marca = new TextBox();
            label3 = new Label();
            txt_modelo = new TextBox();
            label4 = new Label();
            cmb_ano = new ComboBox();
            label5 = new Label();
            cmb_cor = new ComboBox();
            label6 = new Label();
            msk_placa = new MaskedTextBox();
            label7 = new Label();
            txt_valor = new TextBox();
            btn_gravar = new Button();
            btn_cancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(133, 16);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(655, 31);
            txt_titulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 2;
            label2.Text = "Marca:";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(133, 55);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(310, 31);
            txt_marca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 53);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Modelo:";
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(530, 56);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(258, 31);
            txt_modelo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 104);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 6;
            label4.Text = "Ano Fab:";
            // 
            // cmb_ano
            // 
            cmb_ano.FormattingEnabled = true;
            cmb_ano.Location = new Point(133, 99);
            cmb_ano.Name = "cmb_ano";
            cmb_ano.Size = new Size(182, 33);
            cmb_ano.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 99);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 8;
            label5.Text = "Cor:";
            // 
            // cmb_cor
            // 
            cmb_cor.FormattingEnabled = true;
            cmb_cor.Location = new Point(530, 96);
            cmb_cor.Name = "cmb_cor";
            cmb_cor.Size = new Size(258, 33);
            cmb_cor.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 144);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 10;
            label6.Text = "Placa:";
            // 
            // msk_placa
            // 
            msk_placa.Location = new Point(134, 143);
            msk_placa.Mask = "AAA-#A##";
            msk_placa.Name = "msk_placa";
            msk_placa.Size = new Size(181, 31);
            msk_placa.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 141);
            label7.Name = "label7";
            label7.Size = new Size(56, 25);
            label7.TabIndex = 12;
            label7.Text = "Valor:";
            // 
            // txt_valor
            // 
            txt_valor.Location = new Point(530, 141);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(150, 31);
            txt_valor.TabIndex = 13;
            // 
            // btn_gravar
            // 
            btn_gravar.Location = new Point(255, 205);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(112, 34);
            btn_gravar.TabIndex = 14;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(422, 206);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(112, 34);
            btn_cancelar.TabIndex = 15;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // CadastroVeiculoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 267);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_gravar);
            Controls.Add(txt_valor);
            Controls.Add(label7);
            Controls.Add(msk_placa);
            Controls.Add(label6);
            Controls.Add(cmb_cor);
            Controls.Add(label5);
            Controls.Add(cmb_ano);
            Controls.Add(label4);
            Controls.Add(txt_modelo);
            Controls.Add(label3);
            Controls.Add(txt_marca);
            Controls.Add(label2);
            Controls.Add(txt_titulo);
            Controls.Add(label1);
            Name = "CadastroVeiculoForm";
            Text = "CadastroVeiculoForm";
            Load += CadastroVeiculoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_titulo;
        private Label label2;
        private TextBox txt_marca;
        private Label label3;
        private TextBox txt_modelo;
        private Label label4;
        private ComboBox cmb_ano;
        private Label label5;
        private ComboBox cmb_cor;
        private Label label6;
        private MaskedTextBox msk_placa;
        private Label label7;
        private TextBox txt_valor;
        private Button btn_gravar;
        private Button btn_cancelar;
    }
}