namespace KonusarakOgren.Areas.Identity.Data
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public int UnitInStock { get; set; }

    }
}
