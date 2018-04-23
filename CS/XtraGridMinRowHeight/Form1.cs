using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using MinRowHeightXtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace XtraGridMinRowHeight {
    public partial class Form1 : Form {

        GridControl grid;

        public Form1() {
            InitializeComponent();
        }

        List<InvoiceItem> CreateItems() {
            List<InvoiceItem> items = new List<InvoiceItem>();
            Random rnd = new Random();
            for(int i = 0; i < 10; i++) {
                int counter = i + 1;
                items.Add(new InvoiceItem("Item " + counter.ToString(), rnd.Next(300), rnd.Next(20)));
            }
            return items;
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.grid = new MinRowHeightGridControl();
            grid.Dock = DockStyle.Fill;
            grid.MainView = new MinRowHeightGridView(grid);
            Controls.Add(grid);
            grid.DataSource = CreateItems();
            grid.BringToFront();
        }

        private void btnFont_Click(object sender, EventArgs e) {
            FontDialog dialog = new FontDialog();
            dialog.Font = ((GridView)grid.MainView).Appearance.Row.Font;
            if(dialog.ShowDialog() == DialogResult.OK) {
                ((GridView)grid.MainView).Appearance.Row.Font = dialog.Font;
            }
        }

    }

    public class InvoiceItem {
        string name;
        decimal price;
        int quantity;


        public InvoiceItem(string name, decimal price, int quantity) {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string Name { get { return name; } set { name = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public decimal Total { get { return Price * Quantity; } }
    }

}