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
using Ispan_midProject_DalLib47;
using Ispan_midProject_BllLib47.Interface;
using Ispan_midProject_BllLib47;

namespace Ispan_midProject_WinForm47
{
    public partial class FormProductManagement : Form
    {
        private readonly IProductRepository repo;

        public FormProductManagement()
        {
            InitializeComponent();
            Load += FormProductManagement_Load;
            this.repo = new ProductRepository();
        }

        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            LoadDataAll();
        }

        private void LoadDataAll()
        {
            ProductService service = new ProductService(repo);
            dataGridView1.DataSource = service.GetAll();
        }

        private void buttonSearchAll_Click(object sender, EventArgs e)
        {
            ProductService service = new ProductService(repo);
            dataGridView1.DataSource = service.GetAll();
        }
    }
}
