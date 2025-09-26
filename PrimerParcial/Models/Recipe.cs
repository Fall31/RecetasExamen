namespace PrimerParcial.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PreparationTimeMinutes { get; set; }
        public int Servings { get; set; }
        public string Instructions { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public Category Category { get; set; }
    }
}
