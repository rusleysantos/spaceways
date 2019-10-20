using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace data_source.Models
{
    class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 {get; set; }
        public string Option5 { get; set; }
    }
}
