using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ispan_midProject_BllLib47;
using Ispan_midProject_BllLib47.EF_CodeFirst;
using Ispan_midProject_BllLib47.Interface;
using Ispan_midProject_DalLib47;

namespace Ispan_midProject_WinForm47
{
    public partial class BackStageMain : Form
    {
        public BackStageMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void 產品總管ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormProductEdit();
            frm.Owner= this;
            frm.Show();
        }
    }
}
