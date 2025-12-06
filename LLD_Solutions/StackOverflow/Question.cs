using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Question
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public List<Tag> Tags { get; set; }

        public List<Answer> Answers { get; set; }
        public List<Vote> Votes { get; set; }




    }
}
