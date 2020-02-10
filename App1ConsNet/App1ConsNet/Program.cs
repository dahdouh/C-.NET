using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotheque1;

namespace App1ConsNet
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            //Test de classe
            Etudiant etu1 = new Etudiant();
            etu1.Nom = "Higos";
            etu1.Prenom = "Vector";
            Console.WriteLine($"Etudiant, nom: { etu1.Nom} : {etu1.Prenom}");

            //Test de interface
            IFigure cercle = new Cercle();
            Console.WriteLine("Appel de méthode draw() de la classe Cercle qui implemente l'interface IFigure");
            cercle.draw();

            IFigure reclangle = new Rectangle(14, 7, 8);
            reclangle.draw();

            //Point p = new Point(2, 3);
            //Console.Write($" Poit: (x = { p.X }, y = { p.Y }) ");
 







            Console.ReadLine();
            //Console.ReadKey();
        }
        
    }

}
