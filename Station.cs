using System;
using System.Collections.Generic;

#nullable disable

namespace FirstApp
{
    public partial class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Direction { get; set; }
        public string Path { get; set; }
        public string Text { get; set; }
        public int Views { get; set; }
        public int Comments { get; set; }

        //public virtual Direction DirectionNavigation { get; set; }
    }
}
