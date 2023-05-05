using Yummy.Entities;

namespace Yummy.Repositories
{
    public class FakeRepo
    {
        public static List<HotMeal> GetHotMeals()
        {
            return new List<HotMeal>()
            {
               new HotMeal() { Id = 1, Name = "Beef Stroganoff", Description = "Beef dish with mushrooms and sour cream sauce", Price = 12.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760928/asp-net/task1/beefstroganoff_bgqhuz.jpg" },
               new HotMeal() { Id = 2, Name = "Spaghetti Bolognese", Description = "Pasta dish with meat sauce", Price = 9.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760929/asp-net/task1/spaghettibolognese_pwqmqd.jpg" },
               new HotMeal() { Id = 3, Name = "Fish and Chips", Description = "Battered fish with french fries", Price = 11.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760929/asp-net/task1/fishandchips_d8rswc.jpg" },
               new HotMeal() { Id = 4, Name = "Shepherd's Pie", Description = "Beef with mashed potatoes", Price = 10.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760929/asp-net/task1/shepherdspie_vjtziv.jpg" },
               new HotMeal() { Id = 5, Name = "Chicken Tikka Mas", Description = "Indian chicken dish with yogurt and spices", Price = 12.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760929/asp-net/task1/chickentikkamasala_eogniv.jpg" },
               new HotMeal() { Id = 6, Name = "Pork Adobo", Description = "Filipino pork dish with vinegar and soy sauce", Price = 11.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760929/asp-net/task1/porkadobo_wuvpmu.jpg" },
               new HotMeal() { Id = 7, Name = "Chicken Parmesan", Description = "Chicken breast with melted cheese", Price = 10.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760928/asp-net/task1/chickenparmesan_zreqgx.jpg" },
               new HotMeal() { Id = 8, Name = "Beef Curry", Description = "Beef dish with curry sauce and rice", Price = 12.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760928/asp-net/task1/beefcurry_vqucsq.jpg" },
               new HotMeal() { Id = 9, Name = "Chicken Alfredo", Description = "Pasta dish with chicken and creamy sauce", Price = 10.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682760928/asp-net/task1/chickenalfredo_xhg9pe.jpg" }
            };
        }

        public static List<Drink> GetDrinks()
        {
            return new List<Drink>()
            {
                new Drink { Id = 1, Name = "Coke", Description = "Refreshing soda", Price = 1.50m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682756799/asp-net/task1/Coke_za9o85.jpg" },
                new Drink { Id = 2, Name = "Pepsi", Description = "Another soda brand", Price = 1.50m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757000/asp-net/task1/pepsi_hlfxwm.jpg" },
                new Drink { Id = 3, Name = "Lemonade", Description = "Tart and sweet drink", Price = 2.00m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/lemonade_f4asad.jpg" },
                new Drink { Id = 4, Name = "Iced tea", Description = "Cold and refreshing tea", Price = 1.75m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/icedtea_bhw8kl.jpg" },
                new Drink { Id = 5, Name = "Orange juice", Description = "Fresh squeezed orange juice", Price = 2.50m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/orangejuice_qyvphh.jpg" },
                new Drink { Id = 6, Name = "Limeade", Description = "Tangy and sweet lime drink", Price = 2.00m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/limeade_ra0iyi.jpg" },
                new Drink { Id = 7, Name = "Root beer", Description = "Classic soda flavor", Price = 1.75m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/rootbeer_d4ijuy.jpg" },
                new Drink { Id = 8, Name = "Milkshake", Description = "Creamy and delicious drink", Price = 3.00m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/milkshake_vj9syo.jpg" },
                new Drink { Id = 9, Name = "Water", Description = "Simple and refreshing drink", Price = 1.00m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682757115/asp-net/task1/water_jubwla.jpg" }
            };
        }

        public static List<FastFood> GetFastFoods()
        {
            return new List<FastFood>()
            {
                 new FastFood() { Id = 1, Name = "Cheeseburger", Description = "Classic burger with cheese", Price = 5.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682766250/asp-net/task1/cheeseburger_vn46xx.jpg" },
                 new FastFood() { Id = 2, Name = "Chicken Sandwich", Description = "Breaded chicken sandwich with lettuce and mayo", Price = 4.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761733/asp-net/task1/chickensandwich_btqglv.jpg" },
                 new FastFood() { Id = 3, Name = "French Fries", Description = "Thin cut potatoes fried and salted", Price = 2.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761733/asp-net/task1/frenchfries_f8wiwt.jpg" },
                 new FastFood() { Id = 4, Name = "Onion Rings", Description = "Breaded and fried onion rings", Price = 3.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761734/asp-net/task1/onionrings_s1tdwp.jpg" },
                 new FastFood() { Id = 5, Name = "Pizza", Description = "Classic cheese pizza", Price = 8.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761842/asp-net/task1/pizza_bqz9rf.jpg" },
                 new FastFood() { Id = 6, Name = "Hot Dog", Description = "Grilled hot dog with ketchup and mustard", Price = 3.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761733/asp-net/task1/hotdog_tp1vel.jpg" },
                 new FastFood() { Id = 7, Name = "Taco", Description = "Mexican soft shell taco with beef and cheese", Price = 2.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761734/asp-net/task1/taco_x9bpva.jpg" },
                 new FastFood() { Id = 8, Name = "Burrito", Description = "Mexican wrap with rice, beans, and meat", Price = 7.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761734/asp-net/task1/burrito_eqpyle.jpg" },
                 new FastFood() { Id = 9, Name = "Chicken Nuggets", Description = "Breaded chicken nuggets", Price = 3.99m, ImageURL = "https://res.cloudinary.com/dbriqxpaa/image/upload/v1682761734/asp-net/task1/chickennuggets_ogkczi.jpg" }
            };
        }
    }
}
