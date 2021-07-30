using NUnit.Framework;
using Program;

namespace CalTest
{
[TestFixture]
    public class Tests
    {
        //test2
        Cal caltest = new Cal();

        [Test]
        public void Addition_of_two_integers()
        {
            double a = 15, b = 6;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetAddition(); //act
            Assert.AreEqual(res, 21); //assert
        }

        [Test]
        public void Addition_of_two_float()
        {
            double a = 4.5, b = 6.5;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetAddition(); //act
            Assert.AreEqual(res, 11); //assert
        }

        [Test]
        public void Addition_of_two_double()
        {
            double a = 5.234, b = 6.120;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetAddition(); //act
            Assert.AreEqual(res, 11.35); //assert
        }

        [Test]
        public void Subtraction_of_two_integers()
        {
            double a = 8, b = 6;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetSubtraction(); //act
            Assert.AreEqual(res, 2); //assert
        }

        [Test]
        public void Subtraction_of_two_float()
        {
            double a = 5.5, b = 6.5;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetSubtraction(); //act
            Assert.AreEqual(res, -1); //assert
        }

        [Test]
        public void Subtraction_of_two_double()
        {
            double a = 10.48, b = 16.59;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetSubtraction(); //act
            Assert.AreEqual(res, -6.1100000000000003); //assert
        }

        [Test]
        public void Multiplication_of_two_integer()
        {
            double a = 3, b = 6;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetMultiplication(); //act
            Assert.AreEqual(res, 18); //assert
        }

        [Test]
        public void Multiplication_of_two_float()
        {
            double a = 4.1, b = 8.7;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetMultiplication(); //act
            Assert.AreEqual(res, 35.67); //assert
        }

        [Test]
        public void Multiplication_of_two_double()
        {
            double a = 9.71, b = 7.36;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetMultiplication(); //act
            Assert.AreEqual(res, 71.469999999999999); //assert
        }

        [Test]
        public void Divide_of_two_integers()
        {
            double a = 3, b = 6;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetDivision(); //act
            Assert.AreEqual(res, .5); //assert
        }

        [Test]
        public void Divide_of_two_float()
        {
            double a = 9.10, b = 2.4;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetDivision(); //act
            Assert.AreEqual(res, 3.79); //assert
        }

        [Test]
        public void Divide_of_two_double()
        {
            double a = 2.05, b = 62.01;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetDivision(); //act
            Assert.AreEqual(res, 0.029999999999999999); //assert
        }

        [Test]
        public void Mutant1()
        {
            double a = 1, b = 3;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetDivision(); //act
            Assert.AreEqual(res, 1/3); //assert
        }

        [Test]
        public void Mutant2()
        {
            double a = 2, b = 1;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetDivision(); //act
            Assert.AreEqual(res, 2); //assert
        }

        [Test]
        public void Mutant3()
        {
            double a = 9, b = 3;//arrange
            caltest.SetFirstNumber(a);//arrange
            caltest.SetSecondNumber(b);//arrange
            double res = caltest.GetDivision(); //act
            Assert.AreEqual(res, 3); //assert
        }

    }
}
