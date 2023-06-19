using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Core.Entities
{
    internal class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<List> Lists { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
