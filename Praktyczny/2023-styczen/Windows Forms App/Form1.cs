namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string lowerLetters = "abcdefghijklmnoprstuwvxyz";
        private string upperLetters = "ABCDEFGHIJKLMNOPRSTUWVXYZ";
        private string numbers = "1234567890";
        private string specialCharacters = "!@#$%^&*()_+-=";
        private bool isChecked_upperLetters = false;
        private bool isChecked_numbers = false;
        private bool isChecked_specialCharacters = false;
        private int minPasswordLen = 0;
        private string genPass = "";
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button_GeneratePassword_Click(object sender, EventArgs e)
        {
            try
            {
                minPasswordLen = 0;
                int passwordLength = Convert.ToInt32(textBox_PasswordLength.Text);

                if (checkBox_upperAndLowerLetters.Checked) { isChecked_upperLetters = true; minPasswordLen++; }
                if (checkBox_Numbers.Checked) { isChecked_numbers = true; minPasswordLen++; }
                if (checkBox_SpecialCharacters.Checked) { isChecked_specialCharacters = true; minPasswordLen++; }

                if (passwordLength > minPasswordLen)
                {
                    genPass = "";
                    if (isChecked_upperLetters)
                    {
                        genPass += getRandomChar(upperLetters);
                    }
                    if (isChecked_numbers)
                    {
                        genPass += getRandomChar(numbers);
                    }
                    if (isChecked_specialCharacters)
                    {
                        genPass += getRandomChar(specialCharacters);
                    }
                    if (passwordLength > genPass.Length)
                    {
                        while (passwordLength > genPass.Length)
                        {
                            genPass += getRandomChar(lowerLetters);
                        }
                    }
                    MessageBox.Show("Has³o wygenerowane: " + genPass);
                }
                else
                {
                    MessageBox.Show("dlugosc hasla musi byc > " + minPasswordLen);
                }
            }
            catch
            {
                MessageBox.Show("tylko cyfry w dlugosci hasla");
            }
        }
        private char getRandomChar(string characters)
        {
            int index = r.Next(0, characters.Length);
            return characters[index];
        }

        private void button_SubmitForm_Click(object sender, EventArgs e)
        {
            var imie = textBox_Name.Text.ToString();
            var nazwisko = textBox_Surname.Text.ToString();
            var stanowisko = comboBox_WorkPosition.Text.ToString();
            MessageBox.Show("Dane pracownika: "+imie+" "+nazwisko+" "+stanowisko+" Has³o: "+genPass);
        }
    }
}