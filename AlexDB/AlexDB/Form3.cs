using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexDB
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void вкладчикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вкладчикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AlexDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AlexDataSet.Вкладчики' table. You can move, or remove it, as needed.
            this.вкладчикиTableAdapter.Fill(this.dB_AlexDataSet.Вкладчики);

        }
    }
}
