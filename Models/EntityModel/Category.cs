namespace EntityModel
{
    public class Category
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int OrderID { get; set; }
        public long ParentID { get; set; }
        public string Image { get; set; }
    }
}
