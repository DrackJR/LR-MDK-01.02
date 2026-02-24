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
            for (int i = 0; i < numberOfLots; i++)
            {
                parking_.Add(new ParkingLot(i + 1, false));
            }     
        }

        public bool TakingPlace(int userQuery)
        {
            if (!CheckParkingLot(userQuery))
            {
                return parking_[userQuery - 1].IsBusy = true;
            }
            return false;
        }
        public bool FreeingUpSpace(int userQuery)
        {
            if (CheckParkingLot(userQuery))
            {
                parking_[userQuery - 1].IsBusy = false;
                return true;              
            }
            return false;
        }

        public bool CheckParkingLot(int userQuery)
        {
            foreach(ParkingLot lot in parking_)
            {
                if (lot.NumberOfLot == userQuery)
                {
                    return lot.IsBusy;
                }
            }
            return true;
        }
    }
}
