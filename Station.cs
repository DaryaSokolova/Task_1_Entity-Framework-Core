using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp
{
    public partial class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Distance { get; set; }
        public bool Turnstiles { get; set; }
        public int Direction { get; set; }

        public virtual Direction DirectionNavigation { get; set; }
    }
}
