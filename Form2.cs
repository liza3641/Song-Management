using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject
{
    public partial class Form2 : Form
    {
        private string id;
        private string pass;
        private string name;
        private int age;
        private int selectedRowIndex;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int selectedRowIndex, string v1, string v2, string v3, int v4)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.id = v1;
            this.pass = v2;
            this.name = v3;
            this.age = v4;

        }

        Form1 mainForm;
        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxId.Text = id;
            textBoxPass.Text = pass;
            textBoxName.Text = name;
            if (age.ToString() != "0") comboBoxAge.Text = age.ToString();

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }
            setComboBox();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "" || textBoxPass.Text == "" || textBoxName.Text == "" || comboBoxAge.Text == "")
            {
                MessageBox.Show("회원아이디, 비밀번호, 이름, 나이를 전부 입력하세요.");
            }
            else
            {
                string[] rowDatas = {
                textBoxId.Text,
                textBoxPass.Text,
                textBoxName.Text,
                comboBoxAge.Text };
                mainForm.InsertRow(rowDatas);
                this.Close();
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id != textBoxId.Text)
            {
                MessageBox.Show("회원아이디는 변경하실수없습니다");


            }
            else if (textBoxPass.Text == "" || textBoxName.Text == "" || comboBoxAge.Text == "")
            {

                MessageBox.Show("비밀번호, 이름, 나이를 전부 입력하세요.");

            }
            else
            {
                string[] rowDatas = {
                    textBoxId.Text,
                    textBoxPass.Text,
                    textBoxName.Text,
                    comboBoxAge.Text };
                mainForm.UpdateRow(rowDatas);
                this.Close();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainForm.DeleteRow(id);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            textBoxId.Clear();
            textBoxPass.Clear();
            textBoxName.Clear();
            comboBoxAge.Text = "";
        }
        private void setComboBox()
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBoxAge.Items.Add(i);
            }
        }
    }
}
