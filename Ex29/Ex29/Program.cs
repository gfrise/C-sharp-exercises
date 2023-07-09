using Ex29;

var products = new List<Product>
{
    new Product {Name = "iPhone", CategoryID = 1 },
    new Product {Name = "iMac", CategoryID = 2 },
    new Product {Name = "VisionPro", CategoryID = 3 },
    new Product {Name = "iPad", CategoryID = 1 },
    new Product {Name = "MacBook Air", CategoryID = 2 },
    new Product {Name = "AppleWatch", CategoryID = 3 },
    new Product {Name = "iPod", CategoryID = 1 },
    new Product {Name = "MacMini", CategoryID = 2 },

};

var categories = new List<Category>
{
    new Category {Name = "Portables", CategoryID = 1},
    new Category {Name = "Computer", CategoryID = 2},
    new Category {Name = "Wearables", CategoryID = 3},
};

var combined = products.Join(
    categories,
    product => product.CategoryID,
    category => category.CategoryID,
    (product, category) => new { 
        product.Name, 
        Class = category.Name}
    );

foreach(var x in combined)
{
    Console.WriteLine($"{x.Name} belongs to {x.Class}");
}