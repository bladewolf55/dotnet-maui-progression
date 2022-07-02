using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Progression.Domain.Models
{
    public class NumberMap
    {
        public List<NumberMapItem> Map { get; set; } = new();

        public string? ToWord(int number) => Map.SingleOrDefault(a => a.Number.Equals(number))?.Word;

    }
}
