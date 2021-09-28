using System;


namespace Projektas
{
    public class Blog
    {
        public string Login { get; }
        public string PostName { get;  }
        public DateTime Date { get; }
        public int Id { get; }
        public string BlogText { get; }

        public Blog

            (string login, 
            string postName, 
            DateTime date, 
            int id, 
            string blogText)
        {
            Login = login;
            PostName = postName;
            Date = date;
            Id = id;
            BlogText = blogText;
        }
    }
}
