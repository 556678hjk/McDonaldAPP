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
            // TODO: 這行程式碼會將資料載入 'newNutritionDataSet.ProductNutrition' 資料表。您可以視需要進行移動或移除。
            this.productNutritionTableAdapter.Fill(this.newNutritionDataSet.ProductNutrition);
            // TODO: 這行程式碼會將資料載入 'newNutritionDataSet.LastProductID' 資料表。您可以視需要進行移動或移除。
            this.lastProductIDTableAdapter.Fill(this.newNutritionDataSet.LastProductID);
            // TODO: 這行程式碼會將資料載入 'newNutritionDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter4.Fill(this.newNutritionDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'mcDonaldDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter3.Fill(this.mcDonaldDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'mcDonaldDataSet.ProductType' 資料表。您可以視需要進行移動或移除。
            this.productTypeTableAdapter2.Fill(this.mcDonaldDataSet.ProductType);
            // TODO: 這行程式碼會將資料載入 'nutritionFactDataSet.DataTable1' 資料表。您可以視需要進行移動或移除。
            //this.dataTable1TableAdapter.Fill(this.nutritionFactDataSet.DataTable1);
            // TODO: 這行程式碼會將資料載入 'nutritionFactDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter2.Fill(this.nutritionFactDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'productSearchDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter1.Fill(this.productSearchDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'productType_ProductDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.productType_ProductDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'productType_ProductDataSet.ProductType' 資料表。您可以視需要進行移動或移除。
            this.productTypeTableAdapter1.Fill(this.productType_ProductDataSet.ProductType);
            // TODO: 這行程式碼會將資料載入 'productTypeDataSet.ProductType' 資料表。您可以視需要進行移動或移除。
            this.productTypeTableAdapter.Fill(this.productTypeDataSet.ProductType);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productTableAdapter1.FillBy(this.productSearchDataSet.Product, keywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productTableAdapter3.InsertQuery(
                int.Parse(comboBox2.SelectedValue.ToString()),
                textBox1.Text
            );
            productTableAdapter3.Fill(mcDonaldDataSet.Product);
            MessageBox.Show("Product Successfully added.");
            //productTableAdapter.Fill(ProductType_ProductDataSet.Product);
        }


        private void onMN(object sender, EventArgs e)
        {
            missingNutritionFactTableAdapter.Fill(
               newNutritionDataSet.MissingNutritionFact,
               int.Parse(iDTextBox1.Text)
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productNutritionTableAdapter.InsertQuery(
            int.Parse(iDTextBox1.Text),
            int.Parse(nutritionComboBox.SelectedValue.ToString()),
            double.Parse(textBox2.Text)
            );
            productNutritionTableAdapter.Fill(newNutritionDataSet.ProductNutrition);
        }

        private void categoriesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productTableAdapter4.DeleteQuery(int.Parse(iDTextBox1.Text));
            productNutritionTableAdapter.Fill(newNutritionDataSet.ProductNutrition);
            productTableAdapter4.Fill(newNutritionDataSet.Product);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }
    }
}