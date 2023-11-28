using Triangle;

namespace TriangleTests
{
    public class Tests
    {
        [Test]
        public void TestRectangular()
        {
            var a = 3;
            var b = 4;
            var c = 5;

            var result = Triangle.Triangle.GetTriangleType(a, b, c);
            Assert.That(result, Is.EqualTo(TriangleType.Rectangular));
        }

        [Test]
        public void TestObtuse()
        {
            var a = 4;
            var b = 4;
            var c = 6;

            var result = Triangle.Triangle.GetTriangleType(a, b, c);
            Assert.That(result, Is.EqualTo(TriangleType.Obtuse));
        }

        [Test]
        public void TestAcute()
        {
            var a = 4;
            var b = 4;
            var c = 5;

            var result = Triangle.Triangle.GetTriangleType(a, b, c);
            Assert.That(result, Is.EqualTo(TriangleType.Acute));
        }
    }
}