using System.Collections.Generic;

namespace Facture.BO
{
    public class Produit
    {
       // private double ;

        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantite { get; set; }


        public Produit()
        {

        }

        public Produit(string reference, string name, double price,double quantite)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Quantite = quantite;
        }


        public Produit(Produit produit):this(produit?.Reference,produit?.Name,produit?.Price ?? 0)
        {

        }

        public Produit(string reference, string name, double quantite)
        {
            Reference = reference;
            Name = name;
            this.Quantite = quantite;
        }

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   Reference == produit.Reference;
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Reference);
        }

        
    }
}
