using Space.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space.ViewModels
{
    public class DetailsViewModel
    {
        public Monkey Monkey { get; set; }
        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
        }
    }
}
