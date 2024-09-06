using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAmala_Vol3.Models
{
    class Delevery
    {
        private Int32 idDelevery;
        private Int32 idLocalite;
        private Int32 idProduit;
        private string numero_Seriel;
        private DateTime dateDelevery;

        public Delevery(int idDelevery, int idLocalite, int idProduit, string numero_Seriel, DateTime dateDelevery)
        {
            this.IdDelevery = idDelevery;
            this.IdLocalite = idLocalite;
            this.IdProduit = idProduit;
            this.Numero_Seriel = numero_Seriel;
            this.DateDelevery = dateDelevery;
        }
        public Delevery( int idLocalite)
        {
            this.IdLocalite = idLocalite;           
        }
        public int IdDelevery { get => idDelevery; set => idDelevery = value; }
        public int IdLocalite { get => idLocalite; set => idLocalite = value; }
        public int IdProduit { get => idProduit; set => idProduit = value; }
        public string Numero_Seriel { get => numero_Seriel; set => numero_Seriel = value; }
        public DateTime DateDelevery { get => dateDelevery; set => dateDelevery = value; }
    }
}
