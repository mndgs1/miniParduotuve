using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniParduotuve
{

    public partial class ShopForm : System.Windows.Forms.Form
    {
        public static string perkamaPreke = "";
        private const string FolderioKelias = "Prekes";
        public double price = 0;
        public double sum = 0;
        public double weight = 0;
        public double weightSum = 0;


        public ShopForm()
        {
            InitializeComponent();
            VisiFailaiEsantysFolderyje();
        }

        private void VisiFailaiEsantysFolderyje()
        {
            PrekesList.Items.Clear();
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(FolderioKelias);
            foreach (var item in dir.GetFiles())
            {
                var skaidytasPavadinimas = item.Name.Split('.');
                PrekesList.Items.Add(item.Name);
            }
        }
        public void PrekesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pasirinktasElementas = PrekesList.SelectedItem.ToString();
            System.IO.StreamReader reader = new System.IO.StreamReader(FolderioKelias + @"\" + pasirinktasElementas);
            NameText.Text = reader.ReadLine();
            SizeText.Text = reader.ReadLine();
            ShapeText.Text = reader.ReadLine();
            WeightText.Text = reader.ReadLine();
            double weight = Double.Parse(WeightText.Text);
            PriceText.Text = reader.ReadLine();
            double price = Double.Parse(PriceText.Text);
            SpecsRichText.Text = reader.ReadLine();
            reader.Close();
            reader.Dispose();
        }
        public void ToCartButton_Click(object sender, EventArgs e)
        {
            string pasirinktasElementas = PrekesList.SelectedItem.ToString();
            double sum = Double.Parse(PriceCartText.Text);
            sum += price;
        }

        private void MyCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
