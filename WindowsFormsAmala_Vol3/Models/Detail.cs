using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsAmala_Vol3.Models
{
    class Detail
    {
        private Int32 idMarche;
        private Int32 idProduit;
        private string numero_Seriel;
        private string description_Produit;
        private string observation;

        public Detail(int idMarche, int idProduit, string numero_Seriel, string description_Produit, string observation)
        {
            this.IdMarche = idMarche;
            this.IdProduit = idProduit;
            this.Numero_Seriel = numero_Seriel;
            this.Description_Produit = description_Produit;
            this.Observation = observation;
        }

        public int IdMarche { get => idMarche; set => idMarche = value; }
        public int IdProduit { get => idProduit; set => idProduit = value; }
        public string Numero_Seriel { get => numero_Seriel; set => numero_Seriel = value; }
        public string Description_Produit { get => description_Produit; set => description_Produit = value; }
        public string Observation { get => observation; set => observation = value; }
    }
}
