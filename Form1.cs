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
           
        int sum2 = 0;
        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            lstProduto.Items.Add(txtProduto.Text);
            lstPreco.Items.Add(txtPreco.Text);
            int sum = int.Parse(txtPreco.Text);
            sum2 += sum;

            lblTotal.Text = $"Total: {sum2}";  
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int index = lstProduto.SelectedIndex;
            lstProduto.Items.RemoveAt(index);
            lstPreco.Items.RemoveAt(index);

            sum2 -= txtPreco.Text[index];
            
            lblTotal.Text = $"Total: {sum2}";
        }
    }
}
