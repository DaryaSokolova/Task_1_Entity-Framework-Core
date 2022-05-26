using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp
{
    public partial class Direction
    {
        public Direction()
        {
            Stations = new HashSet<Station>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }

        public virtual ICollection<Station> Stations { get; set; }
    }
}
