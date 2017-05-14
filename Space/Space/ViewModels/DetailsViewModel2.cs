using Space.Models;

namespace Space.ViewModels
{
    public class DetailsViewModel2
    {
        public University University { get; set; }
        public DetailsViewModel2(University university)
        {
            University = university;
        }
    }
}
