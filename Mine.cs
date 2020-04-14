//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Mine : ICell
    {

        private int x;
        private int y;

        private Celda.Status status;

        public Mine()
        {
            this.status = Celda.Status.SHOWN; //Su estado inicial esta en "visible", cambiar a oculto para poder jugar
        }
        public Celda.Status GetStatus()
        {

            return this.status;
        }

        public int GetValue()
        {
            return 0; //throw new NotImplementedException();    
        }

        public bool IsHidden()
        {
            return false;
        }

        public void LeftClick()
        {
        }

        public void RightClick()
        {
          
        }

        //public void SetValue(int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
