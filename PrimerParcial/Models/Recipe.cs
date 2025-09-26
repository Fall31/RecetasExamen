using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The title is required")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="The title needs beetwen 3 to 100 caracters")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage ="The time is required")]
        [Range(0,int.MaxValue,ErrorMessage ="Time can't be negative")]
        public int PreparationTimeMinutes { get; set; }
        [Required(ErrorMessage ="The serving are required")]
        [Range(0,int.MaxValue,ErrorMessage ="The servings can't be negative")]
        public int Servings { get; set; }
        [Required(ErrorMessage ="The instructions are needed")]
        [StringLength(int.MaxValue,MinimumLength =3,ErrorMessage ="The instructions need to be coherent")]
        public string Instructions { get; set; }
        [Required(ErrorMessage ="The date is required")]
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public Category Category { get; set; }
    }
}
