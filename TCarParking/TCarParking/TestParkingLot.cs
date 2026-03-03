using System;
using Car_Parking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TCarParking
{
    [TestClass]
    public class TCarParking
    {
        [TestMethod]
        public void TestIsAvaibleParkingLotOf100()
        {
            Parking parking = new Parking(100);

            Assert.IsFalse(parking.IsAvaible(96));
            Assert.IsTrue(parking.TakingPlace(96));
            Assert.IsTrue(parking.IsAvaible(96));
            Assert.IsTrue(parking.FreeingUpSpace(96));
            Assert.IsFalse(parking.IsAvaible(96));
            Assert.IsTrue(parking.TakingPlace(96));
        }

        [TestMethod]
        public void TestIsAvaibleParkingLotOf5()
        {
            Parking parking = new Parking(5);

            Assert.IsFalse(parking.IsAvaible(5));
            Assert.IsTrue(parking.TakingPlace(5));

            Assert.IsFalse(parking.IsAvaible(4));
            Assert.IsTrue(parking.TakingPlace(4));

            Assert.IsTrue(parking.IsAvaible(5));
            Assert.IsTrue(parking.IsAvaible(4));

            Assert.IsTrue(parking.FreeingUpSpace(4));
            Assert.IsFalse(parking.IsAvaible(4));

            Assert.IsTrue(parking.FreeingUpSpace(5));
            Assert.IsFalse(parking.IsAvaible(5));
        }
    }
}
