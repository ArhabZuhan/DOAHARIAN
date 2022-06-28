using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAHARIAN
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dOA_DOA_HARIANNDataSet.Doa' table. You can move, or remove it, as needed.
            this.doaTableAdapter.Fill(this.dOA_DOA_HARIANNDataSet.Doa);

        }
    }
}
