using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Util;
using Npgsql;

namespace DBHelper
{
    public class Helper
    {
        //Objeto que Representa una caché de datos en memoria
        private DataSet ds = new DataSet();

        //Objeto que Representa una tabla de datos en memoria.
        private DataTable dt = new DataTable();

        //objeto para la conexion
        private String conn = "Host=localhost; Port=5432; Username=postgres; Password=ascend; Database=gamersco";

        Util.Data data = new Data();

        public DataTable Select(string key, string word) {

            var keyConverted = data.Convert(key);

            //Pasamos objeto conexion
            var cn = new NpgsqlConnection(conn);

            //Abrimos conexion
            cn.Open();

            //Reestablecemos el Dataset
            ds.Reset();

            if (word == "")
            {
                var query = "SELECT * FROM tbl_action UNION SELECT * FROM tbl_adventure UNION "+
                            "SELECT * FROM tbl_driving UNION SELECT * FROM tbl_indie UNION " +
                            "SELECT * FROM tbl_mmo UNION SELECT * FROM tbl_moba UNION "+
                            "SELECT * FROM tbl_sport UNION SELECT * FROM tbl_strategy UNION "+
                            "SELECT * FROM tbl_terror";

                //adapter para hacer la peticion a la conexion
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cn);
                //Llenamos dataset con el resultado del adapter
                da.Fill(ds);

                //Porque puede manejar varias tablas, Seleccionamos la primera
                dt = ds.Tables[0];
            }
            else
            if (keyConverted == "release")
            {
                var query = "SELECT * FROM tbl_action WHERE act_release = '"+ word +"' UNION SELECT * FROM tbl_adventure WHERE adv_release = '"+ word +"' UNION "+
                            "SELECT * FROM tbl_driving WHERE dri_release = '"+ word +"' UNION SELECT *FROM tbl_indie WHERE ind_release = '"+ word +"' UNION "+
                            "SELECT * FROM tbl_mmo WHERE mmo_release = '"+ word +"' UNION SELECT * FROM tbl_moba WHERE mob_release = '"+ word +"' UNION "+
                            "SELECT * FROM tbl_sport WHERE spo_release = '"+ word +"' UNION SELECT * FROM tbl_strategy WHERE str_release = '"+ word +"' UNION "+
                            "SELECT * FROM tbl_terror WHERE ter_release = '"+ word +"'";

                //adapter para hacer la peticion a la conexion
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cn);
                //Llenamos dataset con el resultado del adapter
                da.Fill(ds);

                //Porque puede manejar varias tablas, Seleccionamos la primera
                dt = ds.Tables[0];
            }
            else
            if(keyConverted == "rating")
            {
                var query = "SELECT * FROM tbl_action WHERE act_rating = " + word+ " UNION SELECT * FROM tbl_adventure WHERE adv_rating = "+ word +" UNION "+
                            "SELECT * FROM tbl_driving WHERE dri_rating = " + word + " UNION SELECT * FROM tbl_indie WHERE ind_rating = " + word + " UNION " +
                            "SELECT * FROM tbl_mmo WHERE mmo_rating = " + word + " UNION SELECT * FROM tbl_moba WHERE mob_rating = " + word + " UNION " +
                            "SELECT * FROM tbl_sport WHERE spo_rating = " + word + " UNION SELECT * FROM tbl_strategy WHERE str_rating = " + word + " UNION " +
                            "SELECT * FROM tbl_terror WHERE ter_rating = " + word + "";
                            
                //adapter para hacer la peticion a la conexion
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cn);
                //Llenamos dataset con el resultado del adapter
                da.Fill(ds);

                //Porque puede manejar varias tablas, Seleccionamos la primera
                dt = ds.Tables[0];
            }
            else
            {

                var query = "SELECT * FROM tbl_action  WHERE act_" + keyConverted + " ILIKE '%" + word + "%' UNION SELECT * FROM tbl_adventure WHERE adv_" +keyConverted+" ILIKE '%"+word+"%' UNION "+
                            "SELECT * FROM tbl_driving  WHERE dri_" + keyConverted + " ILIKE '%" + word + "%' UNION SELECT * FROM tbl_indie WHERE ind_" + keyConverted + " ILIKE '%" + word + "%' UNION " +
                            "SELECT * FROM tbl_mmo  WHERE mmo_" + keyConverted + " ILIKE '%" + word + "%' UNION SELECT * FROM tbl_moba WHERE mob_" + keyConverted + " ILIKE '%" + word + "%' UNION " +
                            "SELECT * FROM tbl_sport  WHERE spo_" + keyConverted + " ILIKE '%" + word + "%' UNION SELECT * FROM tbl_strategy WHERE str_" + keyConverted + " ILIKE '%" + word + "%' UNION " +
                            "SELECT * FROM tbl_terror  WHERE ter_" + keyConverted + " ILIKE '%" + word + "%'";


                //adapter para hacer la peticion a la conexion
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cn);

                //Llenamos dataset con el resultado del adapter
                da.Fill(ds);

                //Porque puede manejar varias tablas, Seleccionamos la primera
                dt = ds.Tables[0];
                
            }
            
            //Cerramos conexion
            cn.Close();

            //retornamos objeto datatable
            return dt;
        }


        public DataTable SelectCategory(string word)
        {
            var cn = new NpgsqlConnection(conn);
            var query = "";

            cn.Open();

            var wordConverted = data.ConvertCategory(word);

            switch(wordConverted)
            {
                case "action":
                        query = "SELECT * FROM tbl_action";
                    break;
                case "adventure":
                    query = "SELECT * FROM tbl_adventure";
                    break;
                case "driving":
                    query = "SELECT * FROM tbl_driving";
                    break;
                case "indie":
                    query = "SELECT * FROM tbl_indie";
                    break;
                case "mmo":
                    query = "SELECT * FROM tbl_mmo";
                    break;
                case "moba":
                    query = "SELECT * FROM tbl_moba";
                    break;
                case "sport":
                    query = "SELECT * FROM tbl_sport";
                    break;
                case "strategy":
                    query = "SELECT * FROM tbl_strategy";
                    break;
                case "terror":
                    query = "SELECT * FROM tbl_terror";
                    break;
                default:
                    break;
            }

            //adapter para hacer la peticion a la conexion
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cn);

            //Llenamos dataset con el resultado del adapter
             da.Fill(ds);

            //Porque puede manejar varias tablas, Seleccionamos la primera
            dt = ds.Tables[0];

            //Cerramos conexion
            cn.Close();

            //retornamos objeto datatable
            return dt;
        }

        public void Insert(string[] objInsert)
        {
            //Pasamos objeto conexion
            var cn = new NpgsqlConnection(conn);

            //Abrimos conexion
            cn.Open();

            var category = data.ConvertCategory(objInsert[2]);
            var require = data.convertRequire(objInsert[5]);


            var query = "INSERT INTO tbl_"+ category +" VALUES ("+objInsert[0]+",'"+ objInsert[1] +"','"+ objInsert[3]+"','"+ objInsert[4] +"',"+require+", "+objInsert[6]+") ";

            NpgsqlCommand cmd = new NpgsqlCommand(query,cn);
            cmd.ExecuteNonQuery();

            cn.Close();

        }

        public void Delete(string key, string word)
        {

            var cn = new NpgsqlConnection(conn);

            var category = data.ConvertCategory(key);
            var nick = data.convertNick(key);

            var query="DELETE FROM tbl_"+category+" WHERE "+nick+"_id = "+word+"";

            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, cn);
            cmd.ExecuteNonQuery();

            cn.Close();


        }

        public DataTable SelectRequire()
        {
            NpgsqlConnection cn = new NpgsqlConnection(conn);

            cn.Open();

            var query = "SELECT * FROM tbl_pc_require";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, cn);

            //Llenamos
            da.Fill(ds);
            //Cargamos
            dt = ds.Tables[0];

            cn.Close();

            return dt;
        }

        public Boolean Check(string key, string word)
        {

            var nick= data.convertNick(key);
            var category = data.ConvertCategory(key);

            var cn = new NpgsqlConnection(conn);

            Boolean flag=false;
            var num=0;

            var query = "SELECT * FROM tbl_"+category+" WHERE "+nick+"_id = "+word+"";

            cn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, cn);
            cmd.ExecuteNonQuery();

            try
            {
                num = (Int32)cmd.ExecuteScalar();
            }
            catch (Exception )
            {
            }
            
            if (num != 0)
            {
                flag = true;
            }

            cn.Close();

            return flag;
            
        }
    }
}
