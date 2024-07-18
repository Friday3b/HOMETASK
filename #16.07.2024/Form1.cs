namespace _16._07._2024;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using _16._07._2024.Models.Concretes;
using _16._07._2024.Data;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        InitializeListView();
    }


    private void InitializeListView()
    {
        
        listView1.View = View.Details;
        listView1.Columns.Add("Name", 90, HorizontalAlignment.Left);
        listView1.Columns.Add("Description", 90, HorizontalAlignment.Left);
        listView1.Columns.Add("Category", 90, HorizontalAlignment.Left);
        listView1.Columns.Add("Price", 50, HorizontalAlignment.Right);
        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
    }
    private void clickbutton_Click(object sender, EventArgs e)
    {


            var context = new AppDbContext();
        
            var product = new Product
            {
                Name = nametextBox.Text,
                Description = desctextBox.Text,
                Price = pricetextBox.Text
            };

            context.Products.Add(product);
            context.SaveChanges();


            ListViewItem item = new ListViewItem(nametextBox.Text);
            item.SubItems.Add(desctextBox.Text);
            item.SubItems.Add(categorycomboBox.Text);
            item.SubItems.Add(pricetextBox.Text);
            listView1.Items.Add(item);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

        
    }
}
