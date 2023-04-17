namespace GripFoodExam.Entities
{
    public class User
    {
        public string Id { set; get; } = "";

        public string Name { set; get; } = "";

        public string Email { set; get; } = "";

        public string Password { set; get; } = "";

        public List<Cart> Cart { get; set; } = new List<Cart>();


    }
}