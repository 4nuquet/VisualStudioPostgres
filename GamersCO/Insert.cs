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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string [] objInsert;
            objInsert = new string[7];
            Boolean flag = false;
            

            DBHelper.Helper helper = new Helper();

            objInsert[0] = txt_Id.Text.ToString();
            objInsert[1] = txt_Name.Text.ToString();
            objInsert[2] = cbx_Category.SelectedItem.ToString();
            objInsert[3] = txt_Platform.Text.ToString();
            objInsert[4] = txt_Release.Text.ToString();
            objInsert[5] = cbx_Require.SelectedItem.ToString();
            objInsert[6] = txt_Rating.Text.ToString();

            String wrong = "El id: " + objInsert[0] + " ya se encuentra registrado";     
            String success = "Se Registro Correctamente \n Juego: "+ objInsert[1] + "\n Categoria: "+ objInsert[2] +"";

            flag = helper.Check(objInsert[2], objInsert[0]);

            if(flag == true)
            {
                MessageBox.Show(wrong,"Campo Existente",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                helper.Insert(objInsert);
                MessageBox.Show(success, "Registro Exitoso", MessageBoxButtons.OK);
            }
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = txt_Id.Text.ToString();
            var category = cbx_Category.SelectedItem.ToString();

            DBHelper.Helper helper = new Helper();

            Boolean flag = false;

            string success = "Juego Eliminado Correctamente";
            string wrong = "El Id " + id + " No existe en la Categoria " + category + "";

            flag = helper.Check(category, id);

            if(flag == true)
            {
                helper.Delete(category, id);
                MessageBox.Show(success, "Exitoso");
            }
            else
            {
                MessageBox.Show(wrong, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Require_Click(object sender, EventArgs e)
        {
            Require rq = new Require();
            rq.Show();
            
        }
    }
}
