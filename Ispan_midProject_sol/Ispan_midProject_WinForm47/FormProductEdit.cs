using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ispan_midProject_BllLib47.EF_CodeFirst;
using Ispan_midProject_BllLib47;
using Ispan_midProject_BllLib47.Interface;
using Ispan_midProject_DalLib47;

namespace Ispan_midProject_WinForm47
{
    public partial class FormProductEdit : Form
    {
        private int Id;
        private ProductService _service;
        private Product _product;
        private readonly IProductRepository repo;

        public string PicturePath { get; private set; }

        public FormProductEdit(int Id)
        {
            InitializeComponent();
            this.repo = new ProductRepository();
            this._service = new ProductService(repo);

            this.Id = Id;
            this._product = _service.GetById(Id);
            Display();
        }

        private void Display()
        {
            textBoxProductName.Text =  _product.Name;
            textBoxPN.Text = _product.ProductNumber.ToString();
            textBoxPrice.Text = _product.ListPrice.ToString();
            textBoxCost.Text = _product.StandardCost.ToString();
            dateTimeStartSellTime.Text = _product.SellStartDate.ToString();
            dateTimeEndSellTime.Text = _product.SellEndDate.ToString();
            //dateTimeEndSellTime.CustomFormat = " ";
            //if (_product.SellEndDate != null)
            //{
            //    dateTimeEndSellTime.Format = DateTimePickerFormat.Short;
            //    dateTimeEndSellTime.Text = _product.SellEndDate.Value.ToString();
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPicViewer_Click(object sender, EventArgs e)
        {
            this.PicturePath = $@"\source\image_hw";
            if (this.PicturePath != null)
            {
                Form frm = new FormProductPictureViewer(this.PicturePath);
                frm.ShowDialog();
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddPicture_Click(object sender, EventArgs e)
        {
            //OpenFileDialog
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {

        }
    }
    //public class ProductDto
    //{
    //    public int ProductID { get; set; }

    //    [Required]10
    //    [StringLength(50)]
    //    public string Name { get; set; }

    //    [Required]
    //    [StringLength(25)]
    //    public string ProductNumber { get; set; }

    //    [Column(TypeName = "money")]
    //    public decimal ListPrice { get; set; }

    //    [Column(TypeName = "money")]
    //    public decimal StandardCost { get; set; }

    //    public DateTime SellStartDate { get; set; }

    //    public DateTime? SellEndDate { get; set; }

    //    [MaxLength(50)]
    //    public byte[] BlobId { get; set; }

    //    public int? ProductCategoryID { get; set; }

    //    public int? ProductModelID { get; set; }

    //    public Guid rowguid { get; set; }

    //    public DateTime CreatedDate { get; set; }

    //    public DateTime ModifiedDate { get; set; }

    //    public virtual ProductCategory ProductCategory { get; set; }

    //    public virtual ProductModel ProductModel { get; set; }

    //    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    //    public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    //}
}
