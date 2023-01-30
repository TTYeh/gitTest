using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ispan_midProject_BllLib47.EF_CodeFirst;

namespace Ispan_midProject_WinForm47
{
    public partial class FormProductCategory : Form
    {
        public FormProductCategory()
        {
            InitializeComponent();
            Load += FormProductCategory_Load;
        }

        private void FormProductCategory_Load(object sender, EventArgs e)
        {
            using (var db = new EF_Travel_Model())
            {
                var linq = from pc in db.ProductCategories
                           select new {
                           id = pc.ProductCategoryID,
                            a = pc.ParentProductCategoryID,
                            b = pc.Name
                           }
                           ;
                dataGridView1.DataSource= linq.ToArray();
            }
            
        }
    }
}
