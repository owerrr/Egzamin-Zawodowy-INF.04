namespace WinFormsApp1
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
            radioButton_Paczka = new RadioButton();
            radioButton_List = new RadioButton();
            radioButton_Pocztowka = new RadioButton();
            checkButton = new Button();
            pictureBox1 = new PictureBox();
            label_Price = new Label();
            submitButton = new Button();
            groupBox2 = new GroupBox();
            textBox_Miasto = new TextBox();
            label4 = new Label();
            textBox_kodPocztowy = new TextBox();
            label3 = new Label();
            textBox_Ulica = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_Paczka);
            groupBox1.Controls.Add(radioButton_List);
            groupBox1.Controls.Add(radioButton_Pocztowka);
            groupBox1.Location = new Point(43, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rodzaj przesyłki";
            // 
            // radioButton_Paczka
            // 
            radioButton_Paczka.AutoSize = true;
            radioButton_Paczka.Location = new Point(15, 69);
            radioButton_Paczka.Name = "radioButton_Paczka";
            radioButton_Paczka.Size = new Size(61, 19);
            radioButton_Paczka.TabIndex = 2;
            radioButton_Paczka.Text = "Paczka";
            radioButton_Paczka.UseVisualStyleBackColor = true;
            // 
            // radioButton_List
            // 
            radioButton_List.AutoSize = true;
            radioButton_List.Checked = true;
            radioButton_List.Location = new Point(15, 44);
            radioButton_List.Name = "radioButton_List";
            radioButton_List.Size = new Size(43, 19);
            radioButton_List.TabIndex = 1;
            radioButton_List.TabStop = true;
            radioButton_List.Text = "List";
            radioButton_List.UseVisualStyleBackColor = true;
            // 
            // radioButton_Pocztowka
            // 
            radioButton_Pocztowka.AutoSize = true;
            radioButton_Pocztowka.Location = new Point(15, 19);
            radioButton_Pocztowka.Name = "radioButton_Pocztowka";
            radioButton_Pocztowka.Size = new Size(82, 19);
            radioButton_Pocztowka.TabIndex = 0;
            radioButton_Pocztowka.Text = "Pocztówka";
            radioButton_Pocztowka.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(43, 142);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(235, 23);
            checkButton.TabIndex = 1;
            checkButton.Text = "Sprawdź Cenę";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.list;
            pictureBox1.Location = new Point(43, 171);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label_Price
            // 
            label_Price.AutoSize = true;
            label_Price.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Price.Location = new Point(196, 184);
            label_Price.Name = "label_Price";
            label_Price.Size = new Size(67, 30);
            label_Price.TabIndex = 3;
            label_Price.Text = "Cena:";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(43, 282);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(665, 25);
            submitButton.TabIndex = 4;
            submitButton.Text = "Zatwierdź";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_Miasto);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox_kodPocztowy);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox_Ulica);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(380, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 227);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dane adresowe";
            // 
            // textBox_Miasto
            // 
            textBox_Miasto.Location = new Point(16, 176);
            textBox_Miasto.Name = "textBox_Miasto";
            textBox_Miasto.Size = new Size(297, 23);
            textBox_Miasto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 157);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Miasto";
            // 
            // textBox_kodPocztowy
            // 
            textBox_kodPocztowy.Location = new Point(16, 113);
            textBox_kodPocztowy.Name = "textBox_kodPocztowy";
            textBox_kodPocztowy.Size = new Size(128, 23);
            textBox_kodPocztowy.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 94);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Kod pocztowy";
            // 
            // textBox_Ulica
            // 
            textBox_Ulica.Location = new Point(16, 44);
            textBox_Ulica.Name = "textBox_Ulica";
            textBox_Ulica.Size = new Size(297, 23);
            textBox_Ulica.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 25);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Ulica z numerem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 315);
            Controls.Add(groupBox2);
            Controls.Add(submitButton);
            Controls.Add(label_Price);
            Controls.Add(pictureBox1);
            Controls.Add(checkButton);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nadaj Przesyłkę. PESEL: xyz";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton_Paczka;
        private RadioButton radioButton_List;
        private RadioButton radioButton_Pocztowka;
        private Button checkButton;
        private PictureBox pictureBox1;
        private Label label_Price;
        private Button submitButton;
        private GroupBox groupBox2;
        private TextBox textBox_Miasto;
        private Label label4;
        private TextBox textBox_kodPocztowy;
        private Label label3;
        private TextBox textBox_Ulica;
        private Label label2;
    }
}