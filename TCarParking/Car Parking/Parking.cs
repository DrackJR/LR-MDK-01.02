using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Parking
{
    public class Parking
    {
        private List<ParkingLot> parking_ = new List<ParkingLot>();

        public Parking(int numberOfLots)
        {
            for (int i = 1; i <= numberOfLots; i++)
            {
                //bool isBusy = true;
                //if (i % 2 == 0)
                //{
                //    isBusy = false;
                //}
                parking_.Add(new ParkingLot(i, false));
            }     
        }

        public void TakingAPlace(int userQuery)
        {
            if (ParkingLotIsBusy(userQuery)==false)
            {
                parking_[userQuery].Busy = true;                
            }
        }
        public void FreeingUpSpace(int userQuery)
        {
            if (ParkingLotIsBusy(userQuery))
            {
                parking_[userQuery].Busy = false;
            }
        }

        public bool ParkingLotIsBusy(int userQuery)
        {
            foreach(ParkingLot lot in parking_)
            {
                if (lot.Number == userQuery)
                {
                    return lot.Busy;
                }
            }
            return true;
        }
    }
}
