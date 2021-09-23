using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogGo.Models.ViewModels
{
    public class WalkerProfileViewModel
    {
        public Walker Walker { get; set; }

        public Neighborhood Neighborhood { get; set; }

        public List<Owner> Owners { get; set; }

        public List<Walk> Walks { get; set; }
    }
}


//join walker to owner by walk.dogId > dog.ownerId > owner.id in repo