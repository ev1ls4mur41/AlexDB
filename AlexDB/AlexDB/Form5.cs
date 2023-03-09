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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AlexDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AlexDataSet.Должности' table. You can move, or remove it, as needed.
            this.должностиTableAdapter.Fill(this.dB_AlexDataSet.Должности);

        }
    }
}
