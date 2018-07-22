using MakeNCFile2.Function;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeNCFile2.Forms
{
    public partial class FrmCreateGrid : Form
    {
        public PanelInfo pi = new PanelInfo();

        public FrmCreateGrid()
        {
            InitializeComponent();

            pi.init();
        }

        private void FrmCreateGrid_Load(object sender, EventArgs e)
        {
            txtSizeWidth.Text = pi.pnSize.Width.ToString();
            txtSizeHeight.Text = pi.pnSize.Height.ToString();
            if (pi.pnMarkType == 0) rdMarkCircle.Checked = true;
            if (pi.pnMarkType == 1) rdMarkRectangle.Checked = true;
            txtMarkGap.Text = pi.pnGridGap.ToString();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int width = 0, height = 0;
            double gap = 0d;

            if(Int32.TryParse(txtSizeWidth.Text, out width) && Int32.TryParse(txtSizeHeight.Text, out height))
            {
                pi.pnSize = new Rectangle(0, 0, width, height);
            }
            if (rdMarkCircle.Checked) pi.pnMarkType = 0;
            if (rdMarkRectangle.Checked) pi.pnMarkType = 1;
            if (double.TryParse(txtMarkGap.Text, out gap)) pi.pnGridGap = gap;

            DialogResult = DialogResult.OK;
        }
    }
}
