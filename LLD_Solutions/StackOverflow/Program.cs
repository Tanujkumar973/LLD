using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { UserName = "Alice" };
            User user2 = new User() { UserName = "Bob" };
            User user3 = new User() { UserName = "Charlie" };
            User user4 = new User() { UserName = "Diana" };
            StackOverflowManager manager = new StackOverflowManager();
            int userId1 = manager.CreateUser(user1);
            int userId2 = manager.CreateUser(user2);
            int userId3 = manager.CreateUser(user3);
            int userId4 = manager.CreateUser(user4);
            int questionId1 = manager.PostAQuestion(userId1, new Question()
            {
                Title = "What is C#?",
                Content = "Can someone explain what C# is used for?",
                Tags = new List<Tag>() { new Tag() { TagName = "C#" }, new Tag() { TagName = "Programming" } }
            });
            int ansId = manager.PostAnAnswer(userId2, questionId1, new Answer()
            {
                Content = "C# is a programming language developed by Microsoft used for building different types of Apps",
            });

            var res =manager.GetQuestions("C#");
            Console.ReadLine();


        }
    }
}
