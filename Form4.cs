using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        MySqlConnection conn;
        private int SN;
        private string ID;
        private string ST;
        private string SS;
        private int PA;
        private int selectedRowIndex;

        public Form4()
        {
            InitializeComponent();
        }

        public Form4(int selectedRowIndex, int v1, string v2, string v3, string v4, int v5)
        {
            InitializeComponent();
            this.selectedRowIndex = selectedRowIndex;
            this.SN = v1;
            this.ID = v2;
            this.ST = v3;
            this.SS = v4;
            this.PA = v5;

        }

        Form1 mainForm;
        private void Form4_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=song;uid=root;pwd=*a91001120";
            conn = new MySqlConnection(connStr);
            SetSearchComboBox();

            if (SN.ToString() != "0") comboBoxOSN.Text = SN.ToString();
            comboBoxOId.Text = ID;
            comboBoxOST.Text = ST;
            comboBoxOSS.Text = SS;
            if (PA.ToString() != "0") textBoxOPA.Text = PA.ToString();

            if (Owner != null)
            {
                mainForm = Owner as Form1;
            }

        }

        private void O_btnInsert_Click(object sender, EventArgs e)
        {

            if (comboBoxOSN.Text == "" || comboBoxOId.Text == "" || comboBoxOST.Text == "" || comboBoxOSS.Text == "" || textBoxOPA.Text == "")
            {
                MessageBox.Show("주문번호, 회원아이디, 노래제목, 가수, 구매수량를 전부 입력하세요.");
            }
            //else if (ID != textBoxOON.Text)
            //{
            //    MessageBox.Show("주문번호는 변경하실수없습니다");
            //}
            else
            {
                string[] rowDatas = {
                comboBoxOSN.Text,
                comboBoxOId.Text,
                comboBoxOST.Text,
                comboBoxOSS.Text,
                textBoxOPA.Text };
                mainForm.O_InsertRow(rowDatas);
                this.Close();
            }

        }

        private void O_btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID != comboBoxOId.Text)
            {
                MessageBox.Show("회원아이디는 변경 하실 수 없습니다");
                this.Close();
            }
            else if(ReferenceEquals(SN, comboBoxOSN.Text) != true)
            { 
                MessageBox.Show("신청하신 노래는 변경 하실 수 없습니다");
                this.Close();
            }
            else
            {
                string[] rowDatas = {
                comboBoxOSN.Text,
                comboBoxOId.Text,
                comboBoxOST.Text,
                comboBoxOSS.Text,
                textBoxOPA.Text  };
                mainForm.O_UpdateRow(rowDatas);
                this.Close();
            }


        }

        private void O_btnDelete_Click(object sender, EventArgs e)
        {
            mainForm.O_DeleteRow(SN, ID);
            this.Close();
        }

        private void btnTextBoxClear_Click(object sender, EventArgs e)
        {
            comboBoxOSN.Text = "";
            comboBoxOId.Text = "";
            comboBoxOST.Text = "";
            comboBoxOSS.Text = "";
            textBoxOPA.Clear();
        }

        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct 회원아이디 FROM 회원";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // 회원아이디 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxOId.Items.Add(reader.GetString("회원아이디"));
                }
                reader.Close();

                // 제목 목록 표시
                sql = "SELECT distinct 제목 FROM 노래";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxOST.Items.Add(reader.GetString("제목"));
                }
                reader.Close();

                // 노래번호 목록 표시
                sql = "SELECT distinct 노래번호 FROM 노래";
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxOSN.Items.Add(reader.GetString("노래번호"));
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

        // 검색조건에서 특정 제목을 선택하면 해당 노래의 가수를 채움.

        private void comboBoxOST_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT distinct 가수 FROM 노래 WHERE 제목=@제목";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@제목", comboBoxOST.Text);

            comboBoxOSS.Items.Clear();        // ComboBox 데이터 초기화

            try
            {
                // 가수 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxOSS.Items.Add(reader.GetString("가수"));
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

        private void comboBoxOSN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT distinct 제목 FROM 노래 WHERE 노래번호=@노래번호";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@노래번호", comboBoxOSN.Text);

            comboBoxOST.Items.Clear();        // ComboBox 데이터 초기화

            try
            {
                // 가수 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    comboBoxOST.Text = reader.GetString("제목");
                }
                reader.Close();

                sql = "SELECT distinct 가수 FROM 노래 WHERE 노래번호=@노래번호";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@노래번호", comboBoxOSN.Text);

                comboBoxOSS.Items.Clear();        // ComboBox 데이터 초기화

                try
                {
                    // 가수 목록 표시
                    reader = cmd.ExecuteReader();
                    while (reader.Read())  // 다음 레코드가 있으면 true
                    {
                        comboBoxOSS.Text = reader.GetString("가수");
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
