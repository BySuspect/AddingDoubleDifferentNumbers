using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingDoubleDifferentNumbers
{
    public partial class Form1 : Form
    {
        int num1 = 0, num2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnum1.Text.Trim() != String.Empty && txtnum2.Text.Trim() != String.Empty)
                {
                    num1 += Convert.ToInt32(txtnum1.Text);
                    num2 += Convert.ToInt32(txtnum2.Text);

                    lblnum1.Text = num1.ToString();
                    lblnum2.Text = num2.ToString();

                    var lvItem = new ListViewItem();
                    lvItem.Text = txtnum1.Text;
                    lvItem.SubItems.Add(txtnum2.Text);
                    lvCollection.Items.Add(lvItem);

                    txtnum1.Text = String.Empty;
                    txtnum2.Text = String.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd_Click(null, null);
                txtnum1.Focus();
            }
        }
    }
}
