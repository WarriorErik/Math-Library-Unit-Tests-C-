using MyMathLibrary;

namespace MyMathTests
{
    [TestClass]
    public class myMathTests
    {
        public void TestAdd()
        {
            //Arrange and Act
            MyMath math = new MyMath(3.0f, 4.0f);

            //Assert
            Assert.AreEqual(7.0f, math.Add());
        }

        [TestMethod]
        public void TestSubtract()
        {
            //Arrange and Act
            MyMath math = new MyMath(7.0f, 4.0f);

            //Assert
            Assert.AreEqual(3.0f, math.Subtract());
        }

        [TestMethod]
        public void TestMultiply()
        {
            //Arrange and Act
            MyMath math = new MyMath(12.0f, 3.0f);

            //Assert
            Assert.AreEqual(36.0f, math.Multiply());
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void TestMultiply_Infinity()
        {
            //Arrange and Act, no Assert needed
            MyMath math = new MyMath(float.PositiveInfinity, float.PositiveInfinity);
            math.Multiply();
        }

        [TestMethod]
        public void TestDivide()
        {
            //Arrange and Act
            MyMath math = new MyMath(10.0f, 2.0f);

            //Assert
            Assert.AreEqual(5.0f, math.Divide());
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void TestDivide_MinValue()
        {
            //Arrange and Act, no Assert needed 
            MyMath math = new MyMath(float.MinValue, float.MinValue);
            math.Divide();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivide_DivideByZero()
        {
            //Arrange and Act, no Assert needed 
            MyMath math = new MyMath(10.0f, 0.0f);
            math.Divide();
        }

        [TestMethod]
        public void TestEpsilon()
        {
            //Arrange and Act
            MyMath math = new MyMath();

            //Assert
            Assert.AreEqual(float.Epsilon, math.Epsilon);
        }

        [TestMethod]
        public void TestNaN()
        {
            //Arrange and Act
            MyMath math = new MyMath();

            //Assert
            Assert.AreEqual(float.NaN, math.NaN);

        }
    }
}