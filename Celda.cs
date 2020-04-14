//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Celda : ICell
    {
        public enum Status
        {
            HIDDEN,
            SHOWN,
            FLAG,
            QUESTION
        }

        public int valor;
        private int x;
        private int y;

        private Status status;

        public Celda()
        {
            this.status = Status.SHOWN;
        }

        public int GetValue()
        {
            return this.valor;
        }

        public bool IsHidden()
        {
            throw new NotImplementedException();
        }

        public void LeftClick()
        {
            throw new NotImplementedException();
        }

        public void RightClick()
        {
            throw new NotImplementedException();
        }

        public Status GetStatus()
        {
            return this.status;
        }

        //public void SetValue(int v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
