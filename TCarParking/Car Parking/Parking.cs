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

        public bool TakingPlace(int userQuery)
        {
            if (!CheckParkingLot(userQuery))
            {
                return parking_[userQuery].IsBusy = true;
            }
            return false;
        }
        public bool FreeingUpSpace(int userQuery)
        {
            if (CheckParkingLot(userQuery))
            {
                parking_[userQuery].IsBusy = false;
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
