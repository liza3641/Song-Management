﻿namespace WinFormsProject
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxOSN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxOSS = new System.Windows.Forms.ComboBox();
            this.comboBoxOST = new System.Windows.Forms.ComboBox();
            this.textBoxOPA = new System.Windows.Forms.TextBox();
            this.comboBoxOId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTextBoxClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxOSN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxOSS);
            this.panel1.Controls.Add(this.comboBoxOST);
            this.panel1.Controls.Add(this.textBoxOPA);
            this.panel1.Controls.Add(this.comboBoxOId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 176);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxOSN
            // 
            this.comboBoxOSN.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBoxOSN.FormattingEnabled = true;
            this.comboBoxOSN.Location = new System.Drawing.Point(106, 14);
            this.comboBoxOSN.Name = "comboBoxOSN";
            this.comboBoxOSN.Size = new System.Drawing.Size(213, 25);
            this.comboBoxOSN.TabIndex = 13;
            this.comboBoxOSN.SelectedIndexChanged += new System.EventHandler(this.comboBoxOSN_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "노래번호 : ";
            // 
            // comboBoxOSS
            // 
            this.comboBoxOSS.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBoxOSS.FormattingEnabled = true;
            this.comboBoxOSS.Location = new System.Drawing.Point(106, 108);
            this.comboBoxOSS.Name = "comboBoxOSS";
            this.comboBoxOSS.Size = new System.Drawing.Size(213, 25);
            this.comboBoxOSS.TabIndex = 11;
            // 
            // comboBoxOST
            // 
            this.comboBoxOST.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBoxOST.FormattingEnabled = true;
            this.comboBoxOST.Location = new System.Drawing.Point(106, 77);
            this.comboBoxOST.Name = "comboBoxOST";
            this.comboBoxOST.Size = new System.Drawing.Size(213, 25);
            this.comboBoxOST.TabIndex = 10;
            this.comboBoxOST.SelectedIndexChanged += new System.EventHandler(this.comboBoxOST_SelectedIndexChanged);
            // 
            // textBoxOPA
            // 
            this.textBoxOPA.Location = new System.Drawing.Point(106, 140);
            this.textBoxOPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOPA.Name = "textBoxOPA";
            this.textBoxOPA.Size = new System.Drawing.Size(213, 25);
            this.textBoxOPA.TabIndex = 9;
            // 
            // comboBoxOId
            // 
            this.comboBoxOId.Font = new System.Drawing.Font("굴림", 10F);
            this.comboBoxOId.FormattingEnabled = true;
            this.comboBoxOId.Location = new System.Drawing.Point(106, 46);
            this.comboBoxOId.Name = "comboBoxOId";
            this.comboBoxOId.Size = new System.Drawing.Size(213, 25);
            this.comboBoxOId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "구매수량 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "가수 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "노래제목 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원아이디 : ";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(362, 44);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(214, 32);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.O_btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(362, 90);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(214, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.O_btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(362, 136);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.O_btnDelete_Click);
            // 
            // btnTextBoxClear
            // 
            this.btnTextBoxClear.Location = new System.Drawing.Point(362, 184);
            this.btnTextBoxClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTextBoxClear.Name = "btnTextBoxClear";
            this.btnTextBoxClear.Size = new System.Drawing.Size(214, 32);
            this.btnTextBoxClear.TabIndex = 6;
            this.btnTextBoxClear.Text = "내용 지우기";
            this.btnTextBoxClear.UseVisualStyleBackColor = true;
            this.btnTextBoxClear.Click += new System.EventHandler(this.btnTextBoxClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(243, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "주문 관리";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 231);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTextBoxClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTextBoxClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOId;
        private System.Windows.Forms.ComboBox comboBoxOST;
        private System.Windows.Forms.TextBox textBoxOPA;
        private System.Windows.Forms.ComboBox comboBoxOSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOSN;
    }
}
