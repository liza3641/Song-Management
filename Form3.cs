using System;
using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        private int SN;
        private string ST;
        private string SS;
        private int SP;
        private string SG;
        private int selectedRowIndex;
        MySqlConnection conn;

        

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(int selectedRowIndex, int v1, string v2, string v3, int v4, string v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.SN = v1;
            this.ST = v2;
            this.SS = v3;
            this.SP = v4;
            this.SG = v5;

        }

        Form1 mainForm;
        private void Form3_Load(object sender, EventArgs e)
        {
            if (SN.ToString() != "0") comboBoxSN.Text = SN.ToString();
            comboBoxST.Text = ST;
            comboBoxSS.Text = SS;
            if (SP.ToString() != "0") comboBoxSP.Text = SP.ToString();
            textBoxSG.Text = SG;

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }
            setComboBox();
            SetSearchComboBox();

            string connStr = "server=localhost;port=3306;database=song;uid=root;pwd=*a91001120";
            conn = new MySqlConnection(connStr);

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (comboBoxSN.Text == "" || comboBoxST.Text == "" || comboBoxSS.Text == "" || comboBoxSP.Text == "")
            {
                MessageBox.Show("노래번호, 제목, 가수, 단가를 반드시 입력해주세요.");
            }
            else
            {
                string[] rowDatas = {
                comboBoxSN.Text,
                comboBoxST.Text,
                comboBoxSS.Text,
                comboBoxSP.Text,
                textBoxSG.Text};
                mainForm.S_InsertRow(rowDatas);
                this.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SN != Int32.Parse(comboBoxSN.Text))
            {
                MessageBox.Show("노래번호는 변경하실수없습니다");


            }
            else if (comboBoxST.Text == "" || comboBoxSS.Text == "" || comboBoxSP.Text == "")
            {

                MessageBox.Show("제목, 가수, 단가를 전부 입력하세요.");

            }
            else
            {
                string[] rowDatas = {
                comboBoxSN.Text,
                comboBoxST.Text,
                comboBoxSS.Text,
                comboBoxSP.Text,
                textBoxSG.Text};
                mainForm.S_UpdateRow(rowDatas);
                this.Close();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mainForm.S_DeleteRow(SN);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            comboBoxSN.Text = "";
            comboBoxST.Text = "";
            comboBoxSS.Text = "";
            comboBoxSP.Text = "";
            textBoxSG.Clear();
        }
        private void setComboBox()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxSP.Items.Add(i*1000);
            }
        }

        // 검색조건에서 특정 제목을 선택하면 해당 노래의 가수를 채움.
        private void SetSearchComboBox()
        {

            string connStr = "server=localhost;port=3306;database=song;uid=root;pwd=*a91001120";
            MySqlConnection conn = new MySqlConnection(connStr);
            string sql = "SELECT distinct 제목 FROM 노래";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                // 제목 목록 표시
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxST.Items.Add(reader.GetString("제목"));
                }
                reader.Close();

                // 노래번호 목록 표시
                sql = "SELECT distinct 노래번호 FROM 노래";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxSN.Items.Add(reader.GetString("노래번호"));
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void comboBoxST_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT distinct 가수 FROM 노래 WHERE 제목=@제목";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@제목", comboBoxST.Text);

            comboBoxSS.Items.Clear();        // ComboBox 데이터 초기화

            try
            {
                // 가수 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxSS.Items.Add(reader.GetString("가수"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void comboBoxSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT distinct 제목 FROM 노래 WHERE 노래번호=@노래번호";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@노래번호", comboBoxSN.Text);

            comboBoxST.Items.Clear();        // ComboBox 데이터 초기화

            try
            {
                // 가수 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxST.Text = reader.GetString("제목");
                }
                reader.Close();

                sql = "SELECT distinct 가수 FROM 노래 WHERE 노래번호=@노래번호";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@노래번호", comboBoxSN.Text);

                comboBoxSS.Items.Clear();        // ComboBox 데이터 초기화

                try
                {
                    // 가수 목록 표시
                    reader = cmd.ExecuteReader();
                    while (reader.Read())  // 다음 레코드가 있으면 true
                    {
                        comboBoxSS.Text = reader.GetString("가수");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
