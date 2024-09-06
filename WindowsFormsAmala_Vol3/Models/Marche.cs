using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsAmala_Vol3.Models
{
    public class Marche
    {
        private Int32 idMarche;
        private string nameMarche;
        private DateTime dateMarche;
        private Int32 bG;
        public SqlConnection connection = DataBasseConnection.connection;

        private DataTable details = new DataTable();
        private Detail currentDetail = null;
        private SqlDataAdapter dataAdapterDetail;

        private DataTable marches = new DataTable();
        private Marche currentMarche;
        private SqlDataAdapter dataAdapterMarche;


        public Marche(int idMarche)
        {
            this.idMarche = idMarche;
        }
        public Marche(int idMarche, string nameMarche, DateTime dateMarche, int bG)
        {
            this.IdMarche = idMarche;
            this.NameMarche = nameMarche;
            this.DateMarche = dateMarche;
            this.BG = bG;
        }
        public int IdMarche { get => idMarche; set => idMarche = value; }
        public string NameMarche { get => nameMarche; set => nameMarche = value; }
        public DateTime DateMarche { get => dateMarche; set => dateMarche = value; }
        public int BG { get => bG; set => bG = value; }
        public DataTable Details { get => details; set => details = value; }
        public SqlDataAdapter DataAdapterDetail { get => dataAdapterDetail; set => dataAdapterDetail = value; }
        internal Detail CurrentDetail { get => currentDetail; set => currentDetail = value; }
        public DataTable Marches { get => marches; set => marches = value; }
        public Marche CurrentMarche1 { get => currentMarche; set => currentMarche = value; }
        public SqlDataAdapter DataAdapterMarche { get => dataAdapterMarche; set => dataAdapterMarche = value; }

        public DataTable chargerDetail()
        {
            SqlCommand cmd = new SqlCommand("select IdMarche as 'Mode DACQUSTITION',idProduit as 'le nom de Produit'" +
                ", Numero_Seriel as 'Numero Seriel', Description_Produit as 'Description DU BIEN INVENTORIE'," +
                " Fornisseur, Montant, Observation, DateEnregistrement as 'Date Enregistrement' from Detail WHERE idMarche=@idMarche", DataBasseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idMarche", this.idMarche);
            this.DataAdapterDetail = new SqlDataAdapter(cmd);
            this.Details.Clear();
            this.DataAdapterDetail.Fill(this.Details);
            SqlCommandBuilder cb = new SqlCommandBuilder(this.DataAdapterDetail);
            return this.Details;
        }
        public DataTable CurrentMarcheDisplayMember()
        {
            SqlCommand cmd = new SqlCommand("select IdMarche, NameMarche+' '+ CAST(BG as varchar)+' '+CAST(DateMarche as varchar ) from Marche where IdMarche=@idMarche", DataBasseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idMarche", this.idMarche);
            this.DataAdapterMarche = new SqlDataAdapter(cmd);
            this.Marches.Clear();
            this.DataAdapterMarche.Fill(this.Marches);
            SqlCommandBuilder cb = new SqlCommandBuilder(this.DataAdapterMarche);
            return this.Marches;
        }
        public void enregistrerDetail()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterDetail);
            this.DataAdapterDetail.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterDetail.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterDetail.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterDetail.Update(this.Details);
        }


    }
}
