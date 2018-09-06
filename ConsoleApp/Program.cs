using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var members = new List<Member>
            {
                new Member {Username = "Sam", Password = "1234"},
                new Member {Username = "You", Password = "4567"}
            };

            var user = new Member {Username = "Sam", Password = "1234"};

            var member = members
                .FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);

            string result;
            
            if (member != null)
            {
                result = member.Username;
            }
            else
            {
                result = "";
            }
            
            Console.WriteLine($"Welcome {result}");
        }
    }
}