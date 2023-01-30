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
using Ispan_midProject_WinForm47.VM_Models;

namespace Ispan_midProject_WinForm47
{
    public interface IGridProductContainer
    {
        void Display();

    }
    public partial class FormProductManagement : Form, IGridProductContainer
    {
        private readonly IProductRepository repo;
        private ProductService _service { get; set; }
        private List<Product> _products;
        private List<ProductSearchVM> _productsSearchVM;

        public FormProductManagement()
        {
            InitializeComponent();
            Load += FormProductManagement_Load;
            this.repo = new ProductRepository();
            this._service = new ProductService(repo);
        }

        private void FormProductManagement_Load(object sender, EventArgs e)
        {
            LoadDataAll();
        }

        private void LoadDataAll()
        {
            Display();
        }

        public void Display()
        {
            _products = _service.GetAll();
            _productsSearchVM = new List<ProductSearchVM>();
            for (int i = 0; i < _products.Count; i++)
            {
                var tmp = new ProductSearchVM
                {
                    ProductID = _products[i].ProductID,
                    Name = _products[i].Name,
                    ProductNumber = _products[i].ProductNumber,
                    ListPrice = _products[i].ListPrice,
                    StandardCost = _products[i].StandardCost,
                    SellStartDate = _products[i].SellStartDate,
                    SellEndDate = _products[i].SellEndDate,
                    CreatedDate = _products[i].CreatedDate,
                    ModifiedDate = _products[i].ModifiedDate,

                };
                _productsSearchVM.Add(tmp);
            }
            dataGridViewProducts.DataSource = _productsSearchVM;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return;

            //// int pk = this._products[e.RowIndex].ProductID;
            //var frm = new FormProductCreate(this._products[e.RowIndex]);
            //frm.Owner = this;
            //frm.ShowDialog();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            var frm = new FormProductCreator();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int prdId = _productsSearchVM[dataGridViewProducts.CurrentRow.Index].ProductID;
            var frm = new FormProductEdit(prdId);
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int prdId = _productsSearchVM[dataGridViewProducts.CurrentRow.Index].ProductID;
            _service.DeleteById(prdId);
            Display();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
