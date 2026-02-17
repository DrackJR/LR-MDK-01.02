using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking
{
    public class ParkingLot
    {
        private int numberOfLot_;
        private bool isBusy_;

        public ParkingLot(int numberOfLot, bool isBusy)
        {
            numberOfLot_ = numberOfLot;
            isBusy_ = isBusy;
        }

        public int Number
        {
            get {return numberOfLot_; }
        }
        public bool Busy
        {
            get { return isBusy_; }
            set { isBusy_ = value; }
        }
    }
}
