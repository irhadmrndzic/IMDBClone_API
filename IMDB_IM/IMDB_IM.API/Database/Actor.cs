using System;
using System.Collections.Generic;

#nullable disable

namespace IMDB_IM.API.Database
{
    public partial class Actor
    {
        public Actor()
        {
            MoviesActors = new HashSet<MoviesActor>();
        }

        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<MoviesActor> MoviesActors { get; set; }
    }
}
