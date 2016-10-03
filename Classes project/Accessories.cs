using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Accessories
{
    class Accessories
    {
        public Accessories()
        {

        }

        public Accessories (string initialWatchTypes)
        {
            watchTypes = initialWatchTypes;
        }

        private bool hasWatches = true;
        private int numWatches;
        private bool hasHats;
        private int numHats;
        private bool hasBags;
        private string watchTypes;

        public bool HasWatches
        {
            get
            {
                return hasWatches;
            }

            set
            {
                hasWatches = value;
            }
        }

        public int NumWatches
        {
            get
            {
                return numWatches;
            }

            set
            {
                if (value < 1)
                {
                    numWatches = 1;
                }
                else
                {
                    numWatches = value;
                }
                numWatches = value;
            }
        }

        public bool HasHats
        {
            get
            {
                return hasHats;
            }

            set
            {
                hasHats = value;
            }
        }

        public int NumHats
        {
            get
            {
                return numHats;
            }

            set
            {
                if (value < 1)
                {
                    numHats = 1;
                }
                else
                {
                    numHats = value;
                }

                numHats = value;
            }
        }

        public bool HasBags
        {
            get
            {
                return hasBags;
            }

            set
            {
                hasBags = value;
            }
        }

        public string WatchTypes
        {
            get
            {
                return watchTypes;
            }

            set
            {
                watchTypes = value;
            }
        }
    }
}
