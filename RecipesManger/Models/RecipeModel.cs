namespace RecipesManger.Models
{
    public class RecipeModel
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Ingredients { get; set; }
        public string Directions { get; set; }
        public DateTime Modified { get; set; }

    }
}
