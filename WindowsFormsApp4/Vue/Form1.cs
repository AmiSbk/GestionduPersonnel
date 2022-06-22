using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtxtPersonnel_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
    
=======
            rtxtPersonnel.
>>>>>>> 4ad01542c705e164cdca166fb77b9b8254af4ed0
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {
            txtNOm.Enabled = true;
            txtNOm.Focus();

            if (txtNOm.TextLength>=3)
            {
                txtPrenom.Focus();
            }
            if (txtPrenom.TextLength >= 3)
            {
                txtTel.Focus();
            }
        }
=======
>>>>>>> 4ad01542c705e164cdca166fb77b9b8254af4ed0
    }
}
