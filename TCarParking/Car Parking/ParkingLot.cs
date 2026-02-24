using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking
{
    public class ParkingLot
    {
        public int NumberOfLot { get; set; }
        public bool IsBusy { get; set; }

        public ParkingLot(int numberOfLot, bool isBusy)
        {
            NumberOfLot = numberOfLot;
            IsBusy = isBusy;
        }
    }
}
