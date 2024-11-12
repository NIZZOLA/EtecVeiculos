namespace VeiculosApp;

partial class ListarVeiculos
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarVeiculos));
        toolStrip1 = new ToolStrip();
        btnIncluir = new ToolStripButton();
        btnAlterar = new ToolStripButton();
        btnExcluir = new ToolStripButton();
        dataGridView1 = new DataGridView();
        toolStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // toolStrip1
        // 
        toolStrip1.Items.AddRange(new ToolStripItem[] { btnIncluir, btnAlterar, btnExcluir });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(800, 25);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // btnIncluir
        // 
        btnIncluir.Image = (Image)resources.GetObject("btnIncluir.Image");
        btnIncluir.ImageTransparentColor = Color.Magenta;
        btnIncluir.Name = "btnIncluir";
        btnIncluir.Size = new Size(60, 22);
        btnIncluir.Text = "&Incluir";
        btnIncluir.Click += btnIncluir_Click;
        // 
        // btnAlterar
        // 
        btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
        btnAlterar.ImageTransparentColor = Color.Magenta;
        btnAlterar.Name = "btnAlterar";
        btnAlterar.Size = new Size(62, 22);
        btnAlterar.Text = "Alterar";
        btnAlterar.Click += btnAlterar_Click;
        // 
        // btnExcluir
        // 
        btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
        btnExcluir.ImageTransparentColor = Color.Magenta;
        btnExcluir.Name = "btnExcluir";
        btnExcluir.Size = new Size(62, 22);
        btnExcluir.Text = "Excluir";
        btnExcluir.Click += btnExcluir_Click;
        // 
        // dataGridView1
        // 
        dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        dataGridView1.Location = new Point(12, 28);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(776, 410);
        dataGridView1.TabIndex = 1;
        // 
        // ListarVeiculos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(dataGridView1);
        Controls.Add(toolStrip1);
        Name = "ListarVeiculos";
        Text = "ListarVeiculos";
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip toolStrip1;
    private DataGridView dataGridView1;
    private ToolStripButton btnIncluir;
    private ToolStripButton btnAlterar;
    private ToolStripButton btnExcluir;
}