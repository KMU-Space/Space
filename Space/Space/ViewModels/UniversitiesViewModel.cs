using System.Collections.ObjectModel;
using Space.Models;
using Space.Helpers;

namespace Space.ViewModels
{
    public class UniversitiesViewModel
    {
        public ObservableCollection<University> Universities { get; set; }
        public ObservableCollection<Grouping<string, University>> UniversitiesGrouped { get; set; }

        public UniversitiesViewModel()
        {
            Universities = UniversityHelper.Universities;
            UniversitiesGrouped = UniversityHelper.UniversitiesGrouped;
        }

        public int UniversityCount => Universities.Count;
    }
}
