using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    class Conexao
    {

        //CONEXAO COM O BANCO DE DADOS LOCAL
        public string conec = "SERVER=localhost; DATABASE=hotel; UID=root; PWD=senha; PORT=;";

        //CONEXAO COM O BANCO DE DADOS HOSPEDADO
        /// public string conec = "SERVER=mysql465.umbler.com; DATABASE=hotel_sistema; UID=hugosistemahotel; PWD=sistemahotelhugo; PORT=41890;";

        public MySqlConnection con = null;

        public void AbrirCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na conexão com o Banco! " + ex.Message);
            }

            
        }


        public void FecharCon()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Close();
                con.Dispose();
                con.ClearAllPoolsAsync();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro na conexão com o Banco! " + ex.Message);
            }
        }


        
        

    }


}
