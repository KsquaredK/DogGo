using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models.ViewModels
{
    public class Walk
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public int OwnerId { get; set; }
        public Neighborhood Neighborhood { get; set; }
        public Owner Owner { get; set; }

        public Walker WalkerId { get; set; }

        public Dog DogId { get; set; }

        public Dog Dog { get; set; }

        public DateTime Date { get; set; }

        public int TotalDuration { get; set; }


    }
}
