using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

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

            members
                .Where(IsMember(user))
                .DefaultIfEmpty(DefaultMember())
                .Select(ToFormat)
                .ToList()
                .ForEach(WriteLine);

            Func<Member, bool> IsMember(Member member)
                => x => x.Username == member.Username && x.Password == member.Password;

            Member DefaultMember()
                => new Member {Username = string.Empty, Password = string.Empty};

            string ToFormat(Member x) => $"Welcome : {x.Username}";
        }
    }
}