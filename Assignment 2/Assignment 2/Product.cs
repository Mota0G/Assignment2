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

        public void increaseStock(int increase)
        { 
            this.StockAmount += increase;
        }
      
        public void decreaseStock(int decrease)
        {
            this.StockAmount -= decrease;
        }
      

    }
}
