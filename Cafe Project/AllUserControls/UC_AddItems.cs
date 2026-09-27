using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Project.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            long price;

            if (!long.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Enter valid numeric price", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtItemName.Text.Trim() == "")
            {
                MessageBox.Show("Item Name cannot be empty", "Information" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Convert.ToInt64(txtPrice.Text) <= 0)
            {
                MessageBox.Show("Price must be greater than 0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dr = MessageBox.Show("Do you want to add this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.No)
            {
                return;
            }
            query = "insert into items (name,category,price) values ('" + txtItemName.Text + "', '" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
            
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
