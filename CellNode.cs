//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class CellNode
    {
        public ICell cell;
        public CellNode(ICell pCell)
        {
            this.cell = pCell;
        }
    }
}
