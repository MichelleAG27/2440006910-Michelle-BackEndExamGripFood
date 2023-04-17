namespace GripFoodExam.Entities
{
    public class Restaurant
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public List<FoodItem> FoodItems { get; set; } = new List<FoodItem>();

        public List<Cart> Carts { get; set; } = new List<Cart>();
    }
}