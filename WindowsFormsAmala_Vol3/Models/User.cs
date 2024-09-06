using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsAmala_Vol3.Models
{
    public class User
    {
        public SqlConnection connection = DataBasseConnection.connection;
        private String login;
        private String password;
        private String type;
        
        private DataTable localites = new DataTable();
        private Localite currentLocalite;
        private SqlDataAdapter dataAdapterlocalite;

        private DataTable materiels = new DataTable();
        private Produit currentMateriel;
        private SqlDataAdapter dataAdapterMateriel;
        
        private DataTable produits = new DataTable();
        private Produit currentProduit;
        private SqlDataAdapter dataAdapterProduit;

        private DataTable marches = new DataTable();
        private Marche currentMarche;
        private SqlDataAdapter dataAdapterMarche;




        public User(string login, string password, string type) :
            this(login, password)
        {
            this.Type = type;
        }
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        public string Login
        {
            get
            {
                return this.login;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this.login = value;
                }
                else
                {
                    throw new Exception("Attention le login ne doit pas être vide ! ");
                }
            }
        }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public Localite CurrentLocalite { get => currentLocalite; set => currentLocalite = value; }
        public DataTable Localites { get => localites; set => localites = value; }
        public SqlDataAdapter DataAdapterlocalite { get => dataAdapterlocalite; set => dataAdapterlocalite = value; }

        public Produit CurrentMateriel { get => currentMateriel; set => currentMateriel = value; }
        public SqlDataAdapter DataAdapterMateriel { get => dataAdapterMateriel; set => dataAdapterMateriel = value; }
        public DataTable Materiels { get => materiels; set => materiels = value; }
        public DataTable Marches { get => marches; set => marches = value; }
        public Marche CurrentMarche { get => currentMarche; set => currentMarche = value; }
        public SqlDataAdapter DataAdapterMarche { get => dataAdapterMarche; set => dataAdapterMarche = value; }
        public DataTable Produits { get => produits; set => produits = value; }
        public Produit CurrentProduit { get => currentProduit; set => currentProduit = value; }
        public SqlDataAdapter DataAdapterProduit { get => dataAdapterProduit; set => dataAdapterProduit = value; }

        public void authentifier()
        {
            this.connection.Open();
            SqlCommand cmd = new SqlCommand("select type from users where login=@login and password=@password", this.connection);
            cmd.Parameters.AddWithValue("@login", this.login);
            cmd.Parameters.AddWithValue("@password", this.password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                String type = dr.GetString(0);
                User u = null;
                switch (type)
                {
                    case "admin":
                        u = new Admin(this.login, this.password);
                        this.connection.Close();
                        break;
                        //case "respins":
                        //    u = new ResponsableIns(this.login, this.password);
                        //    break;
                        //case "respprog":
                        //    u = new ResponsableProg(this.login, this.password);
                        //    break;
                }
                if (u != null)
                {
                    u.afficherInterface();
                }
            }
            else
            {
                throw new Exception("Login ou passeord incorrect  !");
            }
            dr.Close();
        }
        public virtual void afficherInterface() { }
        public DataTable chargerLocalite()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Localite", this.connection);
            this.DataAdapterlocalite = new SqlDataAdapter(cmd);
            this.Localites.Clear();
            this.DataAdapterlocalite.Fill(this.Localites);
            return this.Localites;
        }
        public DataTable chargerMateriel()
        {
            SqlCommand cmd = new SqlCommand("select NumeroSeriel,NameProduit,DescriptionProduit from Produit", this.connection);
            this.DataAdapterMateriel = new SqlDataAdapter(cmd);
            this.materiels.Clear();
            this.DataAdapterMateriel.Fill(this.materiels);
            return this.materiels;
        }
        public DataTable chargerProduit()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Produit", this.connection);
            this.dataAdapterProduit = new SqlDataAdapter(cmd);
            this.produits.Clear();
            this.dataAdapterProduit.Fill(this.produits);

            return this.produits;
        }
        public DataTable chargerMarches()//haddddddddddddddiiiiiiiiiiiiii
        {
            SqlCommand cmd = new SqlCommand("select IdMarche, NameMarche+' '+ CAST(BG as varchar)+' '+CAST(DateMarche as varchar ) from Marche", this.connection);
            this.DataAdapterMarche = new SqlDataAdapter(cmd);
            this.Marches.Clear();
            this.DataAdapterMarche.Fill(this.Marches);
            return this.Marches;
        }

        public string  afficherLocalite(int row,int col)
        {
            string label;
            this.connection.Open();
            DataTable localitesss = new DataTable();
            SqlCommand cmd = new SqlCommand("select *   from Localite", this.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            localitesss.Load(reader);
            label = localitesss.Rows[row][col].ToString(); //D.A.E.R
            //label2 = localitesss.Rows[1][0].ToString();//D.A.E.C
            //label3 = localitesss.Rows[2][0].ToString();//D.R.H\
            this.connection.Close();
            return label;    
        }
        public string afficherMateriel(int row, int col)
        {
            string label;
            this.connection.Open();
            DataTable localitesss = new DataTable();
            SqlCommand cmd = new SqlCommand("select NumeroSeriel,NameProduit from Produit", this.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            localitesss.Load(reader);
            label = localitesss.Rows[row][col].ToString(); //D.A.E.R
            //label2 = localitesss.Rows[1][0].ToString();//D.A.E.C
            //label3 = localitesss.Rows[2][0].ToString();//D.R.H\
            this.connection.Close();
            return label;
        }


    }
}
