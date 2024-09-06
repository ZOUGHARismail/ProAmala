using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsAmala_Vol3.GUI;

namespace WindowsFormsAmala_Vol3.Models
{
    public  class Admin:User
    {

        public Admin(string login, string password) : base(login, password)
        {
        }
        public override void afficherInterface()
        {
            new Form2(this).Show();
        }
        public void AjouterMarche(string nameMarche,Int32 BG, DateTime DateMarche)
        {
            DataBasseConnection.connection.Open();
            SqlCommand cmdCommend3 = new SqlCommand("INSERT INTO Marche (nameMarche,BG,DateMarche) VALUES(@nameMarche,@BG,@DateMarche)", DataBasseConnection.connection);
            cmdCommend3.Parameters.AddWithValue("@nameMarche", nameMarche);
            cmdCommend3.Parameters.AddWithValue("@BG", BG);
            cmdCommend3.Parameters.AddWithValue("@DateMarche", DateMarche);
            cmdCommend3.ExecuteNonQuery();
        }
        public void AjouterLocalite(string nameMarche)
        {
            DataBasseConnection.connection.Open();
            SqlCommand cmdCommend3 = new SqlCommand("INSERT INTO Localite (Localite) VALUES(@Localite)", DataBasseConnection.connection);
            cmdCommend3.Parameters.AddWithValue("@Localite", nameMarche);
            cmdCommend3.ExecuteNonQuery();
        }
        public void enregistrerLocalite()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterlocalite);
            this.DataAdapterlocalite.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterlocalite.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterlocalite.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterlocalite.Update(this.Localites);
        }
        public void enregistrerProduit()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterProduit);
            this.DataAdapterProduit.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterProduit.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterProduit.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterProduit.Update(this.Produits);
        }
        public void enregistrerMarche()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(this.DataAdapterMarche);
            this.DataAdapterMarche.InsertCommand = builder.GetInsertCommand();
            this.DataAdapterMarche.DeleteCommand = builder.GetDeleteCommand();
            this.DataAdapterMarche.UpdateCommand = builder.GetUpdateCommand();
            this.DataAdapterMarche.Update(this.Marches);
        }
        
        public DataTable dusalt()
        {
            DataTable dt = new DataTable();
            this.connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Marche.IdMarche,DateMarche,NameMarche,BG,NameProduit," +
            "Produit.NumeroSeriel,DescriptionProduit FROM Detail INNER JOIN Marche ON " +
            "Detail.IdMarche = Marche.IdMarche INNER JOIN Produit ON Detail.NumeroSeriel = Produit.NumeroSeriel", this.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            this.connection.Close();
            return dt;
        }
        public DataTable delevery()
        {
            DataTable dt = new DataTable();
            this.connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT NameProduit,Produit.NumeroSeriel,DescriptionProduit,Delevery.DateDelevery,Localite " +
                "FROM   Marche INNER JOIN Detail ON Marche.IdMarche = Detail.IdMarche INNER JOIN Produit ON Detail.NumeroSeriel = Produit.NumeroSeriel" +
                " INNER JOIN Delevery INNER JOIN Localite ON Delevery.IdLocalite = Localite.IdLocalite ON Produit.NumeroSeriel = Delevery.NumeroSeriel", this.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            this.connection.Close();
            return dt;
        }
         

    }
}