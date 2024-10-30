using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string language;

        public Form1()
        {
            InitializeComponent();
        }

        private void TBar_Num_Scroll(object sender, ScrollEventArgs e)
        {
            lb_num.Text = TBar_Num.Value.ToString();
        }
        
        private void TBar_Num_ValueChanged(object sender, ScrollEventArgs e)
        {
            lb_num.Text = TBar_Num.Value.ToString();
        }

        private void Btn_CreateNum_Click(object sender, EventArgs e)
        {
            string characters = "abcdefghijklmnopqrstuvwxyz0123456789";
            
            if (Cb_BigEn.Checked)
            {
                characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (Cb_Special.Checked)
            {
                characters += "!@#$%^&*()-+=_~`/><?|\\";
            }

            int length = TBar_Num.Value;
            Random random = new Random();
            char[] randomString = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomString[i] = characters[random.Next(characters.Length)];
            }

            Tb_CreatedNum.Text = new string(randomString);

            if (language == "Kr")
            {
                MessageBox.Show(new string(randomString), "랜덤 비번 생성기!");
            }
            
            if (language == "En")
            {
                MessageBox.Show(new string(randomString), "Random Password Creator");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult start = MessageBox.Show("YES를 누르면 한국어, NO for En", "랜덤 비번 생성기 (Random Password Creator)", MessageBoxButtons.YesNo);

            if (start == DialogResult.Yes)
            {
                MessageBox.Show("한국어가 선택되었습니다.");

                Cb_Special.Text = "특수문자 포함";
                Cb_BigEn.Text = "대문자 포함";

                language = "Kr";
                Btn_CreateNum.Text = "생성";
            }
            else if (start == DialogResult.No)
            {
                MessageBox.Show("English has been selected.");

                Cb_Special.Text = "include special characters";
                Cb_BigEn.Text = "include uppercase letters";

                language = "En";
                Btn_CreateNum.Text = "Create";
            }
        }
    }
}
