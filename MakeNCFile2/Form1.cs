using MakeNCFile2.Forms;
using MakeNCFile2.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeNCFile2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Menu - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Menu - New Grid
        private void newGridToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            FrmCreateGrid cd = new FrmCreateGrid();
            PanelInfo pi = new PanelInfo();
            pi.init();
            cd.pi = pi;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                FrmGridMain mm = new FrmGridMain();
                mm.pi = cd.pi;
                mm.MdiParent = this;
                mm.Show();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    PanelInfo pi = new PanelInfo();
                    pi.init();

                    PanelInfo pi2 = new PanelInfo();
                    pi2.init();

                    BinaryFormatter bf = new BinaryFormatter();
                    pi = (PanelInfo)bf.Deserialize(fs);
                    fs.Seek(0, SeekOrigin.Begin);
                    pi2.matrix = new int[pi.pnSize.Width, pi.pnSize.Height];
                    pi2 = (PanelInfo)bf.Deserialize(fs);

                    FrmGridMain mm = new FrmGridMain();
                    mm.pi = pi2;
                    mm.MdiParent = this;
                    mm.Show();
                }
            }
        }
    }
}
