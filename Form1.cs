using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           
        decimal total = 0;
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            lstProduto.Items.Add(txtProduto.Text);
            lstPreco.Items.Add(txtPreco.Text);
            total += decimal.Parse(txtPreco.Text);
            lblTotal.Text = $"Total R$: {total}";  
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            var index = lstProduto.SelectedIndex;
            lstProduto.Items.RemoveAt(index);
            lstPreco.Items.RemoveAt(index);
            total -= decimal.Parse(lstPreco.Items[index].ToString());
            
            lblTotal.Text = $"Total: {total}";
        }
    }
}
