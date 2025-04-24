namespace RestaurantPOS.Data;

public static class SeedData
{
    public static List<MenuCategory> GetMenuCategories()
    {
        return new List<MenuCategory>
        {
            new MenuCategory { Id = 2, Name = "Main Plate" },
            new MenuCategory { Id = 3, Name = "Drinks", },
            new MenuCategory { Id = 4, Name = "Desserts"},
            new MenuCategory { Id = 5, Name = "Salade" }
        };
    }
    public static List<MenuItem> GetMenuItems()
    {
        return new List<MenuItem>
        {

            new MenuItem { Id = 2, Name = "Biryani", Icon = "biryani.png", Description = "Spicy chicken biryani", Price = 7.99m },
            new MenuItem { Id = 3, Name = "Buns", Icon = "buns.png", Description = "Freshly baked buns", Price = 2.99m },
            new MenuItem { Id = 4, Name = "Burger and Fries Combo", Icon = "burger_fries_combo.png", Description = "Burger with fries", Price = 5.99m },
            new MenuItem { Id = 5, Name = "Cake", Icon = "cake.png", Description = "Delicious chocolate cake", Price = 3.99m },
            new MenuItem { Id = 6, Name = "Chocolate", Icon = "chocolate.png", Description = "Rich chocolate bar", Price = 1.99m },
            new MenuItem { Id = 7, Name = "Cocktail", Icon = "cocktail.png", Description = "Refreshing cocktail", Price = 6.99m },
         
            new MenuItem { Id = 21, Name = "Ice Cream", Icon = "ice_cream.png", Description = "Cold ice cream", Price = 2.99m },
            new MenuItem { Id = 22, Name = "Idli Platter", Icon = "idli_platter.png", Description = "South Indian idli platter", Price = 3.99m },
            new MenuItem { Id = 23, Name = "Kebab", Icon = "kebab.png", Description = "Grilled kebab", Price = 5.99m },
            new MenuItem { Id = 24, Name = "Kimchi Jjigae", Icon = "kimchi_jjiage.png", Description = "Spicy kimchi stew", Price = 6.99m },
            new MenuItem { Id = 25, Name = "Laddu", Icon = "laddu.png", Description = "Sweet laddu", Price = 1.99m },
          
            new MenuItem { Id = 31, Name = "Noodles", Icon = "noodles.png", Description = "Stir_fried noodles", Price = 4.99m },
            new MenuItem { Id = 32, Name = "Orange Juice", Icon = "orange_juice.png", Description = "Fresh orange juice", Price = 2.49m },
            new MenuItem { Id = 33, Name = "Pancakes", Icon = "pancakes.png", Description = "Fluffy pancakes", Price = 3.99m },
            new MenuItem { Id = 34, Name = "Paneer", Icon = "paneer.png", Description = "Paneer curry", Price = 4.99m },
            new MenuItem { Id = 35, Name = "Pasta", Icon = "pasta.png", Description = "Italian pasta", Price = 5.99m },
            new MenuItem { Id = 36, Name = "Pie", Icon = "pie.png", Description = "Fruit pie", Price = 3.99m },
            new MenuItem { Id = 37, Name = "Pizza Slice", Icon = "pizza_slice.png", Description = "Slice of pizza", Price = 2.99m },
           
            new MenuItem { Id = 46, Name = "Snacks", Icon = "snacks.png", Description = "Various snacks", Price = 2.99m },
            new MenuItem { Id = 47, Name = "Soda", Icon = "soda.png", Description = "Refreshing soda", Price = 1.49m },
            new MenuItem { Id = 48, Name = "Soft Drink", Icon = "soft_drink.png", Description = "Cold soft drink", Price = 1.99m },
            new MenuItem { Id = 49, Name = "Soju", Icon = "soju.png", Description = "Korean soju", Price = 3.99m },
            new MenuItem { Id = 50, Name = "Spaghetti", Icon = "spaghetti.png", Description = "Italian spaghetti", Price = 5.99m },
            new MenuItem { Id = 51, Name = "Sushi", Icon = "sushi.png", Description = "Assorted sushi", Price = 8.99m },
            new MenuItem { Id = 52, Name = "Taco", Icon = "taco.png", Description = "Mexican taco", Price = 3.99m },
            new MenuItem { Id = 53, Name = "Thai Food", Icon = "thai_food.png", Description = "Spicy Thai food", Price = 6.99m },
            new MenuItem { Id = 54, Name = "Thali", Icon = "thali.png", Description = "Indian thali", Price = 7.99m },
            new MenuItem { Id = 55, Name = "Wrap", Icon = "wrap.png", Description = "Healthy wrap", Price = 4.99m }
        };
    }

    public static List<MenuItemCategoryMapping> GetMenuItemCategoryMappings()
    {
        return new List<MenuItemCategoryMapping>
        {
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 1 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 6 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 7 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 8 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 10 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 11 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 32 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 47 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 48 },
            new MenuItemCategoryMapping { CategoryId = 1, MenuItemId = 49 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 2 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 13 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 14 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 18 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 20 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 22 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 23 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 24 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 26 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 28 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 29 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 31 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 34 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 35 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 38 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 39 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 40 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 41 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 45 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 50 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 51 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 52 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 53 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 54 },
            new MenuItemCategoryMapping { CategoryId = 2, MenuItemId = 55 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 3 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 15 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 16 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 17 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 19 },
            new MenuItemCategoryMapping { CategoryId = 3, MenuItemId = 30 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 5 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 8 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 9 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 21 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 25 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 27 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 33 },
            new MenuItemCategoryMapping { CategoryId = 4, MenuItemId = 36 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 4 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 12 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 37 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 38 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 45 },
            new MenuItemCategoryMapping { CategoryId = 5, MenuItemId = 46 }
        };
    }
}