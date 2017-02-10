using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshaverAmlak
{
    class DataBaseHandler
    {
        string conString = "Data Source= 185.159.152.2;" +
                "Initial Catalog=rayanpro_amlak;" +
                "User id=rayanpro_user; " +
                "Password=P@hn1395;";



        /// <summary>
        /// querry for proposals
        /// </summary>
        /// <param name="proposal"></param>
        /////////query for apartman////////////////
        public void AddApartman(Apartman apartman)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO apartman (apartman_ab,apartman_bargh,apartman_gaz,apartman_tel,apartman_#tabaghat,apartman_tabaghe,apartman_asansor,apartman_saleSakht,apartman_kafposh,apartman_nama,apartman_teras,apartman_hayat,apartman_metrazh,apartman_parking,apartman_#otagh,apartman_kabinet,apartman_anbar,apartman_#vahedTabaghe,apartman_noeKarbari,apartman_tozih,apartman_address,apartman_mantaghe,apartman_malekncode)"
                                + "VALUES ('" + apartman.Apartman_ab + "'"
                                         + "'" + apartman.Apartman_bargh + "'"
                                         + "'" + apartman.Apartman_gaz + "'"
                                         + "'" + apartman.Apartman_tel + "'"
                                         + "'" + apartman.Apartman_tedadTabaghat + "'"
                                         + "'" + apartman.Apartman_tabaghe + "'"
                                         + "'" + apartman.Apartman_asansor + "'"
                                         + "'" + apartman.Apartman_saleSakht + "'"
                                         + "'" + apartman.Apartman_kafposh + "'"
                                         + "'" + apartman.Apartman_nama + "'"
                                         + "'" + apartman.Apartman_teras + "'"
                                         + "'" + apartman.Apartman_hayat + "'"
                                         + "'" + apartman.Apartman_metrazh + "'"
                                         + "'" + apartman.Apartman_parking + "'"
                                         + "'" + apartman.Apartman_tedadOtagh + "'"
                                         + "'" + apartman.Apartman_kabinet + "'"
                                         + "'" + apartman.Apartman_anbar + "'"
                                         + "'" + apartman.Apartman_tedadVahedTabaghe + "'"
                                         + "'" + apartman.Apartman_noeKarbari + "'"
                                         + "'" + apartman.Apartman_tozih + "'"
                                         + "'" + apartman.Apartman_address + "'"
                                         + "'" + apartman.Apartman_mantaghe + "'"
                                         + "'" + apartman.Apartman_malekncode + "')";


                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditApartman(Apartman apartman)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE apartman SET apartman_ab = " + "'" + apartman.Apartman_ab + "'"
                                                    + "apartman_bargh =" + "'" + apartman.Apartman_bargh + "'"
                                                    + "apartman_gaz =" + "'" + apartman.Apartman_gaz + "'"
                                                    + "apartman_tel =" + "'" + apartman.Apartman_tel + "'"
                                                    + "apartman_#tabaghat = " + "'" + apartman.Apartman_tedadTabaghat + "'"
                                                    + " apartman_tabaghe = " + "'" + apartman.Apartman_tabaghe + "'"
                                                    + "  apartman_asansor=" + "'" + apartman.Apartman_asansor + "'"
                                                    + "apartman_saleSakht=" + "'" + apartman.Apartman_saleSakht + "'"
                                                    + "apartman_kafposh =" + "'" + apartman.Apartman_kafposh + "'"
                                                    + " apartman_nama = " + "'" + apartman.Apartman_nama + "'"
                                                    + "apartman_teras =" + "'" + apartman.Apartman_teras + "'"
                                                    + "apartman_hayat =" + "'" + apartman.Apartman_hayat + "'"
                                                    + " apartman_metrazh = " + "'" + apartman.Apartman_metrazh + "'"
                                                    + " apartman_parking = " + "'" + apartman.Apartman_parking + "'"
                                                    + " apartman_#otagh = " + "'" + apartman.Apartman_tedadOtagh + "'"
                                                    + "apartman_kabinet=" + "'" + apartman.Apartman_kabinet + "'"
                                                    + "apartman_anbar=" + "'" + apartman.Apartman_anbar + "'"
                                                    + "apartman_#vahedTabaghe=" + "'" + apartman.Apartman_tedadVahedTabaghe + "'"
                                                    + " apartman_noeKarbari=" + "'" + apartman.Apartman_noeKarbari + "'"
                                                    + "apartman_tozih=" + "'" + apartman.Apartman_tozih + "'"
                                                    + "apartman_address=" + "'" + apartman.Apartman_address + "'"
                                                    + "apartman_mantaghe=" + "'" + apartman.Apartman_mantaghe + "'"
                                                    + "apartman_malekncode=" + "'" + apartman.Apartman_malekncode + "'"
                                                    + "WHERE apartman_id = " + apartman.Apartman_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteApartman(int apartman_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM apartman WHERE apartman_id = " + apartman_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for apartman////////////////

        ///////// query for vilayi////////////////

        public void AddVilayi(Vilayi vilayi)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO vilayi (vilayi_ab,vilayi_bargh,vilayi_gaz,vilayi_tel,vilayi_#tabaghat,vilayi_tabaghe,vilayi_asansor,vilayi_saleSakht,vilayi_kafposh,vilayi_nama,vilayi_teras,vilayi_hayat,vilayi_metrazh,vilayi_parking,vilayi_#otagh,vilayi_kabinet,vilayi_anbar,vilayi_#vahedTabaghe,vilayi_noeKarbari,vilayi_tozih,vilayi_address,vilayi_mantaghe,vilayi_malekncode)"
                                + "VALUES ('" + vilayi.Vilayi_ab + "'"
                                         + "'" + vilayi.Vilayi_bargh + "'"
                                         + "'" + vilayi.Vilayi_gaz + "'"
                                         + "'" + vilayi.Vilayi_tel + "'"
                                         + "'" + vilayi.Vilayi_tedadTabaghat + "'"
                                         + "'" + vilayi.Vilayi_tabaghe + "'"
                                         + "'" + vilayi.Vilayi_asansor + "'"
                                         + "'" + vilayi.Vilayi_saleSakht + "'"
                                         + "'" + vilayi.Vilayi_kafposh + "'"
                                         + "'" + vilayi.Vilayi_nama + "'"
                                         + "'" + vilayi.Vilayi_teras + "'"
                                         + "'" + vilayi.Vilayi_hayat + "'"
                                         + "'" + vilayi.Vilayi_metrazh + "'"
                                         + "'" + vilayi.Vilayi_parking + "'"
                                         + "'" + vilayi.Vilayi_tedadOtagh + "'"
                                         + "'" + vilayi.Vilayi_kabinet + "'"
                                         + "'" + vilayi.Vilayi_anbar + "'"
                                         + "'" + vilayi.Vilayi_tedadVahedTabaghe + "'"
                                         + "'" + vilayi.Vilayi_noeKarbari + "'"
                                         + "'" + vilayi.Vilayi_tozih + "'"
                                         + "'" + vilayi.Vilayi_address + "'"
                                         + "'" + vilayi.Vilayi_mantaghe + "'"
                                         + "'" + vilayi.Vilayi_malekncode + "')";


                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditVilayi(Vilayi vilayi)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE vilayi SET vilayi_ab = " + "'" + vilayi.Vilayi_ab + "'"
                                                    + "vilayi_bargh =" + "'" + vilayi.Vilayi_bargh + "'"
                                                    + "vilayi_gaz =" + "'" + vilayi.Vilayi_gaz + "'"
                                                    + "vilayi_tel =" + "'" + vilayi.Vilayi_tel + "'"
                                                    + "vilayi_#tabaghat = " + "'" + vilayi.Vilayi_tedadTabaghat + "'"
                                                    + " vilayi_tabaghe = " + "'" + vilayi.Vilayi_tabaghe + "'"
                                                    + "  vilayi_asansor=" + "'" + vilayi.Vilayi_asansor + "'"
                                                    + "vilayi_saleSakht=" + "'" + vilayi.Vilayi_saleSakht + "'"
                                                    + "vilayi_kafposh =" + "'" + vilayi.Vilayi_kafposh + "'"
                                                    + " vilayi_nama = " + "'" + vilayi.Vilayi_nama + "'"
                                                    + "vilayi_teras =" + "'" + vilayi.Vilayi_teras + "'"
                                                    + "vilayi_hayat =" + "'" + vilayi.Vilayi_hayat + "'"
                                                    + " vilayi_metrazh = " + "'" + vilayi.Vilayi_metrazh + "'"
                                                    + " vilayi_parking = " + "'" + vilayi.Vilayi_parking + "'"
                                                    + " vilayi_#otagh = " + "'" + vilayi.Vilayi_tedadOtagh + "'"
                                                    + "vilayi_kabinet=" + "'" + vilayi.Vilayi_kabinet + "'"
                                                    + "vilayi_anbar=" + "'" + vilayi.Vilayi_anbar + "'"
                                                    + "vilayi_#vahedTabaghe=" + "'" + vilayi.Vilayi_tedadVahedTabaghe + "'"
                                                    + " vilayi_noeKarbari=" + "'" + vilayi.Vilayi_noeKarbari + "'"
                                                    + "vilayi_tozih=" + "'" + vilayi.Vilayi_tozih + "'"
                                                    + "vilayi_address=" + "'" + vilayi.Vilayi_address + "'"
                                                    + "vilayi_mantaghe=" + "'" + vilayi.Vilayi_mantaghe + "'"
                                                    + "vilayi_malekncode=" + "'" + vilayi.Vilayi_malekncode + "'"
                                                    + "WHERE vilayi_id = " + vilayi.Vilayi_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteVilayi(int vilayi_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM vilayi WHERE vilayi_id = " + vilayi_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for vilayi////////////////

        ///////// query for maghaze////////////////

        public void AddMaghaze(Maghaze maghaze)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO maghaze (maghaze_ab,maghaze_bargh,maghaze_gaz,maghaze_tel,maghaze_#tabaghat,maghaze_tabaghe,maghaze_asansor,maghaze_saleSakht,maghaze_kafposh,maghaze_nama,maghaze_balkon,maghaze_metrazh,maghaze_parking,maghaze_anbar,maghaze_#vahedTabaghe,maghaze_noeKarbari,maghaze_tozih,maghaze_address,maghaze_mantaghe,maghaze_malekncode)"
                                + "VALUES ('" + maghaze.Maghaze_ab + "'"
                                         + "'" + maghaze.Maghaze_bargh + "'"
                                         + "'" + maghaze.Maghaze_gaz + "'"
                                         + "'" + maghaze.Maghaze_tel + "'"
                                         + "'" + maghaze.Maghaze_tedadTabaghat + "'"
                                         + "'" + maghaze.Maghaze_tabaghe + "'"
                                         + "'" + maghaze.Maghaze_asansor + "'"
                                         + "'" + maghaze.Maghaze_saleSakht + "'"
                                         + "'" + maghaze.Maghaze_kafposh + "'"
                                         + "'" + maghaze.Maghaze_nama + "'"
                                         + "'" + maghaze.Maghaze_balkon + "'"
                                         + "'" + maghaze.Maghaze_metrazh + "'"
                                         + "'" + maghaze.Maghaze_parking + "'"
                                         + "'" + maghaze.Maghaze_anbar + "'"
                                         + "'" + maghaze.Maghaze_tedadVahedTabaghe + "'"
                                         + "'" + maghaze.Maghaze_noeKarbari + "'"
                                         + "'" + maghaze.Maghaze_tozih + "'"
                                         + "'" + maghaze.Maghaze_address + "'"
                                         + "'" + maghaze.Maghaze_mantaghe + "'"
                                         + "'" + maghaze.Maghaze_malekncode + "')";


                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditMaghaze(Maghaze maghaze)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE maghaze SET maghaze_ab = " + "'" + maghaze.Maghaze_ab + "'"
                                                    + "maghaze_bargh =" + "'" + maghaze.Maghaze_bargh + "'"
                                                    + "maghaze_gaz =" + "'" + maghaze.Maghaze_gaz + "'"
                                                    + "maghaze_tel =" + "'" + maghaze.Maghaze_tel + "'"
                                                    + "maghaze_#tabaghat = " + "'" + maghaze.Maghaze_tedadTabaghat + "'"
                                                    + " maghaze_tabaghe = " + "'" + maghaze.Maghaze_tabaghe + "'"
                                                    + "  maghaze_asansor=" + "'" + maghaze.Maghaze_asansor + "'"
                                                    + "maghaze_saleSakht=" + "'" + maghaze.Maghaze_saleSakht + "'"
                                                    + "maghaze_kafposh =" + "'" + maghaze.Maghaze_kafposh + "'"
                                                    + " maghaze_nama = " + "'" + maghaze.Maghaze_nama + "'"
                                                    + "maghaze_balkon =" + "'" + maghaze.Maghaze_balkon + "'"
                                                    + " maghaze_metrazh = " + "'" + maghaze.Maghaze_metrazh + "'"
                                                    + " maghaze_parking = " + "'" + maghaze.Maghaze_parking + "'"
                                                    + "maghaze_anbar=" + "'" + maghaze.Maghaze_anbar + "'"
                                                    + "maghaze_#vahedTabaghe=" + "'" + maghaze.Maghaze_tedadVahedTabaghe + "'"
                                                    + " maghaze_noeKarbari=" + "'" + maghaze.Maghaze_noeKarbari + "'"
                                                    + "maghaze_tozih=" + "'" + maghaze.Maghaze_tozih + "'"
                                                    + "maghaze_address=" + "'" + maghaze.Maghaze_address + "'"
                                                    + "maghaze_mantaghe=" + "'" + maghaze.Maghaze_mantaghe + "'"
                                                    + "maghaze_malekncode=" + "'" + maghaze.Maghaze_malekncode + "'"
                                                    + "WHERE maghaze_id = " + maghaze.Maghaze_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteMaghze(int maghaze_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM maghaze WHERE maghaze_id = " + maghaze_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for maghaze////////////////

        ///////// query for zamin////////////////

        public void AddZamin(Zamin zamin)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO zamin (zamin_ab,zamin_bargh,zamin_gaz,zamin_tel,zamin_metrazh,zamin_noeKarbari,zamin_tozih,zamin_address,zamin_mantaghe,zamin_malekncode)"
                                + "VALUES ('" + zamin.Zamin_ab + "'"
                                         + "'" + zamin.Zamin_bargh + "'"
                                         + "'" + zamin.Zamin_gaz + "'"
                                         + "'" + zamin.Zamin_tel + "'"
                                         + "'" + zamin.Zamin_metrazh + "'"
                                         + "'" + zamin.Zamin_noeKarbari + "'"
                                         + "'" + zamin.Zamin_tozih + "'"
                                         + "'" + zamin.Zamin_address + "'"
                                         + "'" + zamin.Zamin_mantaghe + "'"
                                         + "'" + zamin.Zamin_malekncode + "')";


                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }

        }

        public void EditZamin(Zamin zamin)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE zamin SET zamin_ab = " + "'" + zamin.Zamin_ab + "'"
                                                    + "zamin_bargh =" + "'" + zamin.Zamin_bargh + "'"
                                                    + "zamin_gaz =" + "'" + zamin.Zamin_gaz + "'"
                                                    + "zamin_tel =" + "'" + zamin.Zamin_tel + "'"
                                                    + " zamin_metrazh = " + "'" + zamin.Zamin_metrazh + "'"
                                                    + " zamin_noeKarbari=" + "'" + zamin.Zamin_noeKarbari + "'"
                                                    + "zamin_tozih=" + "'" + zamin.Zamin_tozih + "'"
                                                    + "zamin_address=" + "'" + zamin.Zamin_address + "'"
                                                    + "zamin_mantaghe=" + "'" + zamin.Zamin_mantaghe + "'"
                                                    + "zamin_malekncode=" + "'" + zamin.Zamin_malekncode + "'"
                                                    + "WHERE zamin_id = " + zamin.Zamin_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteZamin(int zamin_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM zamin WHERE zamin_id = " + zamin_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for zamin////////////////

        ///////// query for malek////////////////

        public void AddMalek(Malek malek)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO malek (malek_ncode,malek_name,malek_mobile,malek_tel,malek_tozihat)"
                                + "VALUES ('" + malek.Malek_ncode + "'"
                                         + "'" + malek.Malek_name + "'"
                                         + "'" + malek.Malek_mobile + "'"
                                         + "'" + malek.Malek_tel + "'"
                                         + "'" + malek.Malek_tozihat + "')";


                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }

        }

        public void EditMalek(Malek malek)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE malek SET malek_name = " + "'" + malek.Malek_name + "'"
                                                    + "malek_mobile=" + "'" + malek.Malek_mobile + "'"
                                                    + "malek_tel=" + "'" + malek.Malek_tel + "'"
                                                    + "malek_tozihat=" + "'" + malek.Malek_tozihat + "'"
                                                    + "WHERE malek_ncode = " + malek.Malek_ncode + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteMalek(int malek_ncode)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM malek WHERE malek_ncode = " + malek_ncode + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for malek////////////////

        ///////// query for ejareA////////////////

        public void AddEjareA(EjareA ejareA)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO ejareA (ejareA_mablaghpish,ejareA_mablaghEjare,ejareA_malekncode,ejareA_apartmanid,ejareA_tozih)"
                                + "VALUES ('" + ejareA.EjareA_mablaghpish + "'"
                                         + "'" + ejareA.EjareA_mablaghEjare + "'"
                                         + "'" + ejareA.EjareA_malekncode + "'"
                                         + "'" + ejareA.EjareA_apartmanid + "'"
                                         + "'" + ejareA.EjareA_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditEjareA(EjareA ejareA)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE ejareA SET ejareA_mablaghpish = " + "'" + ejareA.EjareA_mablaghpish + "'"
                                                    + "ejareA_mablaghEjare=" + "'" + ejareA.EjareA_mablaghEjare + "'"
                                                    + "ejareA_malekncode=" + "'" + ejareA.EjareA_malekncode + "'"
                                                    + "ejareA_apartmanid=" + "'" + ejareA.EjareA_apartmanid + "'"
                                                    + "ejareA_tozih=" + "'" + ejareA.EjareA_tozih + "'"
                                                    + "WHERE ejareA_id = " + ejareA.EjareA_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteEjareA(int ejareA_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM ejareA WHERE ejareA_id = " + ejareA_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for ejareA////////////////

        ///////// query for ejareM////////////////

        public void AddEjareM(EjareM ejareM)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO ejareM (ejareM_mablaghpish,ejareM_mablaghEjare,ejareM_malekncode,ejareM_maghazeid,ejareM_tozih)"
                                + "VALUES('" + ejareM.EjareM_mablaghpish + "'"
                                         + "'" + ejareM.EjareM_mablaghEjare + "'"
                                         + "'" + ejareM.EjareM_malekncode + "'"
                                         + "'" + ejareM.EjareM_maghazeid + "'"
                                         + "'" + ejareM.EjareM_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditEjareM(EjareM ejareM)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE ejareM SET ejareM_mablaghpish = " + "'" + ejareM.EjareM_mablaghpish + "'"
                                                    + "ejareM_mablaghEjare=" + "'" + ejareM.EjareM_mablaghEjare + "'"
                                                    + "ejareM_malekncode=" + "'" + ejareM.EjareM_malekncode + "'"
                                                    + "ejareM_maghazeid=" + "'" + ejareM.EjareM_maghazeid + "'"
                                                    + "ejareM_tozih=" + "'" + ejareM.EjareM_tozih + "'"
                                                    + "WHERE ejareM_id = " + ejareM.EjareM_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteEjareM(int ejareM_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM ejareM WHERE ejareM_id = " + ejareM_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for ejareM////////////////

        ///////// query for ejareV////////////////

        public void AddEjareV(EjareV ejareV)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO ejareV (ejareV_mablaghpish,ejareV_mablaghEjare,ejareV_malekncode,ejareV_vilayiid,ejareV_tozih)"
                                + "VALUES ('" + ejareV.EjareV_mablaghpish + "'"
                                         + "'" + ejareV.EjareV_mablaghEjare + "'"
                                         + "'" + ejareV.EjareV_malekncode + "'"
                                         + "'" + ejareV.EjareV_vilayiid + "'"
                                         + "'" + ejareV.EjareV_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditejareV(EjareV ejareV)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE ejareV SET ejareV_mablaghpish = " + "'" + ejareV.EjareV_mablaghpish + "'"
                                                    + "ejareV_mablaghEjare=" + "'" + ejareV.EjareV_mablaghEjare + "'"
                                                    + "ejareV_malekncode=" + "'" + ejareV.EjareV_malekncode + "'"
                                                    + "ejareV_vilayiid=" + "'" + ejareV.EjareV_vilayiid + "'"
                                                    + "ejareV_tozih=" + "'" + ejareV.EjareV_tozih + "'"
                                                    + "WHERE ejareV_id = " + ejareV.EjareV_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteEjareV(int ejareV_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM ejareV WHERE ejareV_id = " + ejareV_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for ejareV////////////////

        ///////// query for ejareZ////////////////

        public void AddEjareZ(EjareZ ejareZ)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO ejareZ (ejareZ_mablaghpish,ejareZ_mablaghEjare,ejareZ_malekncode,ejareZ_zaminid,ejareZ_tozih)"
                                + "VALUES ('" + ejareZ.EjareZ_mablaghpish + "'"
                                         + "'" + ejareZ.EjareZ_mablaghEjare + "'"
                                         + "'" + ejareZ.EjareZ_malekncode + "'"
                                         + "'" + ejareZ.EjareZ_zaminid + "'"
                                         + "'" + ejareZ.EjareZ_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditEjareZ(EjareZ ejareZ)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE ejareZ SET ejareZ_mablaghpish = " + "'" + ejareZ.EjareZ_mablaghpish + "'"
                                                    + "ejareZ_mablaghEjare=" + "'" + ejareZ.EjareZ_mablaghEjare + "'"
                                                    + "ejareZ_malekncode=" + "'" + ejareZ.EjareZ_malekncode + "'"
                                                    + "ejareZ_zaminid=" + "'" + ejareZ.EjareZ_zaminid + "'"
                                                    + "ejareZ_tozih=" + "'" + ejareZ.EjareZ_tozih + "'"
                                                    + "WHERE ejareZ_id = " + ejareZ.EjareZ_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteEjareZ(int ejareV_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM ejareV WHERE ejareV_id = " + ejareV_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for ejareZ////////////////

        ///////// query for foroshA////////////////

        public void AddForoshA(ForoshA foroshA)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO foroshA (foroshA_mablaghKol,foroshA_mablaghVam,foroshA_noeSanad,foroshA_#dang,foroshA_apartmanid,foroshA_malekncode,foroshA_tozih)"
                                + "VALUES ('" + foroshA.ForoshA_mablaghKol + "'"
                                         + "'" + foroshA.ForoshA_mablaghVam + "'"
                                         + "'" + foroshA.ForoshA_noeSanad + "'"
                                         + "'" + foroshA.ForoshA_tedadDang + "'"
                                         + "'" + foroshA.ForoshA_apartmanid + "'"
                                         + "'" + foroshA.ForoshA_malekncode + "'"
                                         + "'" + foroshA.ForoshA_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditForoshA(ForoshA foroshA)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE foroshA SET foroshA_mablaghKol = " + "'" + foroshA.ForoshA_mablaghKol + "'"
                                                    + "foroshA_mablaghVam=" + "'" + foroshA.ForoshA_mablaghVam + "'"
                                                    + "foroshA_noeSanad=" + "'" + foroshA.ForoshA_noeSanad + "'"
                                                    + "foroshA_#dang=" + "'" + foroshA.ForoshA_tedadDang + "'"
                                                    + "foroshA_apartmanid=" + "'" + foroshA.ForoshA_apartmanid + "'"
                                                    + "foroshA_malekncode=" + "'" + foroshA.ForoshA_malekncode + "'"
                                                    + "foroshA_tozih=" + "'" + foroshA.ForoshA_tozih + "'"
                                                    + "WHERE foroshA_id = " + foroshA.ForoshA_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteForoshA(int foroshA_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM foroshA WHERE foroshA_id = " + foroshA_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for foroshA////////////////

        ///////// query for foroshM////////////////

        public void AddForoshM(ForoshM foroshM)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO foroshM (foroshM_mablaghKol,foroshM_mablaghVam,foroshM_noeSanad,foroshM_#dang,foroshM_maghazeid,foroshM_malekncode,foroshM_tozih)"
                                + "VALUES ('" + foroshM.ForoshM_mablaghKol + "'"
                                         + "'" + foroshM.ForoshM_mablaghVam + "'"
                                         + "'" + foroshM.ForoshM_noeSanad + "'"
                                         + "'" + foroshM.ForoshM_tedadDang + "'"
                                         + "'" + foroshM.ForoshM_maghazeid + "'"
                                         + "'" + foroshM.ForoshM_malekncode + "'"
                                         + "'" + foroshM.ForoshM_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditForoshM(ForoshM foroshM)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE foroshM SET foroshM_mablaghKol = " + "'" + foroshM.ForoshM_mablaghKol + "'"
                                                    + "foroshM_mablaghVam=" + "'" + foroshM.ForoshM_mablaghVam + "'"
                                                    + "foroshM_noeSanad=" + "'" + foroshM.ForoshM_noeSanad + "'"
                                                    + "foroshM_#dang=" + "'" + foroshM.ForoshM_tedadDang + "'"
                                                    + "foroshM_maghazeid=" + "'" + foroshM.ForoshM_maghazeid + "'"
                                                    + "foroshM_malekncode=" + "'" + foroshM.ForoshM_malekncode + "'"
                                                    + "foroshM_tozih=" + "'" + foroshM.ForoshM_tozih + "'"
                                                    + "WHERE foroshM_id = " + foroshM.ForoshM_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteForoshM(int foroshM_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM foroshM WHERE foroshM_id = " + foroshM_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for foroshM////////////////

        ///////// query for foroshV////////////////

        public void AddForoshV(ForoshV foroshV)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO foroshV (foroshV_mablaghKol,foroshV_mablaghVam,foroshV_noeSanad,foroshV_#dang,foroshV_vilayiid,foroshV_malekncode,foroshV_tozih)"
                                + "VALUES ('" + foroshV.ForoshV_mablaghKol + "'"
                                         + "'" + foroshV.ForoshV_mablaghVam + "'"
                                         + "'" + foroshV.ForoshV_noeSanad + "'"
                                         + "'" + foroshV.ForoshV_tedadDang + "'"
                                         + "'" + foroshV.ForoshV_vilayiid + "'"
                                         + "'" + foroshV.ForoshV_malekncode + "'"
                                         + "'" + foroshV.ForoshV_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditForoshV(ForoshV foroshV)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE foroshV SET foroshV_mablaghKol = " + "'" + foroshV.ForoshV_mablaghKol + "'"
                                                    + "foroshV_mablaghVam=" + "'" + foroshV.ForoshV_mablaghVam + "'"
                                                    + "foroshV_noeSanad=" + "'" + foroshV.ForoshV_noeSanad + "'"
                                                    + "foroshV_#dang=" + "'" + foroshV.ForoshV_tedadDang + "'"
                                                    + "foroshV_vilayiid=" + "'" + foroshV.ForoshV_vilayiid+ "'"
                                                    + "foroshV_malekncode=" + "'" + foroshV.ForoshV_malekncode + "'"
                                                    + "foroshV_tozih=" + "'" + foroshV.ForoshV_tozih + "'"
                                                    + "WHERE foroshV_id = " + foroshV.ForoshV_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteForoshV(int foroshV_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM foroshV WHERE foroshV_id = " + foroshV_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for foroshV////////////////

        ///////// query for foroshZ////////////////

        public void AddForoshZ(ForoshZ foroshZ)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO foroshZ (foroshZ_mablaghKol,foroshZ_mablaghVam,foroshZ_noeSanad,foroshZ_#dang,foroshZ_zaminid,foroshZ_malekncode,foroshZ_tozih)"
                                + "VALUES ('" + foroshZ.ForoshZ_mablaghKol + "'"
                                         + "'" + foroshZ.ForoshZ_mablaghVam + "'"
                                         + "'" + foroshZ.ForoshZ_noeSanad + "'"
                                         + "'" + foroshZ.ForoshZ_tedadDang + "'"
                                         + "'" + foroshZ.ForoshZ_zaminid + "'"
                                         + "'" + foroshZ.ForoshZ_malekncode + "'"
                                         + "'" + foroshZ.ForoshZ_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditForoshZ(ForoshZ foroshZ)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE foroshZ SET foroshZ_mablaghKol = " + "'" + foroshZ.ForoshZ_mablaghKol + "'"
                                                    + "foroshZ_mablaghVam=" + "'" + foroshZ.ForoshZ_mablaghVam + "'"
                                                    + "foroshZ_noeSanad=" + "'" + foroshZ.ForoshZ_noeSanad + "'"
                                                    + "foroshZ_#dang=" + "'" + foroshZ.ForoshZ_tedadDang + "'"
                                                    + "foroshZ_zaminid=" + "'" + foroshZ.ForoshZ_zaminid + "'"
                                                    + "foroshZ_malekncode=" + "'" + foroshZ.ForoshZ_malekncode + "'"
                                                    + "foroshZ_tozih=" + "'" + foroshZ.ForoshZ_tozih + "'"
                                                    + "WHERE foroshZ_id = " + foroshZ.ForoshZ_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteForoshZ(int foroshZ_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM foroshZ WHERE foroshZ_id = " + foroshZ_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for foroshZ////////////////

        ///////// query for mosharekatV////////////////

        public void AddMosharekatV(MosharekatV mosharekatV)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO mosharekatV (mosharekatV_#dang,mosharekatV_noeSanad,mosharekatV_vilayiid,mosharekatV_malekncode,mosharekatV_tozih)"
                                + "VALUES ('" + mosharekatV.MosharekatV_tedadDang + "'"
                                         + "'" + mosharekatV.MosharekatV_noeSanad + "'"
                                         + "'" + mosharekatV.MosharekatV_vilayiid + "'"
                                         + "'" + mosharekatV.MosharekatV_malekncode + "'"
                                         + "'" + mosharekatV.MosharekatV_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditMosharekatV(MosharekatV mosharekatV)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE mosharekatV SET mosharekatV_#dang = " + "'" + mosharekatV.MosharekatV_tedadDang + "'"
                                                    + "mosharekatV_noeSanad=" + "'" + mosharekatV.MosharekatV_noeSanad + "'"
                                                    + "mosharekatV_vilayiid=" + "'" + mosharekatV.MosharekatV_vilayiid + "'"
                                                    + "mosharekatV_malekncode=" + "'" + mosharekatV.MosharekatV_malekncode + "'"
                                                    + "mosharekatV_tozih=" + "'" + mosharekatV.MosharekatV_tozih + "'"
                                                    + "WHERE mosharekatV_id = " + mosharekatV.MosharekatV_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteMosharekatV(int mosharekatV_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM mosharekatV WHERE mosharekatV_id = " + mosharekatV_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for mosharekatV////////////////

        ///////// query for mosharekatA////////////////

        public void AddMosharekatZ(MosharekatZ mosharekatZ)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO mosharekatA (mosharekatA_#dang,mosharekatA_noeSanad,mosharekatA_apartmanid,mosharekatA_malekncode,mosharekatA_tozih)"
                                + "VALUES ('" + mosharekatZ.MosharekatZ_tedadDang + "'"
                                         + "'" + mosharekatZ.MosharekatZ_noeSanad + "'"
                                         + "'" + mosharekatZ.MosharekatZ_apartmanid + "'"
                                         + "'" + mosharekatZ.MosharekatZ_malekncode + "'"
                                         + "'" + mosharekatZ.MosharekatZ_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditmosharekatZ(MosharekatZ mosharekatZ)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE mosharekatA SET mosharekatA_#dang = " + "'" + mosharekatZ.MosharekatZ_tedadDang + "'"
                                                    + "mosharekatA_noeSanad=" + "'" + mosharekatZ.MosharekatZ_noeSanad + "'"
                                                    + "mosharekatA_apartmanid=" + "'" + mosharekatZ.MosharekatZ_apartmanid + "'"
                                                    + "mosharekatA_malekncode=" + "'" + mosharekatZ.MosharekatZ_malekncode + "'"
                                                    + "mosharekatA_tozih=" + "'" + mosharekatZ.MosharekatZ_tozih + "'"
                                                    + "WHERE mosharekatA_id = " + mosharekatZ.MosharekatZ_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeletemosharekatA(int mosharekatA_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM mosharekatA WHERE mosharekatA_id = " + mosharekatA_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for mosharekatA////////////////

        ///////// query for pishForoshA////////////////

        public void AddPishForoshA(PishForoshA pishForoshA)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO pishForoshA (pishForoshA_pishPardakht,pishForoshA_mablaghKol,pishForoshA_#dang,pishForoshA_noeSanad,pishForoshA_dateTahvil,pishForoshA_apartmanid,pishforoshA_malekncode,pishForoshA_tozih)"
                                + "VALUES ('" + pishForoshA.PishForoshA_pishPardakht + "'"
                                         + "'" + pishForoshA.PishforoshA_mablaghKol + "'"
                                         + "'" + pishForoshA.PishforoshA_tedadDang + "'"
                                         + "'" + pishForoshA.PishforoshA_noeSanad + "'"
                                         + "'" + pishForoshA.PishForoshA_dateTahvil + "'"
                                         + "'" + pishForoshA.PishforoshA_apartmanid + "'"
                                         + "'" + pishForoshA.PishforoshA_malekncode + "'"
                                         + "'" + pishForoshA.PishforoshA_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditPishForoshA(PishForoshA pishForoshA)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE pishForoshA SET pishForoshA_pishPardakht = " + "'" + pishForoshA.PishForoshA_pishPardakht + "'"
                                                    + "pishForoshA_mablaghKol=" + "'" + pishForoshA.PishforoshA_mablaghKol + "'"
                                                    + "pishForoshA_#dang=" + "'" + pishForoshA.PishforoshA_tedadDang + "'"
                                                    + "pishForoshA_noeSanad=" + "'" + pishForoshA.PishforoshA_noeSanad + "'"
                                                    + "pishForoshA_dateTahvil=" + "'" + pishForoshA.PishForoshA_dateTahvil + "'"
                                                    + "pishForoshA_apartmanid=" + "'" + pishForoshA.PishforoshA_apartmanid + "'"
                                                    + "pishforoshA_malekncode=" + "'" + pishForoshA.PishforoshA_malekncode + "'"
                                                    + "pishForoshA_tozih=" + "'" + pishForoshA.PishforoshA_tozih + "'"
                                                    + "WHERE pishForoshA_id = " + pishForoshA.PishforoshA_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeletePishForoshA(int pishForoshA_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM pishForoshA WHERE pishForoshA = " + pishForoshA_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for pishForoshA////////////////

        ///////// query for pishForoshM////////////////

        public void AddPishForoshM(PishForoshM pishForoshM)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO PishForoshM (PishForoshM_pishPardakht,PishForoshM_mablaghKol,PishForoshM_#dang,PishForoshM_noeSanad,PishForoshM_dateTahvil,PishForoshM_apartmanid,PishForoshM_malekncode,PishForoshM_tozih)"
                                + "VALUES ('" + pishForoshM.PishforoshM_pishPardakht + "'"
                                         + "'" + pishForoshM.PishforoshM_mablaghKol + "'"
                                         + "'" + pishForoshM.PishforoshM_tedadDang + "'"
                                         + "'" + pishForoshM.PishforoshM_noeSanad + "'"
                                         + "'" + pishForoshM.PishforoshM_dateTahvil + "'"
                                         + "'" + pishForoshM.PishforoshM_maghazeid + "'"
                                         + "'" + pishForoshM.PishforoshM_malekncode + "'"
                                         + "'" + pishForoshM.PishforoshM_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditPishForoshM(PishForoshM pishForoshM)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE pishForoshM SET pishForoshM_pishPardakht = " + "'" + pishForoshM.PishforoshM_pishPardakht+ "'"
                                                    + "pishForoshM_mablaghKol=" + "'" + pishForoshM.PishforoshM_mablaghKol + "'"
                                                    + "pishForoshM_#dang=" + "'" + pishForoshM.PishforoshM_tedadDang + "'"
                                                    + "pishForoshM_noeSanad=" + "'" + pishForoshM.PishforoshM_noeSanad + "'"
                                                    + "pishForoshM_dateTahvil=" + "'" + pishForoshM.PishforoshM_dateTahvil + "'"
                                                    + "pishForoshM_apartmanid=" + "'" + pishForoshM.PishforoshM_maghazeid + "'"
                                                    + "pishForoshM_malekncode=" + "'" + pishForoshM.PishforoshM_malekncode + "'"
                                                    + "pishForoshM_tozih=" + "'" + pishForoshM.PishforoshM_tozih + "'"
                                                    + "WHERE pishForoshM_id = " + pishForoshM.PishforoshM_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeletePishForoshM(int pishForoshM_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM pishForoshM WHERE pishForoshM = " + pishForoshM_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for pishForoshM////////////////

        ///////// query for rahnA//////////////////

        public void AddRahnA(RahnA rahnA)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO rahnA (rahnA_mablaghRahn,rahnA_malekncode,rahnA_apartmanid,rahnA_tozih)"
                                + "VALUES ('" + rahnA.RahnA_mablaghRahn + "'"
                                         + "'" + rahnA.RahnA_malekncode + "'"
                                         + "'" + rahnA.RahnA_apartmanid + "'"
                                         + "'" + rahnA.RahnA_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditRahnA(RahnA rahnA)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE rahnA SET rahnA_mablaghRahn = " + "'" + rahnA.RahnA_mablaghRahn + "'"
                                                    + "rahnA_malekncode=" + "'" + rahnA.RahnA_malekncode + "'"
                                                    + "rahnA_apartmanid=" + "'" + rahnA.RahnA_apartmanid + "'"
                                                    + "rahnA_tozih=" + "'" + rahnA.RahnA_tozih + "'"
                                                    + "WHERE rahnA_id = " + rahnA.RahnA_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteRahnA(int rahnA_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM rahnA WHERE rahnA_id = " + rahnA_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for rahnA////////////////

        ///////// query for rahnM////////////////

        public void AddRahnM(RahnM rahnM)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO rahnM (rahnM_mablaghRahn,rahnM_malekncode,rahnM_maghazeid,rahnM_tozih)"
                                + "VALUES('" + rahnM.RahnM_mablaghRahn + "'"
                                         + "'" + rahnM.RahnM_malekncode + "'"
                                         + "'" + rahnM.RahnM_maghazeid + "'"
                                         + "'" + rahnM.RahnM_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditRahnM(RahnM rahnM)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE rahnM SET rahnM_mablaghRahn = " + "'" + rahnM.RahnM_mablaghRahn + "'"
                                                    + "rahnM_malekncode=" + "'" + rahnM.RahnM_malekncode + "'"
                                                    + "rahnM_maghazeid=" + "'" + rahnM.RahnM_maghazeid + "'"
                                                    + "rahnM_tozih=" + "'" + rahnM.RahnM_tozih + "'"
                                                    + "WHERE rahnM_id = " + rahnM.RahnM_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteRahnM(int rahnM_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM rahnM WHERE rahnM_id = " + rahnM_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for rahnM////////////////

        ///////// query for rahnV////////////////

        public void AddRahnV(RahnV rahnV)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO rahnV (rahnV_mablaghRahn,rahnV_malekncode,rahnV_vilayiid,rahnV_tozih)"
                                + "VALUES ('" + rahnV.RahnV_mablaghRahn + "'"
                                         + "'" + rahnV.RahnV_malekncode + "'"
                                         + "'" + rahnV.RahnV_vilayiid + "'"
                                         + "'" + rahnV.RahnV_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditRahnV(RahnV rahnV)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE rahnV SET rahnV_mablaghRahn = " + "'" + rahnV.RahnV_mablaghRahn + "'"
                                                    + "rahnV_malekncode=" + "'" + rahnV.RahnV_malekncode + "'"
                                                    + "rahnV_vilayiid=" + "'" + rahnV.RahnV_vilayiid + "'"
                                                    + "rahnV_tozih=" + "'" + rahnV.RahnV_tozih + "'"
                                                    + "WHERE rahnV_id = " + rahnV.RahnV_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteRahnV(int rahnV_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM rahnV WHERE rahnV_id = " + rahnV_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }
        /////////End query for rahnV////////////////

        ///////// query for rahnZ////////////////

        public void AddRahnZ(RahnZ rahnZ)
        {

            try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = conString;
                SqlCommand sc = new SqlCommand();
                SqlDataReader reader;
                sc.CommandText = "INSERT INTO rahnZ (rahnZ_mablaghRahn,rahnZ_malekncode,rahnZ_zaminid,rahnZ_tozih)"
                                + "VALUES ('" + rahnZ.RahnZ_mablaghRahn + "'"
                                         + "'" + rahnZ.RahnZ_malekncode + "'"
                                         + "'" + rahnZ.RahnZ_zaminid + "'"
                                         + "'" + rahnZ.RahnZ_tozih + "')";



                sc.CommandType = CommandType.Text;
                sc.Connection = conn;
                conn.Open();
                reader = sc.ExecuteReader();
                conn.Close();
            }
            catch
            {

            }
        }

        public void EditRahnZ(RahnZ rahnZ)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "UPDATE rahnZ SET rahnZ_mablaghRahn = " + "'" + rahnZ.RahnZ_mablaghRahn + "'"
                                                    + "rahnZ_malekncode=" + "'" + rahnZ.RahnZ_malekncode + "'"
                                                    + "rahnZ_zaminid=" + "'" + rahnZ.RahnZ_zaminid + "'"
                                                    + "rahnZ_tozih=" + "'" + rahnZ.RahnZ_tozih + "'"
                                                    + "WHERE rahnZ_id = " + rahnZ.RahnZ_id + "";


            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        public void DeleteRahnZ(int rahnZ_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = conString;
            SqlCommand sc = new SqlCommand();
            SqlDataReader reader;
            sc.CommandText = "DELETE FROM rahnZ WHERE rahnZ_id = " + rahnZ_id + "";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            conn.Close();
        }

        /////////End query for rahnZ////////////////




    }
}
