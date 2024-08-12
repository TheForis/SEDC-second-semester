using _3rdClassHomework.Models;

namespace _3rdClassHomework.Db
{
    public static class StaticDb
    {
        public static List<Beverage> Beverages = new List<Beverage>()
        {
            new Beverage()
            {
                Brand = "Pivara Skopje",
                Type = "Beer"
            },
            new Beverage()
            {
                Brand = "Tikves",
                Type = "Wine"
            },
            new Beverage()
            {
                Brand = "Krali Marko",
                Type = "Beer"
            },
            new Beverage()
            {
                Brand= "Viva",
                Type = "Juice"
            },
            new Beverage()
            {
                Brand = "Pivara Skopje",
                Type = "Wine"
            }
        };
    }
}
