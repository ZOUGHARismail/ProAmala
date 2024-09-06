using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsAmala_Vol3.Models
{
     public class Localite
    {
        private int idlocalite;
        private string localité;
        public SqlConnection connection = DataBasseConnection.connection;

        private DataTable deleverys = new DataTable();
        private Delevery currentDelevery;
        private SqlDataAdapter dataAdapterdelevery;
        private DataTable localites = new DataTable();
        private Localite currentLocalite;
        private SqlDataAdapter dataAdapterlocalite;

        public Localite(int idlocalite, string localité)
        {
            this.Idlocalite = idlocalite;
            this.Localité = localité;
        }
        public Localite(int idlocalite)
        {
            this.Idlocalite = idlocalite;
        }
        public Localite( string localité)
        {
            this.Localité = localité;
        }

        public int Idlocalite { get => idlocalite; set => idlocalite = value; }
        public string Localité { get => localité; set => localité = value; }
        public DataTable Deleverys { get => deleverys; set => deleverys = value; }
        internal Delevery CurrentDelevery { get => currentDelevery; set => currentDelevery = value; }
        public SqlDataAdapter DataAdapterdelevery { get => dataAdapterdelevery; set => dataAdapterdelevery = value; }
        public DataTable Localites { get => localites; set => localites = value; }
        public Localite CurrentLocalite { get => currentLocalite; set => currentLocalite = value; }
        public SqlDataAdapter DataAdapterlocalite { get => dataAdapterlocalite; set => dataAdapterlocalite = value; }

        public DataTable chargerDelevery()
        {
            SqlCommand cmd = new SqlCommand("SELECT IdDelevery as'Id Delevery',IdLocalite as'Localite'," +
            "idProduit as 'le nom de Produit',Numero_Seriel as 'Numero Seriel',DateDelevery as'Date Delevery'" +
            " FROM Delevery WHERE IdLocalite=@IdLocalite", this.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@IdLocalite", this.Idlocalite);
            this.DataAdapterdelevery = new SqlDataAdapter(cmd);
            this.Deleverys.Clear();
            this.DataAdapterdelevery.Fill(this.Deleverys);
            SqlCommandBuilder cb = new SqlCommandBuilder(this.DataAdapterdelevery);
            return this.Deleverys;
        }
        public DataTable CurrentLocaliteDisplayMember()
        {
            SqlCommand cmd = new SqlCommand("select * from Localite where IdLocalite=@idLocalite", DataBasseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idLocalite", this.idlocalite);
            this.DataAdapterlocalite = new SqlDataAdapter(cmd);
            this.Localites.Clear();
            this.DataAdapterlocalite.Fill(this.Localites);
            SqlCommandBuilder cb = new SqlCommandBuilder(this.DataAdapterlocalite);
            return this.Localites;
        }
        public String LocaliteDisplayMember(int idlocalite)
        {
            DataBasseConnection.connection.Open();
            string vile=string.Empty;
            SqlCommand cmd = new SqlCommand("select localite from Localite where IdLocalite=@idLocalite", DataBasseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idLocalite", this.idlocalite);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                vile = reader["localite"].ToString();
            }
            DataBasseConnection.connection.Close();
            return vile;
        }

        public void enregistrerDelevery()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterdelevery);
            this.DataAdapterdelevery.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterdelevery.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterdelevery.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterdelevery.Update(this.Deleverys);
        }
    }
}
