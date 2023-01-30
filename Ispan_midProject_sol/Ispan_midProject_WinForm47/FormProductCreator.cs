using Ispan_midProject_BllLib47.EF_CodeFirst;
using Ispan_midProject_BllLib47.Interface;
using Ispan_midProject_BllLib47;
using Ispan_midProject_DalLib47;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispan_midProject_WinForm47
{
    public partial class FormProductCreator : Form
    {
        private ProductService _service;
        private Product _product;
        private readonly IProductRepository repo;
        public string PicturePath { get; private set; }


        public FormProductCreator()
        {
            InitializeComponent();
            this.repo = new ProductRepository();
            this._service = new ProductService(repo);

        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            Product entity = new Product()
            {
                Name = textBoxProductName.Text,
                ProductNumber = textBoxProductName.Text,
                ListPrice = Convert.ToInt32(textBoxPrice.Text),
                StandardCost = Convert.ToInt32(textBoxCost.Text),
                SellStartDate = dateTimeStartSellTime.Value,
                SellEndDate = null,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                rowguid = Guid.NewGuid()
        };
            _service.Create(entity);

            //
            IGridProductContainer container = this.Owner as IGridProductContainer;
            if (container != null) container.Display();

            this.DialogResult = DialogResult.OK;
        }
    }
}
