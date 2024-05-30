namespace TodoFinal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.Datelabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Radiobutton_normal = new System.Windows.Forms.RadioButton();
            this.Radiobutton_important = new System.Windows.Forms.RadioButton();
            this.Addbutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Progresslabel1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Progresslabel2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.삭제하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.수정하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.새프로젝트만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.삭제하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.수정하기ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Timelabel);
            this.groupBox1.Controls.Add(this.Datelabel);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(466, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(131, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 3);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Todo For U";
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Timelabel.Location = new System.Drawing.Point(365, 60);
            this.Timelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(80, 24);
            this.Timelabel.TabIndex = 1;
            this.Timelabel.Text = "오후 2:34";
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Datelabel.Location = new System.Drawing.Point(273, 33);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(175, 24);
            this.Datelabel.TabIndex = 0;
            this.Datelabel.Text = "2022년 6월 6일 화요일";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 60);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 21);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.Radiobutton_normal);
            this.groupBox2.Controls.Add(this.Radiobutton_important);
            this.groupBox2.Controls.Add(this.Addbutton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.999999F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(0, 454);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(466, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.Location = new System.Drawing.Point(1, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "추가하기";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Radiobutton_normal
            // 
            this.Radiobutton_normal.AutoSize = true;
            this.Radiobutton_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Radiobutton_normal.Location = new System.Drawing.Point(58, 37);
            this.Radiobutton_normal.Margin = new System.Windows.Forms.Padding(2);
            this.Radiobutton_normal.Name = "Radiobutton_normal";
            this.Radiobutton_normal.Size = new System.Drawing.Size(47, 17);
            this.Radiobutton_normal.TabIndex = 2;
            this.Radiobutton_normal.TabStop = true;
            this.Radiobutton_normal.Text = "일반";
            this.Radiobutton_normal.UseVisualStyleBackColor = true;
            // 
            // Radiobutton_important
            // 
            this.Radiobutton_important.AutoSize = true;
            this.Radiobutton_important.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Radiobutton_important.Location = new System.Drawing.Point(58, 17);
            this.Radiobutton_important.Margin = new System.Windows.Forms.Padding(2);
            this.Radiobutton_important.Name = "Radiobutton_important";
            this.Radiobutton_important.Size = new System.Drawing.Size(47, 17);
            this.Radiobutton_important.TabIndex = 1;
            this.Radiobutton_important.TabStop = true;
            this.Radiobutton_important.Text = "중요";
            this.Radiobutton_important.UseVisualStyleBackColor = true;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(6, 31);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(36, 26);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.tabControl1.Location = new System.Drawing.Point(0, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 361);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Progresslabel1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(458, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "오늘 할 일";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Progresslabel1
            // 
            this.Progresslabel1.AutoSize = true;
            this.Progresslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Progresslabel1.Location = new System.Drawing.Point(366, 21);
            this.Progresslabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Progresslabel1.Name = "Progresslabel1";
            this.Progresslabel1.Size = new System.Drawing.Size(60, 13);
            this.Progresslabel1.TabIndex = 2;
            this.Progresslabel1.Text = "0/3 완료됨";
            this.Progresslabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(319, 4);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 15);
            this.progressBar1.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 4);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(312, 308);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Progresslabel2);
            this.tabPage2.Controls.Add(this.progressBar2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.checkedListBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(458, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "프로젝트";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "삭제하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Progresslabel2
            // 
            this.Progresslabel2.AutoSize = true;
            this.Progresslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Progresslabel2.Location = new System.Drawing.Point(366, 47);
            this.Progresslabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Progresslabel2.Name = "Progresslabel2";
            this.Progresslabel2.Size = new System.Drawing.Size(60, 13);
            this.Progresslabel2.TabIndex = 3;
            this.Progresslabel2.Text = "0/3 완료됨";
            this.Progresslabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(319, 30);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(120, 15);
            this.progressBar2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(319, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(4, 4);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(312, 308);
            this.checkedListBox2.TabIndex = 2;
            this.checkedListBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBox2_MouseUp);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(458, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "분석";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 8);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 19);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(235, 8);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(37, 21);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 8);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 21);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 65);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "날짜";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(449, 200);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "년";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "월";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.삭제하기ToolStripMenuItem,
            this.수정하기ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // 삭제하기ToolStripMenuItem
            // 
            this.삭제하기ToolStripMenuItem.Name = "삭제하기ToolStripMenuItem";
            this.삭제하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.삭제하기ToolStripMenuItem.Text = "삭제하기";
            this.삭제하기ToolStripMenuItem.Click += new System.EventHandler(this.삭제하기ToolStripMenuItem_Click);
            // 
            // 수정하기ToolStripMenuItem
            // 
            this.수정하기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.수정하기ToolStripMenuItem.Name = "수정하기ToolStripMenuItem";
            this.수정하기ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.수정하기ToolStripMenuItem.Text = "수정하기";
            this.수정하기ToolStripMenuItem.Click += new System.EventHandler(this.수정하기ToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F);
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새프로젝트만들기ToolStripMenuItem,
            this.삭제하기ToolStripMenuItem1,
            this.수정하기ToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(165, 70);
            // 
            // 새프로젝트만들기ToolStripMenuItem
            // 
            this.새프로젝트만들기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox2});
            this.새프로젝트만들기ToolStripMenuItem.Name = "새프로젝트만들기ToolStripMenuItem";
            this.새프로젝트만들기ToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.새프로젝트만들기ToolStripMenuItem.Text = "새 프로젝트 생성";
            this.새프로젝트만들기ToolStripMenuItem.Click += new System.EventHandler(this.새프로젝트만들기ToolStripMenuItem_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // 삭제하기ToolStripMenuItem1
            // 
            this.삭제하기ToolStripMenuItem1.Name = "삭제하기ToolStripMenuItem1";
            this.삭제하기ToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.삭제하기ToolStripMenuItem1.Text = "삭제하기";
            this.삭제하기ToolStripMenuItem1.Click += new System.EventHandler(this.삭제하기ToolStripMenuItem1_Click);
            // 
            // 수정하기ToolStripMenuItem1
            // 
            this.수정하기ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox3});
            this.수정하기ToolStripMenuItem1.Name = "수정하기ToolStripMenuItem1";
            this.수정하기ToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.수정하기ToolStripMenuItem1.Text = "수정하기";
            this.수정하기ToolStripMenuItem1.Click += new System.EventHandler(this.수정하기ToolStripMenuItem1_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 23);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 515);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Radiobutton_normal;
        private System.Windows.Forms.RadioButton Radiobutton_important;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label Progresslabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label Progresslabel2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 삭제하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 수정하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 삭제하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 새프로젝트만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem 수정하기ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

