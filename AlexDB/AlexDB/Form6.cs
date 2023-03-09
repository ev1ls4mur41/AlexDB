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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AlexDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AlexDataSet.Сотрудники' table. You can move, or remove it, as needed.
            this.сотрудникиTableAdapter.Fill(this.dB_AlexDataSet.Сотрудники);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveFirst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.сотрудникиBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_AlexDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            frm.Show();
        }
    }
}
