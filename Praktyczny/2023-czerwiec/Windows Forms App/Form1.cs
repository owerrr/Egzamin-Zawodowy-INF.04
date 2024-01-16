using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (radioButton_Pocztowka.Checked)
            {
                label_Price.Text = "Cena: 1z�";
                pictureBox1.Image = Resources.pocztowka;
            }
            else if (radioButton_List.Checked)
            {
                label_Price.Text = "Cena: 1.5z�";
                pictureBox1.Image = Resources.list;
            }
            else if (radioButton_Paczka.Checked)
            {
                label_Price.Text = "Cena: 10z�";
                pictureBox1.Image = Resources.paczka;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {   
                int postalcode = Convert.ToInt32(textBox_kodPocztowy.Text);
                if(textBox_kodPocztowy.Text.Length > 5 || textBox_kodPocztowy.Text.Length < 1)
                {
                    MessageBox.Show("Nieprawid�owa liczba cyfr w kodzie pocztowym");
                }
                else
                {
                    MessageBox.Show("Dane przesy�ki zosta�y wprowadzone");
                }
            }
            catch
            {
                MessageBox.Show("Kod pocztowy powinien si� sk�ada� z samych cyfr");
            }
        }
    }
}