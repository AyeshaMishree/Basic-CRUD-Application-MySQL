using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_conn
{
    public partial class form_initial : Form
    {
        public form_initial()
        {
            InitializeComponent();
        }

        private void cont_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void form_initial_Load(object sender, EventArgs e)
        {

        }
    }
}
