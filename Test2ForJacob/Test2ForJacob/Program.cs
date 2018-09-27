using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2ForJacob
{
    class BIRD
    {
        private string Name;
        private string Species;
        private string Sex;
        private string Weight;
        private string BandNo;

        public string birdName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string birdSpecies
        {
            get
            {
                return Species;   
            }
            set
            {
                Species = value;
            }
        }

        public string birdSex
        {
            get
            {
                return Sex;
            }
            set
            {
                Sex = value;
            }
        }

        public string birdWeight
        {
            get
            {
                return Weight;
            }
            set
            {
                Weight = value;
            }
        }

        public string birdBandNo
        {
            get
            {
                return BandNo;
            }
            set
            {
                BandNo = value;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Bird object created and default data loaded...");

            Console.WriteLine("PLEASE UPDATE BIRD DATA");

            BIRD bird1 = new BIRD();
            bird1.Name = "Name unknown";
            bird1.Species = "Species unknown";
            bird1.Sex = "Sex unknown";
            bird1.Weight = "Weight unknown";
            bird1.BandNo = "Band Number unknown";

            BIRD bird2 = new BIRD();
            bird2.Name = "Hisan";
            bird2.Species = "NZ Falcon";
            bird2.Sex = "Male";
            bird2.Weight = "240grams";
            bird2.BandNo = "H39878";

            BIRD[] DisplayBird = new BIRD[2];
            DisplayBird[0] = bird1;
            DisplayBird[1] = bird2;

            Console.ReadLine();
        }
        

    }
}
