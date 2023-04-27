using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace practicarMocks
{
    [TestClass]
    public class Test
    {
        public Mock<ClaseDos> C2;
        public ClaseUno C1;

        [TestInitialize]
        public void Init()
        {
            C2 = new Mock<ClaseDos>();
            C1 = new(C2.Object);
        }

        [TestMethod]
        public void Test1()
        {
            C2.Setup(x => x.DameString()).Returns("owo");

            var res = C1.HazCosas(1);

            Assert.IsNotNull(res);
            Assert.AreEqual("Numero 1 : owo", res);
        }
    }
}