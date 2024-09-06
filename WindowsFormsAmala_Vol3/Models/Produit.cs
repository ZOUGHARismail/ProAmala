using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAmala_Vol3.Models
{
    public class Produit
    {
        private Int32 idSeriel;
        private string nameProduit;
        private Int32 idStorage;
        private Int32 quantity;

        public Produit(int idSeriel, string nameProduit, int idStorage, int quantity)
        {
            this.IdSeriel = idSeriel;
            this.NameProduit = nameProduit;
            this.IdStorage = idStorage;
            this.Quantity = quantity;
        }
        public Produit(int idSeriel, string nameProduit, int quantity)
        {
            this.IdSeriel = idSeriel;
            this.NameProduit = nameProduit;
            this.Quantity = quantity;
        }
        public Produit( string nameProduit, int quantity)
        {
            this.NameProduit = nameProduit;
            this.Quantity = quantity;
        }
        public int IdSeriel { get => idSeriel; set => idSeriel = value; }
        public string NameProduit { get => nameProduit; set => nameProduit = value; }
        public int IdStorage { get => idStorage; set => idStorage = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}

