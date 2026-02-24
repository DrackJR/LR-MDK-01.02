using System;
using Car_Parking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCarParking
{
    [TestClass]
    public class TCarParking
    {
        //[TestMethod]
        //public void TestIsBusyParkingLotOf100()
        //{
        //    Parking parking = new Parking(100);

        //    Assert.IsTrue(parking.ParkingLotIsBusy(97));
        //}
        //[TestMethod]
        //public void TestIsBusyParkingLotOf5()
        //{
        //    Parking parking = new Parking(5);

        //    Assert.IsFalse(parking.ParkingLotIsBusy(2));
        //}
        //[TestMethod]
        //public void TestIsBusyParkingLotOf1000()
        //{
        //    Parking parking = new Parking(1000);

        //    Assert.IsTrue(parking.ParkingLotIsBusy(555));
        //}
        [TestMethod]
        public void TestIsBusyParkingLotOf100()
        {
            Parking parking = new Parking(100);

            Assert.IsFalse(parking.CheckParkingLot(96));
            Assert.IsTrue(parking.TakingPlace(96));
            Assert.IsFalse(parking.TakingPlace(96));
            Assert.IsFalse(parking.CheckParkingLot(96));
            //Assert.IsTrue(parking.FreeingUpSpace(96));
            //Assert.IsFalse(parking.CheckParkingLot(96));
        }
    }
}
