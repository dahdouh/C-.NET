using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1ConsNet
{
    class Etudiant
    {
        public Etudiant()
        {
            Nom = "######";
        }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Adresse { get; set; }
    }
}
