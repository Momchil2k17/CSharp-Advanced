using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _01.TestAxe.Tests
{
    public class TestAxe
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
            dummyHealth = 10;
            dummyexpirience = 10;
            axe = new Axe(axeAttack, axeDurability);
            dummy = new Dummy(dummyHealth, dummyexpirience);
        }
        [Test]
        public void CheckIfWeaponLosesDurabilityAfterAttack() 
        {
            axe.Attack(dummy);
            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void TryAttackingWithBrokenWeapon() 
        {
            axeDurability = -1;
            axe = new Axe(axeAttack, axeDurability);
            Assert.Throws<InvalidOperationException>(() =>
            {
                axe.Attack(dummy);
            }
            );
        }
    }
}
