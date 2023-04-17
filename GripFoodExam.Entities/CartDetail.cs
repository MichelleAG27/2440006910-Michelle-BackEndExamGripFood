namespace GripFoodExam.Entities
{
    public class CartDetail
    {
        public string Id { set; get; } = "";

        public string CartId { set; get; } = "";

        public Cart Cart { set; get; } = null!;

        public string FoodItemId { set; get; } = "";
        public FoodItem FoodItem { set; get; } = null!;
        public int Quantity { set; get; }

    }
}