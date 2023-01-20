using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FlashCards.Models
{
    public class FlashCard
    {
        [Key]
        public int Id { get; set; }
        public string TextFront { get; set; } = "FRONT-CARD";
        public string TextBack { get; set; } = "BACK-CARD";
        public IList<FlashCard> Cards { get; set; }
    }
}