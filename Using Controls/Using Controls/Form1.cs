using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                MessageBox.Show("Index#: " + indexChecked.ToString() + ", is checked. Checked state is:" +
                                checkedListBox1.GetItemCheckState(indexChecked).ToString() + ".");
            }

            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {

                MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
                                "\", is checked. Checked state is: " +
                                checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString() + ".");
            }
        }

       
        

    }
}
