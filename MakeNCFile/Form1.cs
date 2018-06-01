using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MakeNCFile
{
    public partial class Form1 : Form
    {
        Graphics g;
        List<CLICKPOS> pos = new List<CLICKPOS>();
        List<CLICKPOS> pos2 = new List<CLICKPOS>();

        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 왼쪽 버튼 클릭이면 pos에 좌표 추가
            {
                CLICKPOS cp = new CLICKPOS();
                cp.X = e.X / 10;
                cp.Y = e.Y / 10;
                pos.Add(cp);
            }
            else if (e.Button == MouseButtons.Right) // 오른쪽 버튼 클릭이면 pos에서 좌표 제거
            {
                int x = e.X / 10;
                int y = e.Y / 10;
                for (int i = 0; i < pos.Count; i++)
                {
                    if (pos[i] != null && pos[i].X == x && pos[i].Y == y)
                    {
                        g.FillRectangle(Brushes.White, pos[i].X * 10 + 1, pos[i].Y * 10 + 1, 9, 9);
                        pos[i] = null;  // null로 만듬!!! pos 좌표 체크할때 null 여부 체크할것
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pos.Count > 0)
            {
                //textBox2.Text = pos.Count.ToString();

                foreach (var p in pos)
                {
                    if (p != null)
                    {
                        g.FillRectangle(Brushes.Blue, p.X * 10 + 1, p.Y * 10 + 1, 9, 9); // 파란색 칸 채우기
                    }
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mLeftDown)
            {
                int x = e.X / 10;
                int y = e.Y / 10;

                pos.Add(new CLICKPOS() { X = x, Y = y });
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 테두리
            g.DrawRectangle(Pens.Black, 0, 0, panel1.Width - 1, panel1.Height - 1);

            // 그리드라인
            for (int y = 10; y < panel1.Height; y += 10) g.DrawLine(Pens.Black, 0, y, panel1.Width, y);
            for (int x = 10; x < panel1.Width; x += 10) g.DrawLine(Pens.Black, x, 0, x, panel1.Height);
        }

        bool mLeftDown = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mLeftDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mLeftDown = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            List<CLICKPOS> pos_copy = pos;
            Int32[,] kk = new Int32[panel1.Width / 10, panel1.Height / 10];

            if (MessageBox.Show("순서대로 저장하시겠습니까?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                foreach (var p in pos_copy)
                {
                    if(p != null) kk[p.X, p.Y] = 1;
                }

                pos_copy.Clear();

                for (int y = 0; y < panel1.Height / 10; y++)
                {
                    for (int x = 0; x < panel1.Width / 10; x++)
                    {
                        if (kk[x, y] == 1) pos_copy.Add(new CLICKPOS() { X = x, Y = y });
                    }
                }
            }

            double inc = Double.Parse(textBox3.Text);

            for (int i = pos_copy.Count - 1; i >= 0; i--)
            {
                if (pos_copy[i] == null) pos_copy.RemoveAt(i);
            }

            richTextBox1.Clear();

            List<CLICKPOS> pos2 = new List<CLICKPOS>();
            bool equal = false;
            foreach (var p in pos_copy)
            {
                equal = false;
                if (pos2.Count == 0) pos2.Add(p);
                else
                {
                    for (int i = 0; i < pos2.Count; i++)
                    {
                        if (p.X == pos2[i].X && p.Y == pos2[i].Y)
                        {
                            equal = true;
                            break;
                        }
                    }

                    if (equal == false) pos2.Add(p);
                }
            }

            //for (int i = 0; i < pos_copy.Count; i++)
            //{
            //    richTextBox1.Text += "G11 " + pos_copy[i].X.ToString() + " , " + pos_copy[i].Y.ToString() + "\r\n";
            //}

            //richTextBox1.Text += "\r\n------------------------------------------ \r\n\r\n";


            richTextBox1.Text += "YouGar Mode File - YHWH\r\n";

            for (int i = 0; i < pos2.Count; i++)
            {
                richTextBox1.Text += "G11 X" + (pos2[i].X * inc).ToString() + "  Y" + (pos2[i].Y * inc).ToString() + "\r\n";
            }

            richTextBox1.Text += "M02\r\n";

            //richTextBox1.Text += "\r\n------------------------------------------ \r\n\r\n";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPanelClear_Click(object sender, EventArgs e)
        {
            pos.Clear();
            g.FillRectangle(Brushes.White, 0, 0, panel1.Width - 1, panel1.Height - 1);

            // 테두리
            g.DrawRectangle(Pens.Black, 0, 0, panel1.Width - 1, panel1.Height - 1);

            // 그리드라인
            for (int y = 10; y < panel1.Height; y += 10) g.DrawLine(Pens.Black, 0, y, panel1.Width, y);
            for (int x = 10; x < panel1.Width; x += 10) g.DrawLine(Pens.Black, x, 0, x, panel1.Height);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string name = "NCFile_" + DateTime.Now.ToString("yyyymmdd_HHmmss") + ".nc";
            saveFileDialog1.FileName = name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //File.WriteAllText(saveFileDialog1.FileName, textBox1.Text.Trim());
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text.Replace("\n", "\r\n").Trim());

                MessageBox.Show("저장 완료");
            }
        }

        private void btnInsertCmd_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            foreach (var s in richTextBox1.Lines)
            {
                if (s.Trim().StartsWith("G") || s.Trim().StartsWith("g"))
                {
                    temp += s.Trim() + "  " + txtAddCmd.Text.Trim() + "\r\n";
                }
                else
                {
                    temp += s.Trim() + "\r\n";
                }
            }

            richTextBox1.Text = temp;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;
            foreach (var s in richTextBox1.Lines)
            {
                if (s.Trim().IndexOf(txtAddCmd.Text.Trim()) > -1)
                {
                    temp += s.Replace(txtAddCmd.Text.Trim(), "").Trim() + "\r\n";
                }
                else
                {
                    temp += s.Trim() + "\r\n";
                }
            }

            richTextBox1.Text = temp;
        }
    }

    public class CLICKPOS
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
