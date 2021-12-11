using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace McDonaldAPP_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productTypeDataSet);

        }

        private void productTypeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productTypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productTypeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'productType_ProductDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.productType_ProductDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'productType_ProductDataSet.ProductType' 資料表。您可以視需要進行移動或移除。
            this.productTypeTableAdapter1.Fill(this.productType_ProductDataSet.ProductType);
            // TODO: 這行程式碼會將資料載入 'productTypeDataSet.ProductType' 資料表。您可以視需要進行移動或移除。
            this.productTypeTableAdapter.Fill(this.productTypeDataSet.ProductType);

        }
    }
}
