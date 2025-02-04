using Assignment_2;
namespace TestProject1
{
    public class Tests
    {
        private Product _product { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _product = new Product(0, "Ball", 0, 4);
        }

        [TestCase(5)]
        [TestCase(10000)]
        [TestCase(50000)]
        public void Test1(int id)
        {
            _product.ProdID = id;
            var newID = _product.ProdID;
            Assert.That(newID, Is.EqualTo(id));
        }

        [TestCase("@")]
        [TestCase("gh1234")]
        [TestCase("")]
        public void Test2(string name)
        {
            _product.ProdName = name;
            var newName = _product.ProdName;
            Assert.That(newName, Is.EqualTo(name));
        }

        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(5000)]
        public void Test3(int price)
        {
            _product.ItemPrice = price;
            var newPrice = _product.ItemPrice;
            Assert.That(newPrice, Is.EqualTo(price));
        }


        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(500000)]
        public void Test4(int stockCounter)
        {
            _product.StockAmount = stockCounter;
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.EqualTo(stockCounter));
        }
        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(10000)]

        public void test5(int increase)
        {
            var newStock = _product.increaseStock(increase);
            Assert.That(newStock, Is.GreaterThan(4));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(5)]
        public void test6(int decrease)
        {
            var newStock = _product.decreaseStock(decrease);
            Assert.That(newStock, Is.LessThan(4));
        }


    }
}
