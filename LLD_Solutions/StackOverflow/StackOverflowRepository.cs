using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class StackOverflowRepository
    {
        private List<Question> questions;
        private List<Answer> answers;
        private List<User> users;
        private readonly object idLock = new object();
        int counter = 0;
        public StackOverflowRepository() {
            questions = new List<Question>();
            answers = new List<Answer>();
            users = new List<User>();
        }

        public int AddUser(User user)
        {
            user.UserId = GenerateUniqueId();
            users.Add(user);
            return user.UserId;
        }
        public int AddQuestion(Question question) {
            question.QuestionId = GenerateUniqueId();
            question.Answers = new List<Answer>();
            questions.Add(question);
            return question.QuestionId;
        }

        public int AddAnswer(Answer answer)
        {
            Question question = questions.FirstOrDefault(s => s.QuestionId == answer.QuestionId);
            if(question == null)
            {
                throw new Exception("Question not found");
            }
            answer.AnswerId = GenerateUniqueId();
            question.Answers.Add(answer);
            answers.Add(answer);
            return answer.AnswerId;
        }

        public int GenerateUniqueId()
        {
            lock (idLock)
            {
                return counter++;
            }
        }
        public List<Question> GetQuestions(string query)
        {
         
          return questions.Where(x=>x.Content.Contains(query) || x.Title.Contains(query) || x.Tags.Any(t=>t.TagName.Contains(query)))
                .ToList();
        }

         public void VoteQuestion(int questionId,Vote vote,int userId)
        {
            Question question = questions.FirstOrDefault(s => s.QuestionId == questionId);
            if(question == null)
            {
                throw new Exception("Question not found");
            }
            question.Votes.Add(vote);
            User user = users.First(s => s.UserId == question.UserId);
            user.Reputation += vote.Value * 5 ;
        }
        public void VoteAnswer(int answerId, Vote vote, int userId)
        {
            Answer answer = answers.FirstOrDefault(s => s.AnswerId == answerId);
            if (answer == null)
            {
                throw new Exception("Answer not found");
            }
            answer.Votes.Add(vote);
            User user = users.First(s => s.UserId == answer.UserID);
            user.Reputation += vote.Value * 5;
        }
    }
}
