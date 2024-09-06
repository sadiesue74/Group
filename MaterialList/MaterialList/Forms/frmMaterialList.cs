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
        private List<ItemInfo> _Items = new List<ItemInfo>() { };
        private BindingSource bind = new BindingSource();
        public frmMaterialList()
        {
            InitializeComponent();
            RefreshGrid();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //Run Calculations
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save to excel
            //Via interop?
            //Or Open XML package
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear List
            bind.DataSource = null;
            dataGridView1.DataSource = null;
            _Items.Clear();
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            bind.DataSource = _Items;
            dataGridView1.DataSource = bind;
            dataGridView1.Refresh();
        }
    }
}
