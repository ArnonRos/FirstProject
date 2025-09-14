using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class DecimalFrac
    {
        private int mone;
        private int mechane;

        public DecimalFrac (int mone, int mechane)
        {
            this.mone = mone;  
            this.mechane = mechane;
        }
        public int Mone { get; set; }
        public int Mechane
        {
            get
            {
                return mechane; 
            }
            set
            {
                if (value != 0)
                    mechane = value;
            }
           
            }
        public int Calc ()
        {
            return this.mone/this.mechane;
        }
        public int div()
        {
            return this.mone % this.mechane;
        }
    }
}
