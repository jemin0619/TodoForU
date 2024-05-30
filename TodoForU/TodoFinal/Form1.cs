using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using Timer = System.Windows.Forms.Timer;

namespace TodoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        const string Folderpath = "C:\\Todoforu";
        const string Projectpath = Folderpath + "\\프로젝트";
        string filename;
        int clickedItemIndex = -1;

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(100, 25); // 원하는 폭과 높이로 설정

            //ok
            Radiobutton_normal.Checked = true;
            checkedListBox1.Sorted = true;
            checkedListBox2.Sorted = true;
            checkedListBox1.ContextMenuStrip = contextMenuStrip1;
            checkedListBox2.ContextMenuStrip = contextMenuStrip2;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox2.HorizontalScrollbar = true;

            //ok
            Timer timer = new Timer();
            timer.Interval = 1000; // 1초마다 업데이트
            timer.Tick += Timer_Tick;
            timer.Start();

            //ok
            Timer progressTimer = new Timer();
            progressTimer.Interval = 100; // 0.1초마다 업데이트
            progressTimer.Tick += progressTimer_Tick;
            progressTimer.Start();

            //ok
            Timer backupTimer = new Timer();
            backupTimer.Interval = 20000; // 20초마다 백업
            backupTimer.Tick += backupTimer_Tick;
            backupTimer.Start();

            //ok
            if (!Directory.Exists(Folderpath)) { Directory.CreateDirectory(Folderpath); }
            if (!Directory.Exists(Projectpath)) { Directory.CreateDirectory(Projectpath); }

            //ok
            filename = DateTime.Now.ToString("d") + ".txt";
            if (!File.Exists(Folderpath + "\\" + filename)) { File.Create(Folderpath + "\\" + filename).Dispose(); }

            //ok
            numericUpDown1.Value = DateTime.Now.Year;
            numericUpDown2.Value = DateTime.Now.Month;

            UpdateLabel(); // 폼 로드 시 초기 업데이트
            UpdateProjectcombobox(Projectpath);

            //ok
            Loadfile(checkedListBox1, Folderpath + "\\" + filename);

            //ok
            chart1.ChartAreas[0].AxisY.Maximum = 1;
        }

        private void Loadfile(CheckedListBox checkedListBox, string filepath)
        {
            if (!File.Exists(filepath))
            {
                File.Create(filepath).Dispose();
            }

            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string Status = line.Substring(0, 1);
                    string value = line.Substring(1, line.Length - 1);
                    checkedListBox.Items.Add(value);
                    if (Status == "1")
                    {
                        int index = checkedListBox.Items.Count - 1;
                        checkedListBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        private void Savefile(CheckedListBox checkedListBox, string filepath)
        {
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    bool isChecked = checkedListBox.GetItemChecked(i);
                    string Status;
                    if (isChecked == true) Status = "1";
                    else Status = "0";
                    string value = checkedListBox.Items[i].ToString();
                    writer.WriteLine(Status + value);
                }
            }
        }

        private void UpdateProjectcombobox(string path)
        {
            string[] fileNames = Directory.GetFiles(path);

            foreach (string fileName in fileNames)
            {
                comboBox1.Items.Add(Path.GetFileName(fileName));
            }
        }

        private void UpdateProgress(CheckedListBox checkedListBox, ProgressBar progressBar, Label label)
        {
            int checkeditem = checkedListBox.CheckedItems.Count;
            int allitem = checkedListBox.Items.Count;
            string progressText = checkeditem.ToString() + "/" + allitem.ToString() + "완료됨";
            progressBar.Minimum = 0;
            progressBar.Maximum = allitem;
            progressBar.Value = checkeditem;
            label.Text = progressText;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            UpdateProgress(checkedListBox1, progressBar1, Progresslabel1);
            UpdateProgress(checkedListBox2, progressBar2, Progresslabel2);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateLabel(); // 타이머 틱마다 업데이트
        }

        private void backupTimer_Tick(object sender, EventArgs e)
        {
            Savefile(checkedListBox1, Folderpath + "\\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".txt");
        }

        //UpdateLabel 넣음
        private void UpdateLabel()
        {
            Datelabel.Text = DateTime.Now.ToString("D");
            Timelabel.Text = DateTime.Now.ToString("t");
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                Additem(checkedListBox1, textBox1);
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                Additem(checkedListBox2, textBox1);
            }
        }

        private void Additem(CheckedListBox checkedListBox, TextBox textBox)
        {
            string text = textBox.Text;

            if (tabControl1.SelectedTab == tabPage2)
            {
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("프로젝트를 선택해주세요!", "Todo For U");
                    return;
                }
            }

            if (Radiobutton_important.Checked)
            {
                text = "★" + text;
            }

            if (checkedListBox.Items.Contains(textBox.Text) || checkedListBox.Items.Contains("★" + textBox.Text))
            {
                MessageBox.Show("이미 존재합니다", "Todo For U");
            }

            else if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("할 일을 추가해주세요", "Todo For U");
            }

            else if (text.Substring(0, 1) == " ")
            {
                MessageBox.Show("내용의 첫 글자가 공백입니다", "Todo For U");
            }

            else checkedListBox.Items.Add(text);
        }


        private void SetClickedItemIndex(CheckedListBox checkedListBox, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickedItemIndex = checkedListBox.IndexFromPoint(e.Location);
                if (clickedItemIndex != ListBox.NoMatches)
                {
                    checkedListBox.SelectedIndex = clickedItemIndex;
                }
            }
        }

        private void checkedListBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SetClickedItemIndex(checkedListBox1, e);
        }

        private void checkedListBox2_MouseUp(object sender, MouseEventArgs e)
        {
            SetClickedItemIndex(checkedListBox2, e);
        }

        private void deleteItem(CheckedListBox checkedListBox)
        {
            if (clickedItemIndex != ListBox.NoMatches)
            {
                checkedListBox.Items.RemoveAt(clickedItemIndex);
            }
        }

        private void modifyItem(CheckedListBox checkedListBox, ToolStripTextBox toolStripTextBox)
        {


            if (clickedItemIndex != ListBox.NoMatches)
            {
                string text = toolStripTextBox.Text;
                string firstValue = checkedListBox.Items[clickedItemIndex].ToString().Substring(0, 1);

                if (checkedListBox.Items.Contains(text) || checkedListBox.Items.Contains("★" + text))
                {
                    MessageBox.Show("이미 존재합니다,", "Todo For U");
                }
                else if (string.IsNullOrWhiteSpace(text))
                {
                    MessageBox.Show("할 일을 추가해주세요", "Todo For U");
                }
                else if (text.Substring(0, 1) == " ")
                {
                    MessageBox.Show("내용의 첫 글자가 공백입니다", "Todo For U");
                }
                else
                {
                    if (firstValue == "★") text = "★" + text;
                    checkedListBox.Items[clickedItemIndex] = text;
                    toolStripTextBox.Text = "";
                }
            }
        }

        private void 삭제하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteItem(checkedListBox1);
        }

        private void 수정하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyItem(checkedListBox1, toolStripTextBox1);
        }

        private void 삭제하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteItem(checkedListBox2);
        }

        private void 수정하기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modifyItem(checkedListBox2, toolStripTextBox3);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //날짜 바뀌면 불러오기
        {
            checkedListBox1.Items.Clear();
            Loadfile(checkedListBox1, Folderpath + "\\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".txt");
        }

        private void dateTimePicker1_DropDown(object sender, EventArgs e) //날짜 변경하려 할때 자동저장
        {
            Savefile(checkedListBox1, Folderpath + "\\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".txt");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //닫힐때 자동저장
        {
            Savefile(checkedListBox1, Folderpath + "\\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".txt");
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                Savefile(checkedListBox2, Projectpath + "\\" + comboBox1.Text);
            }
        }

        private void 새프로젝트만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = toolStripTextBox2.Text;
            if (comboBox1.Items.Contains(text))
            {
                MessageBox.Show("이미 존재합니다!", "Todo For U");
            }
            else if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("프로젝트명을 적어주세요!", "Todo For U");
            }
            else if (text.Substring(0, 1) == " ")
            {
                MessageBox.Show("첫 글자는 공백일 수 없습니다.", "Todo For U");
            }
            else
            {
                comboBox1.Items.Add(text);
                File.Create(Projectpath + "\\" + text).Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e) //프로젝트 삭제버튼 누를 시
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("아이템을 선택해주세요!", "Todo For U");
            }

            else if (MessageBox.Show("정말 이 프로젝트를 삭제하시겠습니까?", "Todo For U", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                File.Delete(Projectpath + "\\" + comboBox1.Text);
                MessageBox.Show("정상적으로 삭제되었습니다.");
                comboBox1.Items.Remove(comboBox1.Text);
                comboBox1.Text = null;
                checkedListBox2.Items.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //프로젝트 선택시 Loadfile
        {
            checkedListBox2.Items.Clear();
            Loadfile(checkedListBox2, Projectpath + "\\" + comboBox1.Text);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) //datetimepicker enable true false
        {
            Savefile(checkedListBox1, Folderpath + "\\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".txt");
            if (tabControl1.SelectedTab == tabPage1)
            {
                dateTimePicker1.Enabled = true;
            }
            else dateTimePicker1.Enabled = false;
        }

        private void comboBox1_DropDown(object sender, EventArgs e) //프로젝트 저장
        {
            if (!string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                Savefile(checkedListBox2, Projectpath + "\\" + comboBox1.Text);
            }
        }

        private void UpdateChart(Chart chart, string year, string month)
        {
            foreach (Series series in chart.Series)
            {
                series.Points.Clear();
            }

            if (month.Length == 1)
            {
                month = "0" + month;
            }

            string searchingtext = year + "-" + month + "*";
            string[] Filenames = Getfilenames(Folderpath, searchingtext);
            Array.Sort(Filenames);

            try
            {
                foreach (string i in Filenames)
                {
                    if (!IsfilevalueExist(i)) //파일에 값이 존재하지 않으면, 파일이 없으면 0
                    {
                        continue;
                    }

                    int numfile = Getfilenum(i);
                    int checkedfile = Getcheckedfilenum(i);

                    double progress = checkedfile / (double)numfile; // 정수 나눗셈으로 인해 소수점 이하 값이 손실되지 않도록 double로 형변환
                    chart.Series["날짜"].Points.AddXY(i.Substring(20,2)+"일",progress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string[] Getfilenames(string path, string value) //정상작동
        {
            string[] Filenames = Directory.GetFiles(path, value);
            return Filenames;
        }

        private bool IsfilevalueExist(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    if (string.IsNullOrWhiteSpace(reader.ReadToEnd()))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred while reading file: {ex.Message}");
                return false;
            }
        }

        private int Getfilenum(string path) //streamreader로 파일에서 1이 붙은 줄 수 읽어오기
        {
            int linecnt = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    linecnt++;
                }
            }
            return linecnt;
        }

        private int Getcheckedfilenum(string path) //streamreader로 파일 줄 수 읽어오기
        {
            int filenum = 0;
            string line;
            using (StreamReader reader = new StreamReader(path))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    // line = reader.ReadLine(); <- 중복되는 코드로 인해 주석 처리
                    if (line.Substring(0, 1) == "1")
                    {
                        filenum++;
                    }
                }
            }
            return filenum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateChart(chart1, numericUpDown1.Value.ToString(), numericUpDown2.Value.ToString());
        }
    }
}

