namespace BackEndExamGripFood.Models
{
    public class AddToCartModel
    {
        public string FoodItemsId { get; set; } = "";
        public int Qty { get; set; }
    }

    public class CartDetailModel
    {
        public string Id { get; set; } = "";
        public string FoodItemId { get; set; } = "";
        public decimal FoodItemPrice { get; set; }
        public decimal Qty { get; set; }

    }
}
