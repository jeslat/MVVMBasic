using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBasic.Model
{
    public class MovieItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public bool AlreadySeen { get; set; }

        public static MovieItem GetMock()
        {
            var movie = new MovieItem()
            {
                Title = "The Imitation Game",
                Description = "During World War II, mathematician Alan Turing tries to crack the enigma code with help from fellow mathematicians.",
                Director = "Morten Tyldum",
                AlreadySeen = true
            };

            return movie;
        }
    }
}
