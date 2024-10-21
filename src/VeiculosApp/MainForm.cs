namespace VeiculosApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new CadastroVeiculoForm();
            form2.ShowDialog();
         //   form2.Show();
        }

        private void sairToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma ?", "SAIR DO PROGRAMA", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
