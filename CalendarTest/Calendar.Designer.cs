using System;

namespace CalendarTest
{
    partial class Calendar
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
            this.SearchMonth = new System.Windows.Forms.ComboBox();
            this.SearchYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sun = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.day38 = new System.Windows.Forms.Label();
            this.day37 = new System.Windows.Forms.Label();
            this.day36 = new System.Windows.Forms.Label();
            this.day39 = new System.Windows.Forms.Label();
            this.day42 = new System.Windows.Forms.Label();
            this.day30 = new System.Windows.Forms.Label();
            this.day40 = new System.Windows.Forms.Label();
            this.day31 = new System.Windows.Forms.Label();
            this.day29 = new System.Windows.Forms.Label();
            this.day41 = new System.Windows.Forms.Label();
            this.day32 = new System.Windows.Forms.Label();
            this.day34 = new System.Windows.Forms.Label();
            this.day24 = new System.Windows.Forms.Label();
            this.day33 = new System.Windows.Forms.Label();
            this.day25 = new System.Windows.Forms.Label();
            this.day22 = new System.Windows.Forms.Label();
            this.day35 = new System.Windows.Forms.Label();
            this.day28 = new System.Windows.Forms.Label();
            this.day26 = new System.Windows.Forms.Label();
            this.day21 = new System.Windows.Forms.Label();
            this.day17 = new System.Windows.Forms.Label();
            this.day16 = new System.Windows.Forms.Label();
            this.day15 = new System.Windows.Forms.Label();
            this.day27 = new System.Windows.Forms.Label();
            this.day20 = new System.Windows.Forms.Label();
            this.day23 = new System.Windows.Forms.Label();
            this.day10 = new System.Windows.Forms.Label();
            this.day11 = new System.Windows.Forms.Label();
            this.day9 = new System.Windows.Forms.Label();
            this.day8 = new System.Windows.Forms.Label();
            this.day19 = new System.Windows.Forms.Label();
            this.day14 = new System.Windows.Forms.Label();
            this.day18 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day13 = new System.Windows.Forms.Label();
            this.day12 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.day7 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.Before_Btn = new System.Windows.Forms.Button();
            this.Next_Btn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchMonth
            // 
            this.SearchMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchMonth.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchMonth.FormattingEnabled = true;
            this.SearchMonth.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.SearchMonth.Location = new System.Drawing.Point(90, 1);
            this.SearchMonth.Name = "SearchMonth";
            this.SearchMonth.Size = new System.Drawing.Size(64, 23);
            this.SearchMonth.TabIndex = 0;
            this.SearchMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SearchYear
            // 
            this.SearchYear.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchYear.Location = new System.Drawing.Point(1, 1);
            this.SearchYear.Name = "SearchYear";
            this.SearchYear.Size = new System.Drawing.Size(64, 23);
            this.SearchYear.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "년";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Sun, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 37);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Lavender;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(499, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sat";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Lavender;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(416, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fri";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Lavender;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(333, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Lavender;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(250, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(167, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sun
            // 
            this.Sun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sun.BackColor = System.Drawing.Color.Lavender;
            this.Sun.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sun.ForeColor = System.Drawing.Color.Red;
            this.Sun.Location = new System.Drawing.Point(1, 0);
            this.Sun.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Sun.Name = "Sun";
            this.Sun.Size = new System.Drawing.Size(81, 37);
            this.Sun.TabIndex = 0;
            this.Sun.Text = "Sun";
            this.Sun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AllowDrop = true;
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.day38, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day37, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day36, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day39, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day42, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day30, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day40, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day31, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day29, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day41, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.day32, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day34, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day24, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day33, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day25, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day22, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day35, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.day28, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day21, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day17, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day16, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day15, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day27, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day20, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day23, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.day10, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day11, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day19, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.day3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.day13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.day2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.day1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.day4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.day6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.day7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.day5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 309);
            this.tableLayoutPanel2.TabIndex = 4;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // day38
            // 
            this.day38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day38.BackColor = System.Drawing.Color.White;
            this.day38.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day38.ForeColor = System.Drawing.Color.Black;
            this.day38.Location = new System.Drawing.Point(167, 258);
            this.day38.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day38.Name = "day38";
            this.day38.Size = new System.Drawing.Size(81, 47);
            this.day38.TabIndex = 42;
            this.day38.Text = " ";
            // 
            // day37
            // 
            this.day37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day37.BackColor = System.Drawing.Color.White;
            this.day37.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day37.ForeColor = System.Drawing.Color.Black;
            this.day37.Location = new System.Drawing.Point(84, 258);
            this.day37.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day37.Name = "day37";
            this.day37.Size = new System.Drawing.Size(81, 47);
            this.day37.TabIndex = 41;
            this.day37.Text = " ";
            // 
            // day36
            // 
            this.day36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day36.BackColor = System.Drawing.Color.White;
            this.day36.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day36.ForeColor = System.Drawing.Color.Red;
            this.day36.Location = new System.Drawing.Point(1, 258);
            this.day36.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day36.Name = "day36";
            this.day36.Size = new System.Drawing.Size(81, 47);
            this.day36.TabIndex = 40;
            this.day36.Text = " ";
            // 
            // day39
            // 
            this.day39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day39.BackColor = System.Drawing.Color.White;
            this.day39.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day39.ForeColor = System.Drawing.Color.Black;
            this.day39.Location = new System.Drawing.Point(250, 258);
            this.day39.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day39.Name = "day39";
            this.day39.Size = new System.Drawing.Size(81, 47);
            this.day39.TabIndex = 39;
            this.day39.Text = " ";
            // 
            // day42
            // 
            this.day42.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day42.BackColor = System.Drawing.Color.White;
            this.day42.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day42.ForeColor = System.Drawing.Color.Blue;
            this.day42.Location = new System.Drawing.Point(499, 258);
            this.day42.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day42.Name = "day42";
            this.day42.Size = new System.Drawing.Size(86, 47);
            this.day42.TabIndex = 38;
            this.day42.Text = " ";
            // 
            // day30
            // 
            this.day30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day30.BackColor = System.Drawing.Color.White;
            this.day30.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day30.ForeColor = System.Drawing.Color.Black;
            this.day30.Location = new System.Drawing.Point(84, 206);
            this.day30.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day30.Name = "day30";
            this.day30.Size = new System.Drawing.Size(81, 47);
            this.day30.TabIndex = 37;
            this.day30.Text = " ";
            // 
            // day40
            // 
            this.day40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day40.BackColor = System.Drawing.Color.White;
            this.day40.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day40.ForeColor = System.Drawing.Color.Black;
            this.day40.Location = new System.Drawing.Point(333, 258);
            this.day40.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day40.Name = "day40";
            this.day40.Size = new System.Drawing.Size(81, 47);
            this.day40.TabIndex = 36;
            this.day40.Text = " ";
            // 
            // day31
            // 
            this.day31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day31.BackColor = System.Drawing.Color.White;
            this.day31.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day31.ForeColor = System.Drawing.Color.Black;
            this.day31.Location = new System.Drawing.Point(167, 206);
            this.day31.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day31.Name = "day31";
            this.day31.Size = new System.Drawing.Size(81, 47);
            this.day31.TabIndex = 35;
            this.day31.Text = " ";
            // 
            // day29
            // 
            this.day29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day29.BackColor = System.Drawing.Color.White;
            this.day29.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day29.ForeColor = System.Drawing.Color.Red;
            this.day29.Location = new System.Drawing.Point(1, 206);
            this.day29.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day29.Name = "day29";
            this.day29.Size = new System.Drawing.Size(81, 47);
            this.day29.TabIndex = 34;
            this.day29.Text = " ";
            // 
            // day41
            // 
            this.day41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day41.BackColor = System.Drawing.Color.White;
            this.day41.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day41.ForeColor = System.Drawing.Color.Black;
            this.day41.Location = new System.Drawing.Point(416, 258);
            this.day41.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day41.Name = "day41";
            this.day41.Size = new System.Drawing.Size(81, 47);
            this.day41.TabIndex = 33;
            this.day41.Text = " ";
            // 
            // day32
            // 
            this.day32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day32.BackColor = System.Drawing.Color.White;
            this.day32.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day32.ForeColor = System.Drawing.Color.Black;
            this.day32.Location = new System.Drawing.Point(250, 206);
            this.day32.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day32.Name = "day32";
            this.day32.Size = new System.Drawing.Size(81, 47);
            this.day32.TabIndex = 32;
            this.day32.Text = " ";
            // 
            // day34
            // 
            this.day34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day34.BackColor = System.Drawing.Color.White;
            this.day34.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day34.ForeColor = System.Drawing.Color.Black;
            this.day34.Location = new System.Drawing.Point(416, 206);
            this.day34.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day34.Name = "day34";
            this.day34.Size = new System.Drawing.Size(81, 47);
            this.day34.TabIndex = 31;
            this.day34.Text = " ";
            // 
            // day24
            // 
            this.day24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day24.BackColor = System.Drawing.Color.White;
            this.day24.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day24.ForeColor = System.Drawing.Color.Black;
            this.day24.Location = new System.Drawing.Point(167, 155);
            this.day24.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day24.Name = "day24";
            this.day24.Size = new System.Drawing.Size(81, 47);
            this.day24.TabIndex = 30;
            this.day24.Text = " ";
            // 
            // day33
            // 
            this.day33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day33.BackColor = System.Drawing.Color.White;
            this.day33.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day33.ForeColor = System.Drawing.Color.Black;
            this.day33.Location = new System.Drawing.Point(333, 206);
            this.day33.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day33.Name = "day33";
            this.day33.Size = new System.Drawing.Size(81, 47);
            this.day33.TabIndex = 29;
            this.day33.Text = " ";
            // 
            // day25
            // 
            this.day25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day25.BackColor = System.Drawing.Color.White;
            this.day25.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day25.ForeColor = System.Drawing.Color.Black;
            this.day25.Location = new System.Drawing.Point(250, 155);
            this.day25.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day25.Name = "day25";
            this.day25.Size = new System.Drawing.Size(81, 47);
            this.day25.TabIndex = 28;
            this.day25.Text = " ";
            // 
            // day22
            // 
            this.day22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day22.BackColor = System.Drawing.Color.White;
            this.day22.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day22.ForeColor = System.Drawing.Color.Red;
            this.day22.Location = new System.Drawing.Point(1, 155);
            this.day22.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day22.Name = "day22";
            this.day22.Size = new System.Drawing.Size(81, 47);
            this.day22.TabIndex = 27;
            this.day22.Text = " ";
            // 
            // day35
            // 
            this.day35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day35.BackColor = System.Drawing.Color.White;
            this.day35.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day35.ForeColor = System.Drawing.Color.Blue;
            this.day35.Location = new System.Drawing.Point(499, 206);
            this.day35.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day35.Name = "day35";
            this.day35.Size = new System.Drawing.Size(86, 47);
            this.day35.TabIndex = 26;
            this.day35.Text = " ";
            // 
            // day28
            // 
            this.day28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day28.BackColor = System.Drawing.Color.White;
            this.day28.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day28.ForeColor = System.Drawing.Color.Blue;
            this.day28.Location = new System.Drawing.Point(499, 155);
            this.day28.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day28.Name = "day28";
            this.day28.Size = new System.Drawing.Size(86, 47);
            this.day28.TabIndex = 25;
            this.day28.Text = " ";
            // 
            // day26
            // 
            this.day26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day26.BackColor = System.Drawing.Color.White;
            this.day26.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day26.ForeColor = System.Drawing.Color.Black;
            this.day26.Location = new System.Drawing.Point(333, 155);
            this.day26.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day26.Name = "day26";
            this.day26.Size = new System.Drawing.Size(81, 47);
            this.day26.TabIndex = 24;
            this.day26.Text = " ";
            // 
            // day21
            // 
            this.day21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day21.BackColor = System.Drawing.Color.White;
            this.day21.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day21.ForeColor = System.Drawing.Color.Blue;
            this.day21.Location = new System.Drawing.Point(499, 104);
            this.day21.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day21.Name = "day21";
            this.day21.Size = new System.Drawing.Size(86, 47);
            this.day21.TabIndex = 23;
            this.day21.Text = " ";
            // 
            // day17
            // 
            this.day17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day17.BackColor = System.Drawing.Color.White;
            this.day17.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day17.ForeColor = System.Drawing.Color.Black;
            this.day17.Location = new System.Drawing.Point(167, 104);
            this.day17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day17.Name = "day17";
            this.day17.Size = new System.Drawing.Size(81, 47);
            this.day17.TabIndex = 22;
            this.day17.Text = " ";
            // 
            // day16
            // 
            this.day16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day16.BackColor = System.Drawing.Color.White;
            this.day16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day16.ForeColor = System.Drawing.Color.Black;
            this.day16.Location = new System.Drawing.Point(84, 104);
            this.day16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day16.Name = "day16";
            this.day16.Size = new System.Drawing.Size(81, 47);
            this.day16.TabIndex = 21;
            this.day16.Text = " ";
            // 
            // day15
            // 
            this.day15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day15.BackColor = System.Drawing.Color.White;
            this.day15.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day15.ForeColor = System.Drawing.Color.Red;
            this.day15.Location = new System.Drawing.Point(1, 104);
            this.day15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day15.Name = "day15";
            this.day15.Size = new System.Drawing.Size(81, 47);
            this.day15.TabIndex = 20;
            this.day15.Text = " ";
            // 
            // day27
            // 
            this.day27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day27.BackColor = System.Drawing.Color.White;
            this.day27.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day27.ForeColor = System.Drawing.Color.Black;
            this.day27.Location = new System.Drawing.Point(416, 155);
            this.day27.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day27.Name = "day27";
            this.day27.Size = new System.Drawing.Size(81, 47);
            this.day27.TabIndex = 19;
            this.day27.Text = " ";
            // 
            // day20
            // 
            this.day20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day20.BackColor = System.Drawing.Color.White;
            this.day20.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day20.ForeColor = System.Drawing.Color.Black;
            this.day20.Location = new System.Drawing.Point(416, 104);
            this.day20.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day20.Name = "day20";
            this.day20.Size = new System.Drawing.Size(81, 47);
            this.day20.TabIndex = 18;
            this.day20.Text = " ";
            // 
            // day23
            // 
            this.day23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day23.BackColor = System.Drawing.Color.White;
            this.day23.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day23.ForeColor = System.Drawing.Color.Black;
            this.day23.Location = new System.Drawing.Point(84, 155);
            this.day23.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day23.Name = "day23";
            this.day23.Size = new System.Drawing.Size(81, 47);
            this.day23.TabIndex = 17;
            this.day23.Text = " ";
            // 
            // day10
            // 
            this.day10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day10.BackColor = System.Drawing.Color.White;
            this.day10.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day10.ForeColor = System.Drawing.Color.Black;
            this.day10.Location = new System.Drawing.Point(167, 53);
            this.day10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day10.Name = "day10";
            this.day10.Size = new System.Drawing.Size(81, 47);
            this.day10.TabIndex = 16;
            this.day10.Text = " ";
            // 
            // day11
            // 
            this.day11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day11.BackColor = System.Drawing.Color.White;
            this.day11.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day11.ForeColor = System.Drawing.Color.Black;
            this.day11.Location = new System.Drawing.Point(250, 53);
            this.day11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day11.Name = "day11";
            this.day11.Size = new System.Drawing.Size(81, 47);
            this.day11.TabIndex = 15;
            this.day11.Text = " ";
            // 
            // day9
            // 
            this.day9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day9.BackColor = System.Drawing.Color.White;
            this.day9.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day9.ForeColor = System.Drawing.Color.Black;
            this.day9.Location = new System.Drawing.Point(84, 53);
            this.day9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day9.Name = "day9";
            this.day9.Size = new System.Drawing.Size(81, 47);
            this.day9.TabIndex = 14;
            this.day9.Text = " ";
            // 
            // day8
            // 
            this.day8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day8.BackColor = System.Drawing.Color.White;
            this.day8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day8.ForeColor = System.Drawing.Color.Red;
            this.day8.Location = new System.Drawing.Point(1, 53);
            this.day8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day8.Name = "day8";
            this.day8.Size = new System.Drawing.Size(81, 47);
            this.day8.TabIndex = 13;
            this.day8.Text = " ";
            // 
            // day19
            // 
            this.day19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day19.BackColor = System.Drawing.Color.White;
            this.day19.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day19.ForeColor = System.Drawing.Color.Black;
            this.day19.Location = new System.Drawing.Point(333, 104);
            this.day19.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day19.Name = "day19";
            this.day19.Size = new System.Drawing.Size(81, 47);
            this.day19.TabIndex = 12;
            this.day19.Text = " ";
            // 
            // day14
            // 
            this.day14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day14.BackColor = System.Drawing.Color.White;
            this.day14.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day14.ForeColor = System.Drawing.Color.Blue;
            this.day14.Location = new System.Drawing.Point(499, 53);
            this.day14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day14.Name = "day14";
            this.day14.Size = new System.Drawing.Size(86, 47);
            this.day14.TabIndex = 11;
            this.day14.Text = " ";
            // 
            // day18
            // 
            this.day18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day18.BackColor = System.Drawing.Color.White;
            this.day18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day18.ForeColor = System.Drawing.Color.Black;
            this.day18.Location = new System.Drawing.Point(250, 104);
            this.day18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day18.Name = "day18";
            this.day18.Size = new System.Drawing.Size(81, 47);
            this.day18.TabIndex = 10;
            this.day18.Text = " ";
            // 
            // day3
            // 
            this.day3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day3.BackColor = System.Drawing.Color.White;
            this.day3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day3.ForeColor = System.Drawing.Color.Black;
            this.day3.Location = new System.Drawing.Point(167, 2);
            this.day3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(81, 47);
            this.day3.TabIndex = 9;
            this.day3.Text = " ";
            // 
            // day13
            // 
            this.day13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day13.BackColor = System.Drawing.Color.White;
            this.day13.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day13.ForeColor = System.Drawing.Color.Black;
            this.day13.Location = new System.Drawing.Point(416, 53);
            this.day13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day13.Name = "day13";
            this.day13.Size = new System.Drawing.Size(81, 47);
            this.day13.TabIndex = 8;
            this.day13.Text = " ";
            // 
            // day12
            // 
            this.day12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day12.BackColor = System.Drawing.Color.White;
            this.day12.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day12.ForeColor = System.Drawing.Color.Black;
            this.day12.Location = new System.Drawing.Point(333, 53);
            this.day12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day12.Name = "day12";
            this.day12.Size = new System.Drawing.Size(81, 47);
            this.day12.TabIndex = 7;
            this.day12.Text = " ";
            // 
            // day2
            // 
            this.day2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day2.BackColor = System.Drawing.Color.White;
            this.day2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day2.ForeColor = System.Drawing.Color.Black;
            this.day2.Location = new System.Drawing.Point(84, 2);
            this.day2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(81, 47);
            this.day2.TabIndex = 6;
            this.day2.Text = " ";
            // 
            // day1
            // 
            this.day1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day1.BackColor = System.Drawing.Color.White;
            this.day1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day1.ForeColor = System.Drawing.Color.Red;
            this.day1.Location = new System.Drawing.Point(1, 2);
            this.day1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(81, 47);
            this.day1.TabIndex = 5;
            this.day1.Text = " ";
            // 
            // day4
            // 
            this.day4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day4.BackColor = System.Drawing.Color.White;
            this.day4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day4.ForeColor = System.Drawing.Color.Black;
            this.day4.Location = new System.Drawing.Point(250, 2);
            this.day4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(81, 47);
            this.day4.TabIndex = 4;
            this.day4.Text = " ";
            // 
            // day6
            // 
            this.day6.AllowDrop = true;
            this.day6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day6.BackColor = System.Drawing.Color.White;
            this.day6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day6.ForeColor = System.Drawing.Color.Black;
            this.day6.Location = new System.Drawing.Point(416, 2);
            this.day6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(81, 47);
            this.day6.TabIndex = 3;
            this.day6.Text = " ";
            // 
            // day7
            // 
            this.day7.AllowDrop = true;
            this.day7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day7.BackColor = System.Drawing.Color.White;
            this.day7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day7.ForeColor = System.Drawing.Color.Blue;
            this.day7.Location = new System.Drawing.Point(499, 2);
            this.day7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day7.Name = "day7";
            this.day7.Size = new System.Drawing.Size(86, 47);
            this.day7.TabIndex = 2;
            this.day7.Text = " ";
            // 
            // day5
            // 
            this.day5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.day5.BackColor = System.Drawing.Color.White;
            this.day5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.day5.ForeColor = System.Drawing.Color.Black;
            this.day5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.day5.Location = new System.Drawing.Point(333, 2);
            this.day5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(81, 47);
            this.day5.TabIndex = 1;
            this.day5.Text = " ";
            // 
            // MonthLabel
            // 
            this.MonthLabel.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold);
            this.MonthLabel.Location = new System.Drawing.Point(492, 23);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(50, 25);
            this.MonthLabel.TabIndex = 5;
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.YearLabel.Location = new System.Drawing.Point(494, 5);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(39, 15);
            this.YearLabel.TabIndex = 6;
            this.YearLabel.Text = "label8";
            this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Before_Btn
            // 
            this.Before_Btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Before_Btn.Location = new System.Drawing.Point(464, 24);
            this.Before_Btn.Name = "Before_Btn";
            this.Before_Btn.Size = new System.Drawing.Size(21, 23);
            this.Before_Btn.TabIndex = 7;
            this.Before_Btn.Text = "◀";
            this.Before_Btn.UseVisualStyleBackColor = true;
            this.Before_Btn.Click += new System.EventHandler(this.Before_Btn_Click);
            // 
            // Next_Btn
            // 
            this.Next_Btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Next_Btn.Location = new System.Drawing.Point(550, 25);
            this.Next_Btn.Name = "Next_Btn";
            this.Next_Btn.Size = new System.Drawing.Size(21, 23);
            this.Next_Btn.TabIndex = 8;
            this.Next_Btn.Text = "▶";
            this.Next_Btn.UseVisualStyleBackColor = true;
            this.Next_Btn.Click += new System.EventHandler(this.Next_Btn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.SearchBtn.Location = new System.Drawing.Point(160, 1);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 9;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 410);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Next_Btn);
            this.Controls.Add(this.Before_Btn);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchYear);
            this.Controls.Add(this.SearchMonth);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchMonth;
        private System.Windows.Forms.TextBox SearchYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Sun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label day7;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Button Before_Btn;
        private System.Windows.Forms.Button Next_Btn;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day13;
        private System.Windows.Forms.Label day12;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Label day38;
        private System.Windows.Forms.Label day37;
        private System.Windows.Forms.Label day36;
        private System.Windows.Forms.Label day39;
        private System.Windows.Forms.Label day42;
        private System.Windows.Forms.Label day30;
        private System.Windows.Forms.Label day40;
        private System.Windows.Forms.Label day31;
        private System.Windows.Forms.Label day29;
        private System.Windows.Forms.Label day41;
        private System.Windows.Forms.Label day32;
        private System.Windows.Forms.Label day34;
        private System.Windows.Forms.Label day24;
        private System.Windows.Forms.Label day33;
        private System.Windows.Forms.Label day25;
        private System.Windows.Forms.Label day22;
        private System.Windows.Forms.Label day35;
        private System.Windows.Forms.Label day28;
        private System.Windows.Forms.Label day26;
        private System.Windows.Forms.Label day21;
        private System.Windows.Forms.Label day17;
        private System.Windows.Forms.Label day16;
        private System.Windows.Forms.Label day15;
        private System.Windows.Forms.Label day27;
        private System.Windows.Forms.Label day20;
        private System.Windows.Forms.Label day23;
        private System.Windows.Forms.Label day10;
        private System.Windows.Forms.Label day11;
        private System.Windows.Forms.Label day9;
        private System.Windows.Forms.Label day8;
        private System.Windows.Forms.Label day19;
        private System.Windows.Forms.Label day14;
        private System.Windows.Forms.Label day18;
        public System.Windows.Forms.Label day1;
        private System.Windows.Forms.Button SearchBtn;
    }
}

