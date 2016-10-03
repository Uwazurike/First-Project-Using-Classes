using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Apparels
{
    class Apparels
    {
        public Apparels()
        {

        }

        public Apparels(int initialNumTshirts, int initialNumPants)
        {
            NumTshirts = initialNumTshirts;
            NumPants = initialNumPants;

        }

        private bool hasTshirts = true;
        private int numTshirts;
        private bool hasPants;
        private int numPants;
        private bool hasJackets;

        public bool HasTshirts
        {
            get
            {
                return hasTshirts;
            }

            set
            {
                hasTshirts = value;
            }
        }

        public int NumTshirts
        {
            get
            {
                return numTshirts;
            }

            set
            {
                if (value < 1)
                {
                    numTshirts = 1;
                }
                else
                {
                    numTshirts = value;
                }

                numTshirts = value;
            }
        }

        public bool HasPants
        {
            get
            {
                return hasPants;
            }

            set
            {
                hasPants = value;
            }
        }

        public int NumPants
        {
            get
            {
                return numPants;
            }

            set
            {
                if (value < 1)
                {
                    numPants = 1;
                }
                else
                {
                    numPants = value;
                }
            }
        }

        public bool HasJackets
        {
            get
            {
                return hasJackets;
            }

            set
            {
                hasJackets = value;
            }
        }
    }
}
