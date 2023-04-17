namespace BackEndExamGripFood.Models
{
    public class FoodItemDetail
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string RestaurandId { get; set; } = "";
    }
}
