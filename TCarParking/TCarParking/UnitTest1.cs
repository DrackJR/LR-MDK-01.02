using System;
using Car_Parking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCarParking
{
    [TestClass]
    public class TCarParking
    {
        [TestMethod]
        public void TestIsBusyParkingLotOf100()
        {
            Parking parking = new Parking(100);

            Assert.IsFalse(parking.CheckParkingLot(96));
            Assert.IsTrue(parking.TakingPlace(96));
            Assert.IsTrue(parking.CheckParkingLot(96));
            Assert.IsTrue(parking.FreeingUpSpace(96));
            Assert.IsFalse(parking.CheckParkingLot(96));
            Assert.IsTrue(parking.TakingPlace(96));
        }
    }
}
