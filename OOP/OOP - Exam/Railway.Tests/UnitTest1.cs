namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {

        [Test]
        public void RailwayConstructorWorksCorrectlly()
        {
            string name = "Koko";
            RailwayStation rs=new RailwayStation(name);
            Assert.IsNotNull(rs);
            Assert.AreEqual(name, rs.Name);
            Assert.IsNotNull (rs.DepartureTrains);
            Assert.IsNotNull (rs.ArrivalTrains);
        }
        [TestCase(null)]
        [TestCase(" ")]
        public void NameSetterThrowsException(string name) 
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new RailwayStation(name));
            Assert.AreEqual("Name cannot be null or empty!", exception.Message);
        }

        [Test]
        public void NewArrivalOnBoardWorks() 
        {
            string name = "Koko";
            RailwayStation rs = new RailwayStation(name);
            rs.NewArrivalOnBoard("Train1");
            rs.NewArrivalOnBoard("Train2");
            Assert.AreEqual(name, rs.Name);
            Assert.AreEqual (2, rs.ArrivalTrains.Count);
            Assert.AreEqual("Train1", rs.ArrivalTrains.Dequeue());
            Assert.AreEqual("Train2", rs.ArrivalTrains.Dequeue());
        }

        [Test]
        public void TrainHasArrivedMethodBefore() 
        {
            string name = "Koko";
            RailwayStation rs = new RailwayStation(name);
            rs.NewArrivalOnBoard("Train1");
            rs.NewArrivalOnBoard("Train2");
            Assert.AreEqual($"There are other trains to arrive before Train2.", rs.TrainHasArrived("Train2"));
        }
        [Test]
        public void TrainHasArrivedMethodWorks()
        {
            string name = "Koko";
            RailwayStation rs = new RailwayStation(name);
            rs.NewArrivalOnBoard("Train1");
            rs.NewArrivalOnBoard("Train2");
            Assert.AreEqual($"Train1 is on the platform and will leave in 5 minutes.", rs.TrainHasArrived("Train1"));
            Assert.AreEqual(1, rs.ArrivalTrains.Count);
            Assert.AreEqual(1, rs.DepartureTrains.Count);
            Assert.AreEqual("Train1", rs.DepartureTrains.Peek());
            Assert.AreEqual("Train2", rs.ArrivalTrains.Peek());

        }
        [Test]
        public void TrainHasLeftReturnsTrue() 
        {
            string name = "Koko";
            RailwayStation rs = new RailwayStation(name);
            rs.NewArrivalOnBoard("Train1");
            rs.NewArrivalOnBoard("Train2");
            rs.TrainHasArrived("Train1");
            Assert.AreEqual(true, rs.TrainHasLeft("Train1"));
            Assert.AreEqual(0, rs.DepartureTrains.Count);
        }
        [Test]
        public void TrainHasLeftReturnsFalse()
        {
            string name = "Koko";
            RailwayStation rs = new RailwayStation(name);
            rs.NewArrivalOnBoard("Train1");
            rs.NewArrivalOnBoard("Train2");
            rs.TrainHasArrived("Train1");
            Assert.AreEqual(false, rs.TrainHasLeft("Train2"));
            Assert.AreEqual(1, rs.DepartureTrains.Count);
        }
    }
}