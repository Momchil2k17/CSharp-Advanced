using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TestAxe.Tests
{
    public class TestDummy
    {
        private Axe axe;
        private Dummy dummy;
        private int axeAttack;
        private int axeDurability;
        private int dummyHealth;
        private int dummyexpirience;

        [SetUp]
        public void SetUp()
        {
            axeAttack = 10;
            axeDurability = 10;
            dummyHealth = 100;
            dummyexpirience = 100;
            axe = new Axe(axeAttack, axeDurability);
            dummy = new Dummy(dummyHealth, dummyexpirience);
        }
        [Test]
        public void CheckIfDummyLosesHealthWhenAttacked()
        {
            axe.Attack(dummy);
            Assert.AreEqual(90, dummy.Health);
        }
        [Test]
        public void CheckIfDummyThrowsExceptionWhenDead()
        {
            dummyHealth = 0;
            dummy=new Dummy(dummyHealth, dummyexpirience);
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            }
            );
        }

        [Test]
        public void CheckIfDummyCanGiveXpIfDead()
        {
            dummy = new Dummy(1, 1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                dummy.GiveExperience();
            });
        }

        [Test]
        public void CheckIfDummyCantGiveXpIfAlive()
        {
            dummy = new Dummy(0, 1);

            Assert.IsTrue(dummy.GiveExperience() > 0);
        }

    }
}
