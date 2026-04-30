using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationMaze
{
    public struct Cell
    {
        // 0 : Haut, 1 : bas, 2 : gauche, 3 : droite
        public bool[] Walls { get; set; }

        public bool IsVisited { get; set; }

        // Définir système d'état de la cellule

        public Cell(bool mahcin = true)
        {
            this.IsVisited = false;
            Walls = new bool[4];
            Walls[0] = false;
            Walls[1] = false;
            Walls[2] = false;
            Walls[3] = false;
        }
    }
}
