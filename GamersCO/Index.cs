using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamersCO
{
    public partial class Index : Form
    {      

        public Index()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            st.Show();            
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Insert ns = new Insert();
            ns.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
