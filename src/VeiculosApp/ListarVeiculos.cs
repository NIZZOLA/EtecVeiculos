using VeiculosApp.Models;

namespace VeiculosApp;
public partial class ListarVeiculos : Form
{
    public ListarVeiculos()
    {
        InitializeComponent();
        CarregarVeiculos();
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
        var form = new CadastroVeiculoForm();
        form.ShowDialog();
        CarregarVeiculos();
    }

    private void CarregarVeiculos()
    {
        var veiculosDb = new VeiculoModel();
        var veiculos = veiculosDb.Listar();
        dataGridView1.DataSource = veiculos;
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow != null) //V
        {
            //currentRow = linha atual
            //cells[0] = coluna 0
            var codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var tela = new AlterarVeiculoForm(Convert.ToInt32(codigo));
            tela.ShowDialog();
            CarregarVeiculos();
        }
        else
        {
            MessageBox.Show("Nenhuma linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow != null) //V
        {
            //currentRow = linha atual
            //cells[0] = coluna 0
            var codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if ( MessageBox.Show("Deseja excluir o veículo selecionado ?", "Excluir", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var veiculo = new VeiculoModel();
                veiculo.Id = Convert.ToInt32(codigo);
                if (veiculo.Excluir())
                {
                    MessageBox.Show("Veículo excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarVeiculos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        else
        {
            MessageBox.Show("Nenhuma linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
