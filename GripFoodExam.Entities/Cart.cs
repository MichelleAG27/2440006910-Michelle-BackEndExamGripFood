﻿namespace GripFoodExam.Entities
{
    public class Cart
    {
        public string Id { set; get; } = "";

        public string UserId { set; get; } = "";

        public User User { set; get; } = null!;

        public string RestaurantId { set; get; } = "";

        public Restaurant Restaurant { set; get; } = null!;

        public List<CartDetail> CartDetails { get; set; } = new List<CartDetail>();
    }
}