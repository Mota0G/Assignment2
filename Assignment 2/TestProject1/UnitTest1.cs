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

        //To test the ID of the class and if it will accept different values. 
        //To guarantee the ID attribute works as expected.

        [TestCase(5)]
        [TestCase(10000)]
        [TestCase(50000)]
        public void GetCorrectID_input5_input10000_input50000_true(int id)
        {
            _product.ProdID = id;
            var newID = _product.ProdID;
            Assert.That(newID, Is.EqualTo(id));
        }



        //To test the Name attribute of the class and if it will accept different values. 
        //To guarantee the Name attribute works as expected.

        [TestCase("tr")]
        [TestCase("gh1234")]
        [TestCase("gh")]
        public void GetCorrectName_inputtr_inputgh1234_inputgh_true(string name)
        {
            _product.ProdName = name;
            var newName = _product.ProdName;
            Assert.That(newName, Is.EqualTo(name));
        }

        //To test the Price attribute of the class and if it will accept different values. 
        //To guarantee the Price attribute works as expected.

        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(5000)]
        public void GetCorrectPrice_input5_input1000_input5000_true(int price)
        {
            _product.ItemPrice = price;
            var newPrice = _product.ItemPrice;
            Assert.That(newPrice, Is.EqualTo(price));
        }

        //To test the Stock attribute of the class and if it will accept different values. 
        //To guarantee the Stock attribute works as expected.

        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(500000)]
        public void GetCorrectAmountStock_input5_input1000_input500000_true(int stockCounter)
        {
            _product.StockAmount = stockCounter;
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.EqualTo(stockCounter));
        }

        //To test the method to increase the stock amount 
        //To guarantee the method for increment of stock works as expected.

        [TestCase(5)]
        [TestCase(1000)]
        [TestCase(10000)]
        public void GetIncreaseStock_input5_input1000_input10000_true(int increase)
        {
            _product.increaseStock(increase);
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.GreaterThan(20));
        }

        //To test the method to decrese the stock amount
        //To guarantee the method for decrement of stock works as expected.

        [TestCase(7)]
        [TestCase(6)]
        [TestCase(5)]
        public void GetDecreseStock_input7_input6_input5_true(int decrease)
        {
            _product.decreaseStock(decrease);
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.LessThan(20));
        }

        // This specific test ensures that the value of DecreaseStock method should not go below zero.
        // To see what happen if the stock is decreased than the available amount
        // Should show result as zero rathen than showing negative values.

        [Test]
        public void DecreaseStockWithAmountExceedingStock_ShouldNotGoBelowZero()
        {
            int decreaseAmount = 60;
            _product.decreaseStock(decreaseAmount);
            var newStock = _product.StockAmount;
            Assert.That(newStock, Is.EqualTo(0), "When decrease in stock happens it should not go below zero like a negative number.");
        }

        // This test ensure that the ProdName can be set to null.
        // Certain creiteria should be required if product name is null.
        // It checks that it handlles such scenerio without any errors.
        [Test]
        public void ProductNameSetToNull_ShouldHandleNull()
        {
            _product.ProdName = "Testing Product";
            _product.ProdName = null;
            Assert.That(_product.ProdName, Is.EqualTo(null), "Product name should be able to be set as null.");
        }
         

    }
}
