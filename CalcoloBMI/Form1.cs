namespace CalcoloBMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double altezza = Convert.ToDouble(tBoxAltezza.Text.Replace('.', ','));
                double peso = Convert.ToDouble(tBoxPeso.Text.Replace('.', ','));

                if (altezza > 3)
                {
                    MessageBox.Show("Attenzione l'altezza deve essere espressa in cm");
                    return;
                }

                if (altezza < 0)
                {
                    MessageBox.Show("Attenzione hai inserito un' altezza negativa");
                    return;
                }

                if (peso < 0)
                {
                    MessageBox.Show("Attenzione hai inserito un peso negativo");
                    return;
                }

                BodyMassIndex bmi = new(peso, altezza);

                string messaggio = string.Concat("Il tuo BMI è ", bmi.Bmi.ToString("0.00"), Environment.NewLine, "Sei quindi in una condizione di ", bmi.Tipologia);

                tBoxRisultato.Text = messaggio;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Attenzione devi inserire solo caratteri numerici");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Text = "";
            }
        }
    }
}
