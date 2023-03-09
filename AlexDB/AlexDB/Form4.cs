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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void вкладыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вкладыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AlexDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AlexDataSet.Вклады' table. You can move, or remove it, as needed.
            this.вкладыTableAdapter.Fill(this.dB_AlexDataSet.Вклады);

        }
    }
}
