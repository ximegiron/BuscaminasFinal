//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Game <T> where T : ICell, new()
    {
        protected int tiempo;
        protected int numMines;

        protected int width;
        protected int height;

        protected int minesLeft;
        protected int flagsCount; 

        protected CellNode[,] celdas;

        public Game(int w, int h, int minas)  
        {
            this.width = w;
            this.height = h;
            this.numMines = minas;

            this.celdas = new CellNode[w, h];
            for (uint i = 0; i < this.width; i++)
            {
                for (uint j = 0; j < this.height; j++)
                {
                    this.celdas[i, j] = new CellNode(new T());
                }
            }

            this.GenerateMines();
        }

        public void GenerateMinesTarea()
        {

        }
        public void GenerateMines()
        {
            Random random = new Random();
            List<CellNode> list = new List<CellNode>();
            for (uint i = 0; i < this.width; i++)
            {
                for (uint j = 0; j < this.height; j++)
                {
                    list.Add(this.celdas[i, j]);
                }
            }
            //list[0].cell.SetValue(8);
            //list[0].SetValue(8);
            int pos;
            for (uint i = 0; i < this.numMines; i++)
            {
                pos = random.Next(0, list.Count);
                list[pos].cell = new Mine();
                list.RemoveAt(pos);
            }
        }
    }
}
