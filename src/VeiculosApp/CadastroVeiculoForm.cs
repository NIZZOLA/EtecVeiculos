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

namespace VeiculosApp
{
    public partial class CadastroVeiculoForm : Form
    {
        public CadastroVeiculoForm()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Confirma ?", "GRAVAR VEICULO", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                var veic = new VeiculoModel();
                veic.Titulo = txt_titulo.Text;
                veic.Placa = msk_placa.Text;
                veic.Cor = cmb_cor.Text;
                veic.Marca = txt_marca.Text;
                veic.Modelo = txt_modelo.Text;
                if (cmb_ano.SelectedIndex >= 0) 
                    veic.AnoFab = Convert.ToInt32(cmb_ano.Text);
                if (!string.IsNullOrEmpty(txt_valor.Text))
                    veic.Valor = Convert.ToDouble(txt_valor.Text);

                if (veic.ValidarCadastro() == "")
                {
                    if (veic.Gravar())
                    {
                        MessageBox.Show("Gravado com sucesso !");
                        LimpaCampos();
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

        private void CadastroVeiculoForm_Load(object sender, EventArgs e)
        {
            txt_valor.Text = "0";
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

        private void LimpaCampos()
        {
            txt_titulo.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            msk_placa.Text = "";
            cmb_ano.Text = "";
            cmb_ano.SelectedIndex = -1;
            cmb_cor.Text = "";
            cmb_cor.SelectedIndex = -1;
            txt_valor.Text = "0";
        }
    }
}
