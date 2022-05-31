namespace KonusarakOgren.Areas.Identity.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Products Product { get; set; }
        public ApplicationUser User { get; set; }

    }
}
