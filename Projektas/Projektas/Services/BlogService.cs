using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;



namespace Projektas.Services
{
    public class BlogService
    {
        private string _connection;
        public BlogService()

        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
                .Build();

            _connection = config.GetValue<string>("ConnectionStrings:DefaultConnection");
        }
        
        public List<Blog> GetBlogs()
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            var blogs = new List<Blog>();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT login, postName, postDate, id,  blogText FROM blog";
                
                var reader = cmd.ExecuteReader();
                
                using (reader)

                {
                    while (reader.Read())
                    {
                        var blog = new Blog(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetInt32(3),
                            reader.GetString(4));

                        blogs.Add(blog);
                    }
                }
            }
            return blogs;
        }

        public Blog GetBlog(int id)
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT login, postName, postDate, id,  blogText FROM blog WHERE id = @id";
               
                cmd.Parameters.Add(
                    
                    new MySqlParameter()
                    {
                        ParameterName = "@id",
                        DbType = System.Data.DbType.Int32,
                        Value = id
                    }
                    );

                var reader = cmd.ExecuteReader();

                using (reader)
                {
                    reader.Read();

                    return new Blog(
                         reader.GetString(0),
                         reader.GetString(1),
                         reader.GetDateTime(2),
                         reader.GetInt32(3),
                         reader.GetString(4)
                        );
                }
            }
        }

        public void CreateBlog(Blog blog)
        {
            MySqlConnection conn = new MySqlConnection(_connection);

            conn.Open();

            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO blog (login, postName, postDate, id, blogText) " +
                    "VALUES(@login, @PostName, @postDate, @id, @blogText)";

                cmd.Parameters.Add(

                   new MySqlParameter()
                   {
                       ParameterName = "@login",
                       DbType = System.Data.DbType.String,
                       Value = blog.Login
                   }
                   );
                cmd.Parameters.Add(
                   new MySqlParameter()
                   {
                       ParameterName = "@postName",
                       DbType = System.Data.DbType.String,
                       Value = blog.PostName
                   }
                   );
                cmd.Parameters.Add(
                    new MySqlParameter()
                    {
                        ParameterName = "@postDate",
                        DbType = System.Data.DbType.DateTime, 
                        Value = blog.Date
                    }
                   );
                cmd.Parameters.Add(
                   new MySqlParameter()
                   {
                       ParameterName = "@id",
                       DbType = System.Data.DbType.Int32,
                       Value = blog.Id
                   }
                   );
                cmd.Parameters.Add(

                   new MySqlParameter()
                   {
                       ParameterName = "@blogText",
                       DbType = System.Data.DbType.String,
                       Value = blog.BlogText
                   }
                   );

                cmd.ExecuteNonQuery();
            }
        }
    }
}
