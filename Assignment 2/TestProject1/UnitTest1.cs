using Assignment_2;
namespace TestProject1
{
    public class Tests
    {
        private Product _product { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _product = new Product(0, "Ball", 0, 20);
        }

        [TestCase(5)]
        [TestCase(10000)]
        [TestCase(50000)]
        public void GetCorrectID_input5_input10000_input50000_true(int id)
        {
            _product.ProdID = id;
            var newID = _product.ProdID;
            Assert.That(newID, Is.EqualTo(id));
        }

        [TestCase("tr")]
        [TestCase("gh1234")]
        [TestCase("gh")]
        public void GetCorrectName_inputtr_inputgh1234_inputgh_true(string name)
        {
            _product.ProdName = name;
            var newName = _product.ProdName;
            Assert.That(newName, Is.EqualTo(name));
        }

        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(5000)]
        public void GetCorrectPrice_input5_input1000_input5000_true(int price)
        {
            _product.ItemPrice = price;
            var newPrice = _product.ItemPrice;
            Assert.That(newPrice, Is.EqualTo(price));
        }


        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(500000)]
        public void GetCorrectAmount_input5_input1000_input500000_true(int stockCounter)
        {
            _product.StockAmount = stockCounter;
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.EqualTo(stockCounter));
        }
        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(10000)]

        public void GetIncreaseStock_input5_input1000_input10000_true(int increase)
        {
            _product.increaseStock(increase);
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.GreaterThan(20));
        }

        [TestCase(7)]
        [TestCase(6)]
        [TestCase(5)]
        public void GetDecreseStock_input7_input6_input5_true(int decrease)
        {
            _product.decreaseStock(decrease);
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.LessThan(20));
        }


    }
}
