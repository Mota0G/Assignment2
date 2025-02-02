namespace Assignment_2
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public int ItemPrice { get; set; }
        public int StockAmount { get; set; }

        public Product(int ProdID, string ProdName, int ItemPrice, int StockAmount)
        {
            this.ProdID = ProdID;   
            this.ProdName = ProdName;
            this.ItemPrice = ItemPrice;
            this.StockAmount = StockAmount;
        }

        public int increaseStock(int increase)
        { 
            this.StockAmount += increase;
            return this.StockAmount;
        }
      
        public int decreaseStock(int decrease)
        {
            this.StockAmount -= decrease;
            return this.StockAmount;
        }
      

    }
}
