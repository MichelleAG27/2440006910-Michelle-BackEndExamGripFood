namespace GripFoodExam.Entities
{
    public class FoodItem
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public decimal Price { get; set; }

        public string RestaurantId { set; get; } = "";
        public Restaurant Restaurant { set; get; } = null!;

        public List<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
    }
}