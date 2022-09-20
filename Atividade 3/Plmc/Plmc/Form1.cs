namespace Plmc
{
    public partial class Form1 : Form
    {
        double pesoAtual, altura, imc;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtAltura.Text, out altura) &&
                Double.TryParse(txtPesoAtual.Text, out pesoAtual))
            {
                if ((altura <= 0) || (pesoAtual <= 0))
                    MessageBox.Show("Valores devem ser maiores que zero!");
                else
                {
                    imc = pesoAtual / Math.Pow(altura, 2);

                    imc = Math.Round(imc, 1);

                    txtIMC.Text = imc.ToString("N1");

                    if (imc < 18.5)
                        MessageBox.Show("Magreza");
                    else if (imc <= 24.9)
                        MessageBox.Show("Normal");
                    else if (imc <= 29.9)
                        MessageBox.Show("Sobrepeso");
                    else if (imc <= 39.9)
                        MessageBox.Show("Obesidade");
                    else
                        MessageBox.Show("Obesidade Grave");
                }
            }
            else
                MessageBox.Show("Valores Inválidos");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();
            txtIMC.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}