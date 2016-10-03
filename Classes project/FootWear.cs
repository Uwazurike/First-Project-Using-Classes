using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.FootWear
{
    class FootWear
    {
        public FootWear()
        {

        }

        public FootWear(int initialNumSandals)
        {
            NumSandals = initialNumSandals;
        }

        private bool hasLoafers = true;
        private int numLoafers;
        private bool hasSandals;
        private int numSandals;
        private bool hasSlippers;

        public bool HasLoafers
        {
            get
            {
                return hasLoafers;
            }

            set
            {
                hasLoafers = value;
            }
        }

        public int NumLoafers
        {
            get
            {
                return numLoafers;
            }

            set
            {
                if (value < 1)
                {
                    numLoafers = 1;
                }
                else
                {
                    numLoafers = value;
                }

            }
        }

        public bool HasSandals
        {
            get
            {
                return hasSandals;
            }

            set
            {
                hasSandals = value;
            }
        }

        public int NumSandals
        {
            get
            {
                return numSandals;
            }

            set
            {
                if (value < 1)
                {
                    numSandals = 1;
                }
                else
                {
                    numSandals = value;
                }

                numSandals = value;
            }
        }

        public bool HasSlippers
        {
            get
            {
                return hasSlippers;
            }

            set
            {
                hasSlippers = value;
            }
        }
    }
}
