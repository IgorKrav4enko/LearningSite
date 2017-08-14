using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnswerQuestion.Models
{
    public class AnswerQuestion
    {
        public int Id { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public int TechnologyType { get; set; }
    }

    public class Tag
    {
        public string TagName { get; set; }
    }
}