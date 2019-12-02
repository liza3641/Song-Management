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
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=song;uid=root;pwd=*a91001120";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 회원", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "회원");
            dataGridView1.DataSource = dataSet.Tables["회원"];

            Age_setComboBox();
        }

       

        // **** SELECT 버튼 클릭 ****

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["회원"])
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM 회원", conn);
                dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "회원");
                dataGridView1.DataSource = dataSet.Tables["회원"];

                

                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                btnSelect.Visible = true;
                S_btnSelect.Visible = false;
                O_btnSelect.Visible = false;
                btnInsert.Visible = true;
                S_btnInsert.Visible = false;
                O_btnInsert.Visible = false;
                btnClear.Visible = true;
                S_btnClear.Visible = false;
                O_btnClear.Visible = false;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["노래"])
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM 노래", conn);
                dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "노래");
                dataGridView2.DataSource = dataSet.Tables["노래"];

                comboBoxSN.Items.Clear();
                comboBoxST.Items.Clear();
                S_SetSearchComboBox();
                P_setComboBox();

                groupBox1.Visible = false;
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                btnSelect.Visible = false;
                S_btnSelect.Visible = true;
                O_btnSelect.Visible = false;
                btnInsert.Visible = false;
                S_btnInsert.Visible = true;
                O_btnInsert.Visible = false;
                btnClear.Visible = false;
                S_btnClear.Visible = true;
                O_btnClear.Visible = false;
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["주문"])
            {
                dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
                dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "주문");
                dataGridView3.DataSource = dataSet.Tables["주문"];

                comboBoxOSN.Items.Clear();
                comboBoxOST.Items.Clear();
                O_SetSearchComboBox();

                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                btnSelect.Visible = false;
                S_btnSelect.Visible = false;
                O_btnSelect.Visible = true;
                btnInsert.Visible = false;
                S_btnInsert.Visible = false;
                O_btnInsert.Visible = true;
                btnClear.Visible = false;
                S_btnClear.Visible = false;
                O_btnClear.Visible = true;
            }
        }


        #region 회원 테이블
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[4];
            conditions[0] = (textBoxID.Text != "") ? "회원아이디=@회원아이디" : null;
            conditions[1] = (textBoxPass.Text != "") ? "비밀번호=@비밀번호" : null;
            conditions[2] = (textBoxName.Text != "") ? "이름=@이름" : null;
            conditions[3] = (comboBoxAge.Text != "") ? "나이=@나이" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null)
            {
                queryStr = $"SELECT * FROM 회원 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 회원";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@회원아이디", textBoxID.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@비밀번호", textBoxPass.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@이름", textBoxName.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@나이", comboBoxAge.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "회원") > 0)
                    dataGridView1.DataSource = dataSet.Tables["회원"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
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

        // **** DataGridView에서 행을 선택하면 새창을 띄움 ****
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

            // 새로운 폼에 선택된 row의 정보를 담아서 생성
            Form2 Dig = new Form2(
                selectedRowIndex,
                row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                Int32.Parse(row.Cells[3].Value.ToString())
                );

            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // **** Insert SQL 실행 ****
        public void InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 회원 (회원아이디, 비밀번호, 이름, 나이) " +
                "VALUES(@회원아이디, @비밀번호, @이름, @나이)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@회원아이디", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@비밀번호", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@이름", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@나이", MySqlDbType.Int32);

            #region Parameter를 이용한 처리

            dataAdapter.InsertCommand.Parameters["@회원아이디"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@비밀번호"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@이름"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@나이"].Value = rowDatas[3];


            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "회원");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["회원"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기

                
            }
            catch (Exception)
            {
                MessageBox.Show("이미 존재하는 회원아이디입니다.");
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        // **** Delete SQL 실행 ****
        internal void DeleteRow(string 회원아이디)
        {
            string sql = "DELETE FROM 회원 WHERE 회원아이디=@회원아이디";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@회원아이디", 회원아이디);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "회원");
                dataGridView1.DataSource = dataSet.Tables["회원"];
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

        // **** Update SQL 실행 ****
        internal void UpdateRow(string[] rowDatas)
        {

            string sql = "UPDATE 회원 SET 비밀번호=@비밀번호, 이름=@이름, 나이=@나이 WHERE 회원아이디=@회원아이디";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@회원아이디", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@비밀번호", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@이름", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@나이", rowDatas[3]);
            

            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "회원");
                dataGridView1.DataSource = dataSet.Tables["회원"];
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

        // **** Insert 버튼 클릭(새창 띄우기) ****
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // 검색 조건 초기화 함수
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxPass.Clear();
            textBoxName.Clear();
            comboBoxAge.Text = "";
        }

        private void Age_setComboBox()
        {
            for (int i = 1; i <= 100; i++)
            {
                comboBoxAge.Items.Add(i);
            }
        }
        #endregion

        #region 노래 테이블
        private void P_setComboBox()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxSP.Items.Add(i * 1000);
            }
        }

        // 검색조건에서 특정 제목을 선택하면 해당 노래의 가수를 채움.
        private void S_SetSearchComboBox()
        {
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
        private void S_btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[5];
            conditions[0] = (comboBoxSN.Text != "") ? "노래번호=@노래번호" : null;
            conditions[1] = (comboBoxST.Text != "") ? "제목=@제목" : null;
            conditions[2] = (comboBoxSS.Text != "") ? "가수=@가수" : null;
            conditions[3] = (comboBoxSP.Text != "") ? "단가=@단가" : null;
            conditions[4] = (textBoxSG.Text != "") ? "장르=@장르" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null ||
                conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM 노래 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 노래";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@노래번호", comboBoxSN.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@제목", comboBoxST.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@가수", comboBoxSS.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@단가", comboBoxSP.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@장르", textBoxSG.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "노래") > 0)
                    dataGridView1.DataSource = dataSet.Tables["노래"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
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

        // **** DataGridView에서 행을 선택하면 새창을 띄움 ****      !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[selectedRowIndex];
            try
            {
                // 새로운 폼에 선택된 row의 정보를 담아서 생성
                Form3 Dig = new Form3(
                    selectedRowIndex,
                    Int32.Parse(row.Cells[0].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    Int32.Parse(row.Cells[3].Value.ToString()),
                    row.Cells[4].Value.ToString()
                    );

                Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
                Dig.ShowDialog();               // 폼 띄우기(Modal)
                Dig.Dispose();
            }
            catch (Exception)
            {
            }
        }

        // **** Insert SQL 실행 ****
        public void S_InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 노래 (노래번호, 제목, 가수, 단가, 장르) " +
                "VALUES(@노래번호, @제목, @가수, @단가, @장르)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@노래번호", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@제목", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@가수", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@단가", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@장르", MySqlDbType.VarChar);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@노래번호"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@제목"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@가수"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@단가"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@장르"].Value = rowDatas[4];

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "노래");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["노래"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기


            }
            catch (Exception)
            {
                MessageBox.Show("이미 존재하는 노래번호입니다.");
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        // **** Delete SQL 실행 ****
        internal void S_DeleteRow(int 노래번호)
        {
            string sql = "DELETE FROM 노래 WHERE 노래번호=@노래번호";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@노래번호", 노래번호);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "노래");
                dataGridView1.DataSource = dataSet.Tables["노래"];
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

        // **** Update SQL 실행 ****
        internal void S_UpdateRow(string[] rowDatas)
        {

            string sql = "UPDATE 노래 SET 제목=@제목, 가수=@가수, 단가=@단가, 장르=@장르 WHERE 노래번호=@노래번호";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@노래번호", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@제목", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@가수", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@단가", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@장르", rowDatas[4]);


            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "노래");
                dataGridView1.DataSource = dataSet.Tables["노래"];
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

        // **** Insert 버튼 클릭(새창 띄우기) ****
        private void S_btnInsert_Click(object sender, EventArgs e)
        {
            Form3 Dig = new Form3();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // 검색 조건 초기화 함수
        private void S_btnClear_Click(object sender, EventArgs e)
        {
            comboBoxSN.Text = "";
            comboBoxST.Text = "";
            comboBoxSS.Text = "";
            comboBoxSP.Text = "";
            textBoxSG.Clear();
        }










        #endregion

        #region 주문 테이블
        #region ComboBox 세팅
        // **** 검색 조건 목록 세팅 ****
        private void O_SetSearchComboBox()
        {
            string sql = "SELECT distinct 회원아이디 FROM 회원";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // 회원아이디 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                comboBoxOId.Items.Clear();

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
            #endregion

            private void O_btnSelect_Click(object sender, EventArgs e)
        {
            string queryStr;

            #region Select QueryString 만들기
            string[] conditions = new string[5];
            conditions[0] = (comboBoxOSN.Text != "") ? "노래번호=@노래번호" : null;
            conditions[1] = (comboBoxOId.Text != "") ? "회원아이디=@회원아이디" : null;
            conditions[2] = (comboBoxOST.Text != "") ? "노래제목=@노래제목" : null;
            conditions[3] = (comboBoxOSS.Text != "") ? "가수=@가수" : null;
            conditions[4] = (textBoxOPA.Text != "") ? "구매수량=@구매수량" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM 주문 WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM 주문";
            }
            #endregion

            #region SelectCommand 객체 생성 및 Parameters 설정
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@노래번호", comboBoxOSN.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@회원아이디", comboBoxOId.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@노래제목", comboBoxOST.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@가수", comboBoxOSS.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@구매수량", textBoxOPA.Text);
            #endregion

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "주문") > 0)
                    dataGridView1.DataSource = dataSet.Tables["주문"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
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

        // **** DataGridView에서 행을 선택하면 새창을 띄움 ****
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView3.Rows[selectedRowIndex];

                // 새로운 폼에 선택된 row의 정보를 담아서 생성
                Form4 Dig = new Form4(
                    selectedRowIndex,
                    Int32.Parse(row.Cells[0].Value.ToString()),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    Int32.Parse(row.Cells[4].Value.ToString())
                    );

                Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
                Dig.ShowDialog();               // 폼 띄우기(Modal)
                Dig.Dispose();
            }
            catch (Exception)
            {
            }
            
        }

        // **** Insert SQL 실행 ****
        public void O_InsertRow(string[] rowDatas)
        {
            string queryStr = "INSERT INTO 주문 (노래번호, 회원아이디, 노래제목, 가수, 구매수량) " +
                "VALUES(@노래번호, @회원아이디, @노래제목, @가수, @구매수량)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@노래번호", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@회원아이디", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@노래제목", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@가수", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@구매수량", MySqlDbType.Int32);

            #region Parameter를 이용한 처리
            dataAdapter.InsertCommand.Parameters["@노래번호"].Value = rowDatas[0];
            dataAdapter.InsertCommand.Parameters["@회원아이디"].Value = rowDatas[1];
            dataAdapter.InsertCommand.Parameters["@노래제목"].Value = rowDatas[2];
            dataAdapter.InsertCommand.Parameters["@가수"].Value = rowDatas[3];
            dataAdapter.InsertCommand.Parameters["@구매수량"].Value = rowDatas[4];


            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();                                        // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "주문");                      // DB -> DataSet
                dataGridView1.DataSource = dataSet.Tables["주문"];      // dataGridView에 테이블 표시                                     // 텍스트 박스 내용 지우기


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion
        }

        // **** Delete SQL 실행 ****
        internal void O_DeleteRow(int 노래번호, string 회원아이디)
        {
            string sql = "DELETE FROM 주문 WHERE 노래번호=@노래번호 and 회원아이디=@회원아이디";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@노래번호", 노래번호);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@회원아이디", 회원아이디);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
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

        // **** Update SQL 실행 ****
        internal void O_UpdateRow(string[] rowDatas)
        {

            string sql = "UPDATE 주문 SET 노래제목=@노래제목, 가수=@가수, 구매수량=@구매수량 WHERE 노래번호=@노래번호 and 회원아이디=@회원아이디";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@노래번호", rowDatas[0]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@회원아이디", rowDatas[1]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@노래제목", rowDatas[2]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@가수", rowDatas[3]);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@구매수량", rowDatas[4]);


            try
            {
                conn.Open();
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 이전 데이터 지우기
                dataAdapter.Fill(dataSet, "주문");
                dataGridView1.DataSource = dataSet.Tables["주문"];
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

        // **** Insert 버튼 클릭(새창 띄우기) ****
        private void O_btnInsert_Click(object sender, EventArgs e)
        {
            Form4 Dig = new Form4();
            Dig.Owner = this;               // 새로운 폼의 부모가 Form1 인스턴스임을 지정
            Dig.ShowDialog();               // 폼 띄우기(Modal)
            Dig.Dispose();
        }

        // 검색 조건 초기화 함수
        private void O_btnClear_Click(object sender, EventArgs e)
        {
            comboBoxOSN.Text = "";
            comboBoxOId.Text = "";
            comboBoxOST.Text = "";
            comboBoxOSS.Text = "";
            textBoxOPA.Clear();
        }



        #endregion

       
    }
}