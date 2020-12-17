namespace WinFormsProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.회원 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.노래 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.주문 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxOSN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOSS = new System.Windows.Forms.ComboBox();
            this.textBoxOPA = new System.Windows.Forms.TextBox();
            this.comboBoxOST = new System.Windows.Forms.ComboBox();
            this.comboBoxOId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxST = new System.Windows.Forms.ComboBox();
            this.comboBoxSS = new System.Windows.Forms.ComboBox();
            this.comboBoxSP = new System.Windows.Forms.ComboBox();
            this.comboBoxSN = new System.Windows.Forms.ComboBox();
            this.textBoxSG = new System.Windows.Forms.TextBox();
            this.labelSG = new System.Windows.Forms.Label();
            this.labelSS = new System.Windows.Forms.Label();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelST = new System.Windows.Forms.Label();
            this.labelSN = new System.Windows.Forms.Label();
            this.S_btnSelect = new System.Windows.Forms.Button();
            this.O_btnSelect = new System.Windows.Forms.Button();
            this.S_btnInsert = new System.Windows.Forms.Button();
            this.O_btnInsert = new System.Windows.Forms.Button();
            this.S_btnClear = new System.Windows.Forms.Button();
            this.O_btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.회원.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.노래.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.주문.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(688, 519);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 35);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSelect.Location = new System.Drawing.Point(688, 460);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(115, 35);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "검색";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAge);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelAge);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.textBoxID);
            this.groupBox1.Controls.Add(this.labelId);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 436);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(665, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(469, 95);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(161, 30);
            this.comboBoxAge.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxName.Location = new System.Drawing.Point(163, 97);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 30);
            this.textBoxName.TabIndex = 12;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelAge.Location = new System.Drawing.Point(400, 100);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(63, 20);
            this.labelAge.TabIndex = 8;
            this.labelAge.Text = "나이 :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelName.Location = new System.Drawing.Point(81, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 20);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "이름 :";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxPass.Location = new System.Drawing.Point(469, 38);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(161, 30);
            this.textBoxPass.TabIndex = 5;
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPass.Location = new System.Drawing.Point(360, 41);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(103, 20);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "비밀번호 :";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxID.Location = new System.Drawing.Point(163, 37);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(161, 30);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelId.Location = new System.Drawing.Point(21, 41);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(123, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "회원아이디 :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.Location = new System.Drawing.Point(688, 585);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "비우기";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.회원);
            this.tabControl1.Controls.Add(this.노래);
            this.tabControl1.Controls.Add(this.주문);
            this.tabControl1.Location = new System.Drawing.Point(12, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 317);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // 회원
            // 
            this.회원.Controls.Add(this.dataGridView1);
            this.회원.Location = new System.Drawing.Point(4, 25);
            this.회원.Name = "회원";
            this.회원.Padding = new System.Windows.Forms.Padding(3);
            this.회원.Size = new System.Drawing.Size(766, 288);
            this.회원.TabIndex = 0;
            this.회원.Text = "회원";
            this.회원.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(760, 282);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // 노래
            // 
            this.노래.Controls.Add(this.dataGridView2);
            this.노래.Location = new System.Drawing.Point(4, 25);
            this.노래.Name = "노래";
            this.노래.Padding = new System.Windows.Forms.Padding(3);
            this.노래.Size = new System.Drawing.Size(766, 288);
            this.노래.TabIndex = 1;
            this.노래.Text = "노래";
            this.노래.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(760, 282);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // 주문
            // 
            this.주문.Controls.Add(this.dataGridView3);
            this.주문.Location = new System.Drawing.Point(4, 25);
            this.주문.Name = "주문";
            this.주문.Padding = new System.Windows.Forms.Padding(3);
            this.주문.Size = new System.Drawing.Size(766, 288);
            this.주문.TabIndex = 2;
            this.주문.Text = "주문";
            this.주문.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 27;
            this.dataGridView3.Size = new System.Drawing.Size(760, 282);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxOSN);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxOSS);
            this.groupBox3.Controls.Add(this.textBoxOPA);
            this.groupBox3.Controls.Add(this.comboBoxOST);
            this.groupBox3.Controls.Add(this.comboBoxOId);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox3.Location = new System.Drawing.Point(12, 436);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(665, 206);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "주문";
            this.groupBox3.Visible = false;
            // 
            // comboBoxOSN
            // 
            this.comboBoxOSN.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxOSN.FormattingEnabled = true;
            this.comboBoxOSN.Location = new System.Drawing.Point(163, 36);
            this.comboBoxOSN.Name = "comboBoxOSN";
            this.comboBoxOSN.Size = new System.Drawing.Size(161, 30);
            this.comboBoxOSN.TabIndex = 21;
            this.comboBoxOSN.SelectedIndexChanged += new System.EventHandler(this.comboBoxOSN_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(54, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "노래번호 :";
            // 
            // comboBoxOSS
            // 
            this.comboBoxOSS.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxOSS.FormattingEnabled = true;
            this.comboBoxOSS.Location = new System.Drawing.Point(469, 102);
            this.comboBoxOSS.Name = "comboBoxOSS";
            this.comboBoxOSS.Size = new System.Drawing.Size(161, 30);
            this.comboBoxOSS.TabIndex = 18;
            // 
            // textBoxOPA
            // 
            this.textBoxOPA.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxOPA.Location = new System.Drawing.Point(163, 162);
            this.textBoxOPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxOPA.Name = "textBoxOPA";
            this.textBoxOPA.Size = new System.Drawing.Size(161, 30);
            this.textBoxOPA.TabIndex = 17;
            this.textBoxOPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxOST
            // 
            this.comboBoxOST.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxOST.FormattingEnabled = true;
            this.comboBoxOST.Location = new System.Drawing.Point(163, 98);
            this.comboBoxOST.Name = "comboBoxOST";
            this.comboBoxOST.Size = new System.Drawing.Size(161, 30);
            this.comboBoxOST.TabIndex = 16;
            this.comboBoxOST.SelectedIndexChanged += new System.EventHandler(this.comboBoxOST_SelectedIndexChanged);
            // 
            // comboBoxOId
            // 
            this.comboBoxOId.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxOId.FormattingEnabled = true;
            this.comboBoxOId.Location = new System.Drawing.Point(469, 36);
            this.comboBoxOId.Name = "comboBoxOId";
            this.comboBoxOId.Size = new System.Drawing.Size(161, 30);
            this.comboBoxOId.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(54, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "구매수량 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(400, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "가수 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(340, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "회원아이디 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(54, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "노래제목 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxST);
            this.groupBox2.Controls.Add(this.comboBoxSS);
            this.groupBox2.Controls.Add(this.comboBoxSP);
            this.groupBox2.Controls.Add(this.comboBoxSN);
            this.groupBox2.Controls.Add(this.textBoxSG);
            this.groupBox2.Controls.Add(this.labelSG);
            this.groupBox2.Controls.Add(this.labelSS);
            this.groupBox2.Controls.Add(this.labelSP);
            this.groupBox2.Controls.Add(this.labelST);
            this.groupBox2.Controls.Add(this.labelSN);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 206);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "노래";
            this.groupBox2.Visible = false;
            // 
            // comboBoxST
            // 
            this.comboBoxST.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxST.FormattingEnabled = true;
            this.comboBoxST.Location = new System.Drawing.Point(469, 36);
            this.comboBoxST.Name = "comboBoxST";
            this.comboBoxST.Size = new System.Drawing.Size(161, 30);
            this.comboBoxST.TabIndex = 26;
            this.comboBoxST.SelectedIndexChanged += new System.EventHandler(this.comboBoxST_SelectedIndexChanged);
            // 
            // comboBoxSS
            // 
            this.comboBoxSS.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxSS.FormattingEnabled = true;
            this.comboBoxSS.Location = new System.Drawing.Point(163, 97);
            this.comboBoxSS.Name = "comboBoxSS";
            this.comboBoxSS.Size = new System.Drawing.Size(161, 30);
            this.comboBoxSS.TabIndex = 25;
            // 
            // comboBoxSP
            // 
            this.comboBoxSP.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxSP.FormattingEnabled = true;
            this.comboBoxSP.Location = new System.Drawing.Point(469, 97);
            this.comboBoxSP.Name = "comboBoxSP";
            this.comboBoxSP.Size = new System.Drawing.Size(161, 30);
            this.comboBoxSP.TabIndex = 24;
            // 
            // comboBoxSN
            // 
            this.comboBoxSN.Font = new System.Drawing.Font("굴림", 13F);
            this.comboBoxSN.FormattingEnabled = true;
            this.comboBoxSN.Location = new System.Drawing.Point(163, 36);
            this.comboBoxSN.Name = "comboBoxSN";
            this.comboBoxSN.Size = new System.Drawing.Size(161, 30);
            this.comboBoxSN.TabIndex = 15;
            this.comboBoxSN.SelectedIndexChanged += new System.EventHandler(this.comboBoxSN_SelectedIndexChanged);
            // 
            // textBoxSG
            // 
            this.textBoxSG.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxSG.Location = new System.Drawing.Point(163, 162);
            this.textBoxSG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSG.Name = "textBoxSG";
            this.textBoxSG.Size = new System.Drawing.Size(161, 30);
            this.textBoxSG.TabIndex = 22;
            this.textBoxSG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSG
            // 
            this.labelSG.AutoSize = true;
            this.labelSG.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSG.Location = new System.Drawing.Point(61, 165);
            this.labelSG.Name = "labelSG";
            this.labelSG.Size = new System.Drawing.Size(63, 20);
            this.labelSG.TabIndex = 20;
            this.labelSG.Text = "장르 :";
            // 
            // labelSS
            // 
            this.labelSS.AutoSize = true;
            this.labelSS.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSS.Location = new System.Drawing.Point(61, 102);
            this.labelSS.Name = "labelSS";
            this.labelSS.Size = new System.Drawing.Size(63, 20);
            this.labelSS.TabIndex = 18;
            this.labelSS.Text = "가수 :";
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSP.Location = new System.Drawing.Point(400, 100);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(63, 20);
            this.labelSP.TabIndex = 17;
            this.labelSP.Text = "단가 :";
            // 
            // labelST
            // 
            this.labelST.AutoSize = true;
            this.labelST.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelST.Location = new System.Drawing.Point(400, 41);
            this.labelST.Name = "labelST";
            this.labelST.Size = new System.Drawing.Size(63, 20);
            this.labelST.TabIndex = 16;
            this.labelST.Text = "제목 :";
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelSN.Location = new System.Drawing.Point(21, 41);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(103, 20);
            this.labelSN.TabIndex = 15;
            this.labelSN.Text = "노래번호 :";
            // 
            // S_btnSelect
            // 
            this.S_btnSelect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_btnSelect.Location = new System.Drawing.Point(688, 460);
            this.S_btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.S_btnSelect.Name = "S_btnSelect";
            this.S_btnSelect.Size = new System.Drawing.Size(115, 35);
            this.S_btnSelect.TabIndex = 16;
            this.S_btnSelect.Text = "검색";
            this.S_btnSelect.UseVisualStyleBackColor = true;
            this.S_btnSelect.Visible = false;
            this.S_btnSelect.Click += new System.EventHandler(this.S_btnSelect_Click);
            // 
            // O_btnSelect
            // 
            this.O_btnSelect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.O_btnSelect.Location = new System.Drawing.Point(688, 460);
            this.O_btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.O_btnSelect.Name = "O_btnSelect";
            this.O_btnSelect.Size = new System.Drawing.Size(115, 35);
            this.O_btnSelect.TabIndex = 17;
            this.O_btnSelect.Text = "검색";
            this.O_btnSelect.UseVisualStyleBackColor = true;
            this.O_btnSelect.Visible = false;
            this.O_btnSelect.Click += new System.EventHandler(this.O_btnSelect_Click);
            // 
            // S_btnInsert
            // 
            this.S_btnInsert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_btnInsert.Location = new System.Drawing.Point(688, 519);
            this.S_btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.S_btnInsert.Name = "S_btnInsert";
            this.S_btnInsert.Size = new System.Drawing.Size(115, 35);
            this.S_btnInsert.TabIndex = 18;
            this.S_btnInsert.Text = "입력";
            this.S_btnInsert.UseVisualStyleBackColor = true;
            this.S_btnInsert.Visible = false;
            this.S_btnInsert.Click += new System.EventHandler(this.S_btnInsert_Click);
            // 
            // O_btnInsert
            // 
            this.O_btnInsert.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.O_btnInsert.Location = new System.Drawing.Point(688, 519);
            this.O_btnInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.O_btnInsert.Name = "O_btnInsert";
            this.O_btnInsert.Size = new System.Drawing.Size(115, 35);
            this.O_btnInsert.TabIndex = 19;
            this.O_btnInsert.Text = "입력";
            this.O_btnInsert.UseVisualStyleBackColor = true;
            this.O_btnInsert.Visible = false;
            this.O_btnInsert.Click += new System.EventHandler(this.O_btnInsert_Click);
            // 
            // S_btnClear
            // 
            this.S_btnClear.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.S_btnClear.Location = new System.Drawing.Point(688, 584);
            this.S_btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.S_btnClear.Name = "S_btnClear";
            this.S_btnClear.Size = new System.Drawing.Size(115, 35);
            this.S_btnClear.TabIndex = 20;
            this.S_btnClear.Text = "비우기";
            this.S_btnClear.UseVisualStyleBackColor = true;
            this.S_btnClear.Visible = false;
            this.S_btnClear.Click += new System.EventHandler(this.S_btnClear_Click);
            // 
            // O_btnClear
            // 
            this.O_btnClear.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.O_btnClear.Location = new System.Drawing.Point(688, 584);
            this.O_btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.O_btnClear.Name = "O_btnClear";
            this.O_btnClear.Size = new System.Drawing.Size(115, 35);
            this.O_btnClear.TabIndex = 21;
            this.O_btnClear.Text = "비우기";
            this.O_btnClear.UseVisualStyleBackColor = true;
            this.O_btnClear.Visible = false;
            this.O_btnClear.Click += new System.EventHandler(this.O_btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림체", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(310, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 43);
            this.label6.TabIndex = 22;
            this.label6.Text = "노래관리";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.O_btnClear);
            this.Controls.Add(this.S_btnClear);
            this.Controls.Add(this.O_btnInsert);
            this.Controls.Add(this.S_btnInsert);
            this.Controls.Add(this.O_btnSelect);
            this.Controls.Add(this.S_btnSelect);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnInsert);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "노래 관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.회원.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.노래.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.주문.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage 회원;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage 노래;
        private System.Windows.Forms.TabPage 주문;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSP;
        private System.Windows.Forms.ComboBox comboBoxSN;
        private System.Windows.Forms.TextBox textBoxSG;
        private System.Windows.Forms.Label labelSG;
        private System.Windows.Forms.Label labelSS;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelST;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxOST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOId;
        private System.Windows.Forms.Button S_btnSelect;
        private System.Windows.Forms.Button O_btnSelect;
        private System.Windows.Forms.Button S_btnInsert;
        private System.Windows.Forms.Button O_btnInsert;
        private System.Windows.Forms.Button S_btnClear;
        private System.Windows.Forms.Button O_btnClear;
        private System.Windows.Forms.TextBox textBoxOPA;
        private System.Windows.Forms.ComboBox comboBoxOSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOSN;
        private System.Windows.Forms.ComboBox comboBoxST;
        private System.Windows.Forms.ComboBox comboBoxSS;
    }
}

