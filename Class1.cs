using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    class Employe
    {
        //declaration de atrributs
        public int numero;
        public string nom_prenom;
        public string adress;
        //implimentation du constructeur implicit
        public Employe()
        {
            nom_prenom = "";
            numero = 0;
            adress = "";
        }
        //implimentation du constructeur avec paramtre
        public Employe(int num, string np, string ad)
        {
            numero = num;
            nom_prenom = np;
            adress = ad;
        }
        //le modificateur ovverride pour etendre ou modifier l implemntation abstraite
        public override string ToString()
        {
            return numero + "  " + nom_prenom + "   " + adress;
        }
    }
}
