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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void валютаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.валютаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AlexDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AlexDataSet.Валюта' table. You can move, or remove it, as needed.
            this.валютаTableAdapter.Fill(this.dB_AlexDataSet.Валюта);

        }
    }
}
