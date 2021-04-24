using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7
{
    public class Desk
    {
        public int Height;

        public int Width;

        public Desk() 
        {
            this.Height = 1;
            this.Width = 1;
        }

        public void SetSize(int size)
        {
            this.Height = size;
            this.Width = size;
        }
    }   
}
