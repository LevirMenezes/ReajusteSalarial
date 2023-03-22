using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reajuste_Salarial
{
    public partial class Form1 : Form
    {
        public RadioButton Categoria { get; set; }
        public RadioButton Turno { get; set; }
        public double Coeficiente { get; set; }
        public double Imposto { get; set; }
        public double Gratificacao { get; set; }
        public double Alimentacao { get; set; }
        public double SalarioBruto { get; set; }
        public double SalarioLiquido { get; set; }
        public string Classificacao { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void SetCategoria()
        {
            double SalarioMinino = double.Parse(txtSalarioMinimo.Text);
            bool condicao;
            double HrsTrabalhadas = double.Parse(txtHorasTrabalhadas.Text);
            SalarioBruto = HrsTrabalhadas * Coeficiente;
            Alimentacao = ((SalarioBruto / 3.0) / 2.0);
            
            switch (Categoria.Text)
            {
                case "Calouro":
                    condicao = SalarioMinino < 300.00;
                    Imposto = condicao ? SalarioMinino * 0.01 : SalarioMinino * 0.02;
                    Alimentacao = SalarioBruto < (SalarioMinino / 2) ? (SalarioBruto / 3.0) : Alimentacao;
                    break;

                case "Veterano":
                    condicao = SalarioMinino < 400.00;
                    Imposto = condicao ? SalarioMinino * 0.03 : SalarioMinino * 0.04;
                    break;
            }
        }

        private void SetTurno()
        {
            Gratificacao = 30.0;
            switch (Turno.Text)
            {
                case "Matutino":
                    Coeficiente = double.Parse(txtSalarioMinimo.Text) * 0.01;
                    break;

                case "Vespertino":
                    Coeficiente = double.Parse(txtSalarioMinimo.Text) * 0.02;
                    break;

                case "Noturno":
                    Coeficiente = double.Parse(txtSalarioMinimo.Text) * 0.03;
                    if (double.Parse(txtHorasTrabalhadas.Text) > 80.0)
                    {
                        Gratificacao = 50.0;
                    }
                    break;

                default:
                    break;
            }
            
        }
        #region turno

        private void rbnMatutino_CheckedChanged(object sender, EventArgs e)
        {
            Turno = sender as RadioButton;
        }

        private void rbnVespertino_CheckedChanged(object sender, EventArgs e)
        {
            Turno = sender as RadioButton;
        }

        private void rbnNoturno_CheckedChanged(object sender, EventArgs e)
        {
            Turno = sender as RadioButton;
        }

        #endregion

        #region categoria

        private void rbnCalouro_CheckedChanged(object sender, EventArgs e)
        {
            Categoria = sender as RadioButton;
        }

        private void rbnVeterano_CheckedChanged(object sender, EventArgs e)
        {
            Categoria = sender as RadioButton;
        }


        #endregion
        private void Apresentacao()
        {
            lstInformes.Items.Clear();
            lstInformes.Items.Add("Valor do coeficiente:" + Coeficiente.ToString("C2"));
            lstInformes.Items.Add("Salário bruto:" + SalarioBruto.ToString("C2"));
            lstInformes.Items.Add("Valor do imposto:" + Imposto.ToString("C2"));
            lstInformes.Items.Add("Valor da gratificação:" + Gratificacao.ToString("C2"));
            lstInformes.Items.Add("Valor auxílio alimentação:" + Alimentacao.ToString("C2"));
            lstInformes.Items.Add("Salário líquido:" + SalarioLiquido.ToString("C2"));

            txtClassificacao.Text = Classificacao.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                if (Categoria == null || Turno == null || String.IsNullOrWhiteSpace(txtHorasTrabalhadas.Text) || String.IsNullOrWhiteSpace(txtSalarioMinimo.Text))
                {
                    throw new Exception("Não deixe nenhum campo vazio ou desmarcado!");
                }
                else
                {
                    SetTurno();
                    SetCategoria();
                }

                double SalarioLiquido = SalarioBruto - Imposto + Gratificacao + Alimentacao;

                if (SalarioLiquido < 350.0)
                {
                    Classificacao = "mal remunerado";
                }
                else
                {
                    Classificacao = SalarioLiquido > 600.0 ? "bem remunerado" : "normal";
                }

                Apresentacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
