using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vladify.BusinessLogic.Models
{
    public class SongAddModel
    {
        public string Title { get; set; } = string.Empty;
        public string Album { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
