using NUnit.Framework;
using LearnDLL;   

namespace LearnDLLTests
{
    [TestFixture]
    public class MainClassTests
    {
        private MainClass _mainClass;

        [SetUp]
        public void SetUp()
        {
            _mainClass = new MainClass(100); // корректное значение   
        }

        [Test]
        public void Test1()
        {
            int result = _mainClass.GetDifference(50);
            Assert.That(result, Is.EqualTo(50)); //проверка стандартного значения в диапазоне от 0 до 255 
        }

        [Test]
        public void Test2()
        {
            int result = _mainClass.GetDifference(255);
            Assert.That(result, Is.EqualTo(0)); // проверка границы, 255   
        }  // проверка не пройдена 

        [Test]
        public void Test3()
        {
            int result = _mainClass.GetDifference(-50);
            Assert.That(result, Is.EqualTo(255)); // проверка отрицательного значения  
        }
        [Test]
        public void Test4()
        {
            int result = _mainClass.GetDifference(256);
            Assert.That(result, Is.EqualTo(0)); // проверка границы +1   
        }
        [Test]
        public void Test5()
        {
            int result = _mainClass.GetDifference(500);
            Assert.That(result, Is.EqualTo(0)); // проверка значения, которое превышает 255   
        }
        [Test]
        public void Test6()
        {
            int result = _mainClass.GetDifference(0);
            Assert.That(result, Is.EqualTo(0)); // проверка границы, 0  
        }  // проверка не пройдена 
        [Test]
        public void Test7()
        {
            Assert.Throws<Exception>(() => new MainClass(300)); // проверка на исключение   
            Assert.Throws<Exception>(() => new MainClass(-10));
        }
    }
}