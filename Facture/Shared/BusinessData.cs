using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facture.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<string> Factures => null;

        public BusinessData() { }
        public BusinessData(string nom, string numero, DateTime dateEmission, DateTime dateReglement, double sommeDue, double sommeReglee)
        {
            NomClient = nom;
            NumeroFacture = numero;
            DateEmission = dateEmission;
            DateReglement = dateReglement;
            SommeDue = sommeDue;
            SommeReglee = sommeReglee;
        }

        public string NomClient { get; set; }

        public string NumeroFacture { get; set; }

        public DateTime DateEmission { get; set; }

        public DateTime DateReglement { get; set; }

        public double SommeDue { get; set; }

        public double SommeReglee { get; set; }
    }
}
