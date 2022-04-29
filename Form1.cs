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
        
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            decimal total = 0;
            lstProduto.Items.Add(txtProduto.Text);
            lstPreco.Items.Add(txtPreco.Text);          
                        
            for (int i = 0; i < lstPreco.Items.Count; i++)
            {
                total += Convert.ToDecimal(lstPreco.Items[i]);
            }

            lblTotal.Text = $"Total R$: {Convert.ToString(total)}";
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            int ind = lstProduto.SelectedIndex;
            lstProduto.Items.RemoveAt(ind);
            lstPreco.Items.RemoveAt(ind);

            for (int j = 0; j < lstPreco.Items.Count; j++)
            {
                total += Convert.ToDecimal(lstPreco.Items[j]);
            }
            lblTotal.Text = $"Total R$: {Convert.ToString(total)}";
        }
    }
}
