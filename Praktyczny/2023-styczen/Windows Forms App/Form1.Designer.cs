namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            comboBox_WorkPosition = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBox_Surname = new TextBox();
            label1 = new Label();
            textBox_Name = new TextBox();
            groupBox2 = new GroupBox();
            button_GeneratePassword = new Button();
            checkBox_SpecialCharacters = new CheckBox();
            checkBox_Numbers = new CheckBox();
            checkBox_upperAndLowerLetters = new CheckBox();
            label4 = new Label();
            textBox_PasswordLength = new TextBox();
            button_SubmitForm = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_WorkPosition);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_Surname);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox_Name);
            groupBox1.Location = new Point(28, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(261, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // comboBox_WorkPosition
            // 
            comboBox_WorkPosition.FormattingEnabled = true;
            comboBox_WorkPosition.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
            comboBox_WorkPosition.Location = new Point(116, 111);
            comboBox_WorkPosition.Name = "comboBox_WorkPosition";
            comboBox_WorkPosition.Size = new Size(131, 23);
            comboBox_WorkPosition.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 114);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Stanowisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Nazwisko";
            // 
            // textBox_Surname
            // 
            textBox_Surname.Location = new Point(116, 68);
            textBox_Surname.Name = "textBox_Surname";
            textBox_Surname.Size = new Size(131, 23);
            textBox_Surname.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Imię";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(116, 24);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(131, 23);
            textBox_Name.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_GeneratePassword);
            groupBox2.Controls.Add(checkBox_SpecialCharacters);
            groupBox2.Controls.Add(checkBox_Numbers);
            groupBox2.Controls.Add(checkBox_upperAndLowerLetters);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_PasswordLength);
            groupBox2.Location = new Point(359, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 179);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Generowanie hasła";
            // 
            // button_GeneratePassword
            // 
            button_GeneratePassword.BackColor = Color.SteelBlue;
            button_GeneratePassword.ForeColor = Color.White;
            button_GeneratePassword.Location = new Point(106, 142);
            button_GeneratePassword.Name = "button_GeneratePassword";
            button_GeneratePassword.Size = new Size(90, 23);
            button_GeneratePassword.TabIndex = 3;
            button_GeneratePassword.Text = "Generuj hasło";
            button_GeneratePassword.UseVisualStyleBackColor = false;
            button_GeneratePassword.Click += button_GeneratePassword_Click;
            // 
            // checkBox_SpecialCharacters
            // 
            checkBox_SpecialCharacters.AutoSize = true;
            checkBox_SpecialCharacters.Location = new Point(37, 117);
            checkBox_SpecialCharacters.Name = "checkBox_SpecialCharacters";
            checkBox_SpecialCharacters.Size = new Size(107, 19);
            checkBox_SpecialCharacters.TabIndex = 11;
            checkBox_SpecialCharacters.Text = "Znaki specjalne";
            checkBox_SpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBox_Numbers
            // 
            checkBox_Numbers.AutoSize = true;
            checkBox_Numbers.Location = new Point(37, 92);
            checkBox_Numbers.Name = "checkBox_Numbers";
            checkBox_Numbers.Size = new Size(54, 19);
            checkBox_Numbers.TabIndex = 10;
            checkBox_Numbers.Text = "Cyfry";
            checkBox_Numbers.UseVisualStyleBackColor = true;
            // 
            // checkBox_upperAndLowerLetters
            // 
            checkBox_upperAndLowerLetters.AutoSize = true;
            checkBox_upperAndLowerLetters.Checked = true;
            checkBox_upperAndLowerLetters.CheckState = CheckState.Checked;
            checkBox_upperAndLowerLetters.Location = new Point(37, 67);
            checkBox_upperAndLowerLetters.Name = "checkBox_upperAndLowerLetters";
            checkBox_upperAndLowerLetters.Size = new Size(126, 19);
            checkBox_upperAndLowerLetters.TabIndex = 9;
            checkBox_upperAndLowerLetters.Text = "Małe i wielkie cyfry";
            checkBox_upperAndLowerLetters.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 30);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 8;
            label4.Text = "Ile znaków?";
            // 
            // textBox_PasswordLength
            // 
            textBox_PasswordLength.Location = new Point(132, 27);
            textBox_PasswordLength.Name = "textBox_PasswordLength";
            textBox_PasswordLength.Size = new Size(131, 23);
            textBox_PasswordLength.TabIndex = 7;
            // 
            // button_SubmitForm
            // 
            button_SubmitForm.BackColor = Color.SteelBlue;
            button_SubmitForm.ForeColor = Color.White;
            button_SubmitForm.Location = new Point(210, 240);
            button_SubmitForm.Name = "button_SubmitForm";
            button_SubmitForm.Size = new Size(216, 23);
            button_SubmitForm.TabIndex = 2;
            button_SubmitForm.Text = "Zatwierdź";
            button_SubmitForm.UseVisualStyleBackColor = false;
            button_SubmitForm.Click += button_SubmitForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(659, 284);
            Controls.Add(button_SubmitForm);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Dodaj pracownika PESEL: XYZ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox_WorkPosition;
        private Label label3;
        private Label label2;
        private TextBox textBox_Surname;
        private Label label1;
        private TextBox textBox_Name;
        private GroupBox groupBox2;
        private Button button_GeneratePassword;
        private CheckBox checkBox_SpecialCharacters;
        private CheckBox checkBox_Numbers;
        private CheckBox checkBox_upperAndLowerLetters;
        private Label label4;
        private TextBox textBox_PasswordLength;
        private Button button_SubmitForm;
    }
}