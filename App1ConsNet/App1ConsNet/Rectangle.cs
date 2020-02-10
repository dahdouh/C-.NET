using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1ConsNet
{
    class Rectangle : IFigure
    {
        public int Longeur { get; set; }
        public int Largeur { get; set; }

        public int Aire { get; set; }

        public Rectangle(int longe, int larg, int aire)
        {
            Longeur = longe;
            Largeur = larg;
            Aire = aire;
        }


        public void draw()
        {
            Console.WriteLine($"Rectangle de longeur: {Longeur}  et de largeur: { Largeur }");
        }
        public override string ToString()
        {
            return "Longeur: "+ Longeur + ", largeur: " + Largeur;
        }

    }
}
