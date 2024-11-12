using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeiculosApp.Models;

namespace VeiculosApp;
public partial class AlterarVeiculoForm : Form
{
    public AlterarVeiculoForm()
    {
        InitializeComponent();
        CarregarDropDown();
    }

    public AlterarVeiculoForm(int id)
    {
        InitializeComponent();
        CarregarDropDown();
        lblCodigo.Text = id.ToString();
        var veic = new VeiculoModel();
        veic.Id = id;
        
        if(veic.Consultar())
        {
            txt_marca.Text = veic.Marca;
            txt_modelo.Text = veic.Modelo;
            txt_titulo.Text = veic.Titulo;
            txt_valor.Text = veic.Valor.ToString("##0,000.00");
            msk_placa.Text = veic.Placa;
            
            cmb_ano.Text = veic.AnoFab.ToString();
            cmb_ano.SelectedValue = veic.AnoFab.ToString();

            cmb_cor.Text = veic.Cor;
            cmb_cor.SelectedValue = veic.Cor;
        }
        else
        {
            MessageBox.Show("Veículo não encontrado.!");
        }
    }

    private void AlterarVeiculoForm_Load(object sender, EventArgs e)
    {

    }

    private void CarregarDropDown()
    {
        for (int i = 1900; i <= DateTime.Now.Year; i++)
        {
            cmb_ano.Items.Add(i.ToString());
        }
        string[] cores = ["Branco", "Preto", "Prata", "Vermelho", "Azul", "Verde"];
        foreach (var item in cores)
        {
            cmb_cor.Items.Add(item);
        }
    }

    private void btn_gravar_Click(object sender, EventArgs e)
    {
        var resposta = MessageBox.Show("Confirma ?", "ALTERAR VEICULO", MessageBoxButtons.YesNo);
        if (resposta == DialogResult.Yes)
        {
            var veic = new VeiculoModel();
            veic.Id = Convert.ToInt32(lblCodigo.Text);
            veic.Titulo = txt_titulo.Text;
            veic.Placa = msk_placa.Text;
            
            veic.Marca = txt_marca.Text;
            veic.Modelo = txt_modelo.Text;

            if (cmb_ano.SelectedIndex >= 0)
                veic.AnoFab = Convert.ToInt32(cmb_ano.Text);

            veic.Cor = cmb_cor.Text;

            if (!string.IsNullOrEmpty(txt_valor.Text))
                veic.Valor = Convert.ToDouble(txt_valor.Text);

            if (veic.ValidarCadastro() == "")
            {
                if (veic.Atualizar())
                {
                    MessageBox.Show("Gravado com sucesso !");
                    this.Close();
                }
                else
                    MessageBox.Show("Falha ao gravar !");
            }
            else
            {
                MessageBox.Show(veic.ValidarCadastro());
            }
        }
    }
}
