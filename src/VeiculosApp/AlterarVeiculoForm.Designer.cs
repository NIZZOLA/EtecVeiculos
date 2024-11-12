namespace VeiculosApp;

partial class AlterarVeiculoForm
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
        btn_cancelar = new Button();
        btn_gravar = new Button();
        txt_valor = new TextBox();
        label7 = new Label();
        msk_placa = new MaskedTextBox();
        label6 = new Label();
        cmb_cor = new ComboBox();
        label5 = new Label();
        cmb_ano = new ComboBox();
        label4 = new Label();
        txt_modelo = new TextBox();
        label3 = new Label();
        txt_marca = new TextBox();
        label2 = new Label();
        txt_titulo = new TextBox();
        label1 = new Label();
        label8 = new Label();
        lblCodigo = new Label();
        SuspendLayout();
        // 
        // btn_cancelar
        // 
        btn_cancelar.Location = new Point(298, 150);
        btn_cancelar.Margin = new Padding(2);
        btn_cancelar.Name = "btn_cancelar";
        btn_cancelar.Size = new Size(78, 20);
        btn_cancelar.TabIndex = 31;
        btn_cancelar.Text = "Cancelar";
        btn_cancelar.UseVisualStyleBackColor = true;
        // 
        // btn_gravar
        // 
        btn_gravar.Location = new Point(181, 149);
        btn_gravar.Margin = new Padding(2);
        btn_gravar.Name = "btn_gravar";
        btn_gravar.Size = new Size(78, 20);
        btn_gravar.TabIndex = 30;
        btn_gravar.Text = "Gravar";
        btn_gravar.UseVisualStyleBackColor = true;
        btn_gravar.Click += btn_gravar_Click;
        // 
        // txt_valor
        // 
        txt_valor.Location = new Point(374, 111);
        txt_valor.Margin = new Padding(2);
        txt_valor.Name = "txt_valor";
        txt_valor.Size = new Size(106, 23);
        txt_valor.TabIndex = 29;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(296, 111);
        label7.Margin = new Padding(2, 0, 2, 0);
        label7.Name = "label7";
        label7.Size = new Size(36, 15);
        label7.TabIndex = 28;
        label7.Text = "Valor:";
        // 
        // msk_placa
        // 
        msk_placa.Location = new Point(97, 112);
        msk_placa.Margin = new Padding(2);
        msk_placa.Mask = "###-####";
        msk_placa.Name = "msk_placa";
        msk_placa.Size = new Size(128, 23);
        msk_placa.TabIndex = 27;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(15, 112);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(38, 15);
        label6.TabIndex = 26;
        label6.Text = "Placa:";
        // 
        // cmb_cor
        // 
        cmb_cor.FormattingEnabled = true;
        cmb_cor.Location = new Point(374, 84);
        cmb_cor.Margin = new Padding(2);
        cmb_cor.Name = "cmb_cor";
        cmb_cor.Size = new Size(182, 23);
        cmb_cor.TabIndex = 25;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(317, 85);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(29, 15);
        label5.TabIndex = 24;
        label5.Text = "Cor:";
        // 
        // cmb_ano
        // 
        cmb_ano.FormattingEnabled = true;
        cmb_ano.Location = new Point(96, 85);
        cmb_ano.Margin = new Padding(2);
        cmb_ano.Name = "cmb_ano";
        cmb_ano.Size = new Size(129, 23);
        cmb_ano.TabIndex = 23;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(11, 88);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(54, 15);
        label4.TabIndex = 22;
        label4.Text = "Ano Fab:";
        // 
        // txt_modelo
        // 
        txt_modelo.Location = new Point(374, 60);
        txt_modelo.Margin = new Padding(2);
        txt_modelo.Name = "txt_modelo";
        txt_modelo.Size = new Size(182, 23);
        txt_modelo.TabIndex = 21;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(317, 58);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(51, 15);
        label3.TabIndex = 20;
        label3.Text = "Modelo:";
        // 
        // txt_marca
        // 
        txt_marca.Location = new Point(96, 59);
        txt_marca.Margin = new Padding(2);
        txt_marca.Name = "txt_marca";
        txt_marca.Size = new Size(218, 23);
        txt_marca.TabIndex = 19;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(11, 63);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(43, 15);
        label2.TabIndex = 18;
        label2.Text = "Marca:";
        // 
        // txt_titulo
        // 
        txt_titulo.Location = new Point(96, 36);
        txt_titulo.Margin = new Padding(2);
        txt_titulo.Name = "txt_titulo";
        txt_titulo.Size = new Size(460, 23);
        txt_titulo.TabIndex = 17;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(11, 36);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(37, 15);
        label1.TabIndex = 16;
        label1.Text = "Titulo";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(11, 9);
        label8.Name = "label8";
        label8.Size = new Size(49, 15);
        label8.TabIndex = 32;
        label8.Text = "Código:";
        // 
        // lblCodigo
        // 
        lblCodigo.AutoSize = true;
        lblCodigo.BackColor = SystemColors.ButtonFace;
        lblCodigo.Location = new Point(98, 14);
        lblCodigo.Name = "lblCodigo";
        lblCodigo.Size = new Size(13, 15);
        lblCodigo.TabIndex = 33;
        lblCodigo.Text = "0";
        // 
        // AlterarVeiculoForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(605, 181);
        Controls.Add(lblCodigo);
        Controls.Add(label8);
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
        Name = "AlterarVeiculoForm";
        Text = "AlterarVeiculoForm";
        Load += AlterarVeiculoForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_cancelar;
    private Button btn_gravar;
    private TextBox txt_valor;
    private Label label7;
    private MaskedTextBox msk_placa;
    private Label label6;
    private ComboBox cmb_cor;
    private Label label5;
    private ComboBox cmb_ano;
    private Label label4;
    private TextBox txt_modelo;
    private Label label3;
    private TextBox txt_marca;
    private Label label2;
    private TextBox txt_titulo;
    private Label label1;
    private Label label8;
    private Label lblCodigo;
}