using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialList.Forms
{
    public partial class frmMaterialList : Form
    {
        private List<ItemInfo> _Items = new List<ItemInfo>();
        private BindingSource bind = new BindingSource();
        public frmMaterialList()
        {
            InitializeComponent();
            bind.DataSource = _Items;
            dataGridView1.DataSource = bind;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Show dialog to add new item to list
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Run Calculations
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save to excel
            //Via interop?
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear List
        }

    }
}
