namespace WebApplication1.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BacpackId { get; set; }
        public Backpack Backpack { get; set; }
    }
}
