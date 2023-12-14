namespace CarManager.Tests
{
    using NUnit.Framework;
    using static System.Net.Mime.MediaTypeNames;
    using System;
    using System.Runtime.ConstrainedExecution;

    [TestFixture]
    public class CarManagerTests
    {
        [Test]
        public void CarConstructorHieracrhyShouldWorkCorrectly()
        {
            Car car = new Car("Mercedes", "CLK", 10, 100);
            string expectedMake = "Mercedes";
            string expectedModel = "CLK";
            double expectedFuelCons = 10;
            double expectedFuelCapacity = 100;

            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedFuelCons, car.FuelConsumption);
            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }


        [TestCase("")]
        [TestCase(null)]
        public void CarMakeSetterThrowsExceptionWhenMakeIsNullOrWhiteSpace(string make)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
            => new Car(make, "CLK", 10, 100));

            Assert.AreEqual("Make cannot be null or empty!", exception.Message);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CarModelSetterThrowsExceptionWhenMakeIsNullOrWhiteSpace(string model)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
            => new Car("Mercedes", model, 10, 100));

            Assert.AreEqual("Model cannot be null or empty!", exception.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-11)]
        public void CarConsumptionSetterThrowsExceptionWhenZeroOrNegative(double consumption)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
            => new Car("Mercedes", "CLK", consumption, 100));

            Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-11)]
        public void CarCapacitySetterThrowsExceptionWhenWhenZeroOrNegative(double capacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
            => new Car("Mercedes", "CLK", 10, capacity));

            Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
        }
        //[Test]
        //public void CarFuelAmountSetterThrowsExceptionWhenNegative()
        //{
        //    Car car = new Car("Mercedes", "S63", 7.5, 50.0);

        //    Assert.Throws<InvalidOperationException>(()
        //   => car.Drive(12), "Fuel amount cannot be negative!");
        //}

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-11)]
        public void CarRefuelMethodThrowsExceptionWhenZeroOrNegative(double amount)
        {
            Car car = new Car("Mercedes", "S63", 7.5, 50.0);
            ArgumentException exception = Assert.Throws<ArgumentException>(()
            => car.Refuel(amount));

            Assert.AreEqual("Fuel amount cannot be zero or negative!", exception.Message);
        }
        [Test]
        public void CarRefuelMethodWorksCorrectly()
        {
            Car car = new Car("Mercedes", "S63", 7.5, 50.0);
            car.Refuel(10);

            Assert.AreEqual(10,car.FuelAmount);
        }

        [Test]
        public void CarRefuelMethodSetsTheAmountToTheMax()
        {
            Car car = new Car("Mercedes", "S63", 7.5, 50.0);
            car.Refuel(60);

            Assert.AreEqual(50, car.FuelAmount);
        }
        [Test]
        public void CarDriveMethodWorksCorrectly()
        {
            Car car = new Car("Mercedes", "S63", 5, 100);
            car.Refuel(100);
            car.Drive(100);
            Assert.AreEqual(95, car.FuelAmount);
        }
        [Test]
        public void CarDriveMethodThrowsException()
        {
            Car car = new Car("Mercedes", "S63", 7.5, 50.0);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(()
            => car.Drive(1000));

            Assert.AreEqual("You don't have enough fuel to drive!", exception.Message);
        }
    }
}