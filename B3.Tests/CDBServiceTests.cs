using B3.Domain.Interfaces;
using B3.Domain.Models;

namespace B3.Tests
{
    [TestClass]
    public class CDBServiceTests
    {
        private readonly ICDBService _cDBService;

        public CDBServiceTests()
        {
            _cDBService = new CDBService();
        }

        [TestMethod]
        public void CalculateCDBLessThaan6Months()
        {
            var initialValue = 500;
            var months = 1;

            var CDB  = _cDBService.CalculateCDB(initialValue, months);

            Assert.AreEqual(504.86, CDB.GrossValue);
            Assert.AreEqual(391.27, CDB.NetValue);

        }


        [TestMethod]
        public void CalculateCDBLessThaan12Months()
        {
            var initialValue = 500;
            var months = 11;

            var CDB = _cDBService.CalculateCDB(initialValue, months);

            Assert.AreEqual(556.14, CDB.GrossValue);
            Assert.AreEqual(444.91, CDB.NetValue);

        }

        [TestMethod]
        public void CalculateCDBLessThaan24Months()
        {
            var initialValue = 500;
            var months = 23;

            var CDB = _cDBService.CalculateCDB(initialValue, months);

            Assert.AreEqual(624.59, CDB.GrossValue);
            Assert.AreEqual(515.29, CDB.NetValue);

        }

        [TestMethod]
        public void CalculateCDBMoreThaan24Months()
        {
            var initialValue = 500;
            var months = 25;

            var CDB = _cDBService.CalculateCDB(initialValue, months);

            Assert.AreEqual(636.79, CDB.GrossValue);
            Assert.AreEqual(541.27, CDB.NetValue);

        }

        [TestMethod]
        public void NaN()
        {
            var months = 123123123;

            var CDB = new CDB();

            Assert.ThrowsException<NotFiniteNumberException>(() => _cDBService.CalculateFactor(CDB.CDI, CDB.TB, months));

        }
    }
}