using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math.Lib;
namespace Math.Tests
{
    [TestClass]
    public class RooterTests
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }
        [TestMethod]
        public void RooterValueRange()
        {
            Rooter rooter = new Rooter();
            for (double expected = 1e-8; expected < 1e+8; expected *= 3.2)
                RooterOneValue(rooter, expected);
        }
        
        private void RooterOneValue(Rooter rooter, double expectedResult)
        {
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 1000);
        }

        [TestMethod]
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
                Assert.Fail("Se esperaba una InvalidInputException.");
            }
            catch (InvalidInputException)
            {
                // Test pasa si se lanza la excepción correcta
            }
        }

        [TestMethod]
        public void RooterTestNegativeInputWithMessage()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-20);
                Assert.Fail("Se esperaba una InvalidInputException.");
            }
            catch (InvalidInputException ex)
            {
                StringAssert.Contains(ex.Message, "El valor ingresado es invalido, solo se puede ingresar números positivos");
            }
        }
        
        [TestMethod]
        public void RooterThrowsInvalidInputExceptionWithCustomMessage()
        {
            // Arrange
            var rooter = new Rooter();

            // Act & Assert
            try
            {
                rooter.SquareRoot(0);  // o un valor negativo, p.ej. -5
                Assert.Fail("Se esperaba una InvalidInputException");
            }
            catch (InvalidInputException ex)
            {
                // Verificamos que el mensaje sea exactamente el requerido
                Assert.AreEqual(
                    "El valor ingresado es invalido, solo se puede ingresar números positivos",
                    ex.Message);
            }
        }
    }
}