using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_przybornik.tests
{
    [TestFixture]
    class KalkulatorTest
    {
        [Test]
        public void shouldReturnOperationAdd()
        {
            Kalkulator.Operations operation= Kalkulator.changeOperation("Dodawanie");
            Assert.AreEqual(operation, Kalkulator.Operations.Add);
        }

        [Test]
        public void shouldNotReturnOperationAdd()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Dodawanie_");
            Assert.AreNotEqual(operation, Kalkulator.Operations.Add);
        }

        [Test]
        public void shouldReturnOperationSubstract()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Odejmowanie");
            Assert.AreEqual(operation, Kalkulator.Operations.Substract);
        }

        [Test]
        public void shouldNotReturnOperationSubstract()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Odejmowaniesd");
            Assert.AreNotEqual(operation, Kalkulator.Operations.Substract);
        }


        [Test]
        public void shouldReturnOperationDivide()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Dzielenie");
            Assert.AreEqual(operation, Kalkulator.Operations.Divide);
        }

        [Test]
        public void shouldNotReturnOperationDivide()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Dzielenie_");
            Assert.AreNotEqual(operation, Kalkulator.Operations.Divide);
        }

        [Test]
        public void shouldReturnOperationMultiply()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Mnozenie");
            Assert.AreEqual(operation, Kalkulator.Operations.Multiply);
        }

        [Test]
        public void shouldNotReturnOperationMultiply()
        {
            Kalkulator.Operations operation = Kalkulator.changeOperation("Mnozenie_");
            Assert.AreNotEqual(operation, Kalkulator.Operations.Multiply);
        }

    }
}
