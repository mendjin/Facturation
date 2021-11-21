using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facture.WinForms
{
    class RptProduit
    {
        public string Reference { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantite { get; set; }
       
       

        public RptProduit(string reference, string name,double price,double quantite)
        {
            Reference = reference;
            Name = name;
            Price = price;
            Quantite = quantite;
            
           
        }
    }
}
