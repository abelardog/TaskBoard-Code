using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBoard.Core.Entities
{
    internal class List
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public List<Card> Cards { get; set; }
    }
}
