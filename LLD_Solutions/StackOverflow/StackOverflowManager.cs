using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class StackOverflowManager
    {
        StackOverflowRepository repository = new StackOverflowRepository();

        public StackOverflowManager()
        {
         
        }

        public int CreateUser(User user)
        {
           return repository.AddUser(user);
        }
        public int PostAQuestion(int userId,Question question)
        {
            question.UserId = userId;
            return repository.AddQuestion(question);
        }

        public int PostAnAnswer(int userId,int questionId, Answer answer) 
        {
            answer.UserID = userId;
            answer.QuestionId = questionId;
            return  repository.AddAnswer(answer);
        }

        public List<Question> GetQuestions(string query)
        {
            return repository.GetQuestions(query);
        }
    }
}
