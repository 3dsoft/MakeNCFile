using MakeNCFile2.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeNCFile2.Forms
{
    public partial class FrmGridMain : Form
    {
        public PanelInfo pi = new PanelInfo();
        Graphics g;
        int[,] matrix2;

        public FrmGridMain()
        {
            InitializeComponent();
        }

        private void FrmGridMain_Load(object sender, EventArgs e)
        {
            txtName.Text = pi.pnFileName;
            txtSizeWidth.Text = pi.pnSize.Width.ToString();
            txtSizeHeight.Text = pi.pnSize.Height.ToString();
            txtMarkGap.Text = pi.pnGridGap.ToString();
            if (pi.pnMarkType == 0) rdMarkCircle.Checked = true;
            if (pi.pnMarkType == 1) rdMarkRectangle.Checked = true;

            listBox1.Items.Add(pi.pnGridGap.ToString());
            listBox1.Items.Add(pi.pnMarkType.ToString());
            listBox1.Items.Add(pi.pnSize.Width.ToString());
            listBox1.Items.Add(pi.pnSize.Height.ToString());

            if (pi.matrix == null || pi.matrix.GetLength(0) == 0) pi.matrix = new int[pi.pnSize.Width, pi.pnSize.Height];
            matrix2 = new int[pi.pnSize.Width, pi.pnSize.Height];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            g = panel1.CreateGraphics();

            DrawGridLine();

            DrawMark();

            if (g != null) g.Dispose();
        }

        private void DrawGridLine()
        {
            if (g == null) return;

            //panel1.BackColor = Color.LightGray;

            for (int y = 0; y < pi.pnSize.Height + 1; y++)
            {
                g.DrawLine(new Pen(pi.pnGridLineColor, 1), 0, y * 10, pi.pnSize.Width * 10, y * 10);
            }

            for (int x = 0; x < pi.pnSize.Width + 1; x++)
            {
                g.DrawLine(new Pen(pi.pnGridLineColor, 1), x * 10, 0, x * 10, pi.pnSize.Height * 10);
            }
        }

        private void DrawMark()
        {
            if (g == null) return;

            for (int x = 0; x < pi.matrix.GetLength(0); x++)
            {
                for (int y = 0; y < pi.matrix.GetLength(1); y++)
                {
                    if (pi.matrix[x, y] == 1)
                    {
                        if (pi.pnMarkType == 0) g.FillEllipse(Brushes.Blue, x * 10 + 0, y * 10 + 0, 10, 10);
                        else if (pi.pnMarkType == 1) g.FillRectangle(Brushes.Blue, x * 10, y * 10, 10, 10);
                    }
                    else if (pi.matrix[x, y] == 0 && matrix2[x, y] == 1)
                    {
                        g.FillRectangle(Brushes.LightGray, x * 10 + 1, y * 10 + 1, 9, 9);
                        matrix2[x, y] = 0;
                    }
                }
            }
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Items.Add(e.Button.ToString());
            listBox1.Items.Add(e.X.ToString() + " , " + e.Y.ToString());
            listBox1.Items.Add((e.X / 10).ToString() + " , " + (e.Y / 10).ToString());
            listBox1.SelectedIndex = listBox1.Items.Count - 1;

            if (e.X >= 0 && e.Y >= 0 && (e.X / 10) < pi.matrix.GetLength(0) && (e.Y / 10) < pi.matrix.GetLength(1))
            {
                if (e.Button == MouseButtons.Left) { pi.matrix[e.X / 10, e.Y / 10] = 1; matrix2[e.X / 10, e.Y / 10] = 1; }
                else if (e.Button == MouseButtons.Right) pi.matrix[e.X / 10, e.Y / 10] = 0;
            }

            DrawGridLine();
            DrawMark();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (e.X >= 0 && e.Y >= 0 && (e.X / 10) < pi.matrix.GetLength(0) && (e.Y / 10) < pi.matrix.GetLength(1))
                {
                    if (e.Button == MouseButtons.Left) { pi.matrix[e.X / 10, e.Y / 10] = 1; matrix2[e.X / 10, e.Y / 10] = 1; }
                    else if (e.Button == MouseButtons.Right) pi.matrix[e.X / 10, e.Y / 10] = 0;
                }
                DrawGridLine();
                DrawMark();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (g != null) g.Dispose();
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Clear ?", "All Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                g = panel1.CreateGraphics();

                for (int x = 0; x < pi.matrix.GetLength(0); x++)
                {
                    for (int y = 0; y < pi.matrix.GetLength(1); y++)
                    {
                        if (pi.matrix[x, y] == 1)
                        {
                            g.FillRectangle(Brushes.LightGray, x * 10 + 0, y * 10 + 0, 10, 10);
                        }
                        pi.matrix[x, y] = 0;
                        matrix2[x, y] = 0;
                    }
                }
                g.Dispose();

                panel1_Paint(null, null);
            }
        }

        // Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, pi);

                    MessageBox.Show("Save OK");
                }
            }
        }

        // 패널 그리드 재설정
        private void btnSet_Click(object sender, EventArgs e)
        {
            double gap = pi.pnGridGap;

            if (rdMarkCircle.Checked) pi.pnMarkType = 0;
            if (rdMarkRectangle.Checked) pi.pnMarkType = 1;
            if (double.TryParse(txtMarkGap.Text, out gap)) pi.pnGridGap = gap;

            g = panel1.CreateGraphics();

            for (int x = 0; x < pi.matrix.GetLength(0); x++)
            {
                for (int y = 0; y < pi.matrix.GetLength(1); y++)
                {
                    if (pi.matrix[x, y] == 1)
                    {
                        g.FillRectangle(Brushes.LightGray, x * 10 + 0, y * 10 + 0, 10, 10);
                    }
                }
            }
            g.Dispose();

            panel1_Paint(null, null);
        }

        private void btnSaveToNCFile_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "YouGar Mode File - YHWH\r\n";

            // Left-Top
            if (rdLeftTop.Checked)
            {
                for (int x = 0; x < pi.matrix.GetLength(0); x++)
                {
                    for (int y = 0; y < pi.matrix.GetLength(1); y++)
                    {
                        if (pi.matrix[x, y] == 1) richTextBox1.Text += "G11 X" + (x * pi.pnGridGap).ToString() + "  Y" + (y * pi.pnGridGap).ToString() + "\r\n";
                    }
                }
            }

            // Left-Botton
            if (rdLeftBottom.Checked)
            {
                for (int x = 0; x < pi.matrix.GetLength(0); x++)
                {
                    for (int y = pi.matrix.GetLength(1) - 1; y >= 0; y--)
                    {
                        if (pi.matrix[x, y] == 1) richTextBox1.Text += "G11 X" + (x * pi.pnGridGap).ToString() + "  Y" + ((pi.matrix.GetLength(1) - y - 1) * pi.pnGridGap).ToString() + "\r\n";
                    }
                }
            }

            richTextBox1.Text += "M02\r\n";
        }

        private void btnSaveToNCFile_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Trim() == string.Empty) return;

            saveFileDialog1.Filter = "NC파일|*.nc";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pi.pnFileName = saveFileDialog1.FileName;

                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text.Replace("\n", "\r\n").Trim());

                MessageBox.Show("Save OK");

                Process.Start("explorer.exe", "/select, \"" + saveFileDialog1.FileName + "\"");
            }
        }

        private void btnGridControl_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.Enabled = false;

            if (btn.Text == "LEFT")
            {
                for (int y = 0; y < pi.matrix.GetLength(1); y++)
                {
                    for (int x = 1; x < pi.matrix.GetLength(0); x++)
                    {
                        pi.matrix[x - 1, y] = pi.matrix[x, y];
                        if (pi.matrix[x - 1, y] == 1) matrix2[x - 1, y] = 1;
                        pi.matrix[x, y] = 0;
                    }
                }
            }

            if (btn.Text == "RIGHT")
            {
                for (int y = 0; y < pi.matrix.GetLength(1); y++)
                {
                    for (int x = pi.matrix.GetLength(0) - 2; x >= 0; x--)
                    {
                        pi.matrix[x + 1, y] = pi.matrix[x, y];
                        if (pi.matrix[x + 1, y] == 1) matrix2[x + 1, y] = 1;
                        pi.matrix[x, y] = 0;
                    }
                }
            }

            if (btn.Text == "UP")
            {
                for (int x = 0; x < pi.matrix.GetLength(0); x++)
                {
                    for (int y = 1; y < pi.matrix.GetLength(1); y++)
                    {
                        pi.matrix[x, y-1] = pi.matrix[x, y];
                        if (pi.matrix[x, y-1] == 1) matrix2[x, y-1] = 1;
                        pi.matrix[x, y] = 0;
                    }
                }
            }

            if (btn.Text == "DOWN")
            {
                for (int x = 0; x < pi.matrix.GetLength(0); x++)
                {
                    for (int y = pi.matrix.GetLength(1) - 2; y >= 0; y--)
                    {
                        pi.matrix[x, y + 1] = pi.matrix[x, y];
                        if (pi.matrix[x, y + 1] == 1) matrix2[x, y + 1] = 1;
                        pi.matrix[x, y] = 0;
                    }
                }
            }

            panel1_Paint(null, null);

            btn.Enabled = true;
        }
    }
}










































