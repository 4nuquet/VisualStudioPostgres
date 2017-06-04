using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBHelper;

namespace GamersCO
{
    public partial class Stock : Form
    {
        
        public Stock()
        {
            InitializeComponent();
        }

        private void btn_Insert2_Click(object sender, EventArgs e)
        {
            Insert ns = new Insert();
            ns.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DBHelper.Helper helper = new Helper();

            var word = txt_Search.Text.ToString();
            var key = cbx_Search.SelectedItem.ToString();

            //llenamos GridView con DataTable de DBHelper
            dgview_Result.DataSource = helper.Select(key, word);

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            DBHelper.Helper helper = new Helper();

            var word = cbx_Filter.SelectedItem.ToString();

            dgview_Result.DataSource = helper.SelectCategory(word);
        }
    }
}
