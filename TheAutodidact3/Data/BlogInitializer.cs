//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TheAutodidact3.Models;

//namespace TheAutodidact3.Data
//{
//    public class BlogInitializer
//    {
//        public static void Initialize(BlogDbContext context)
//        {
//            if (context.Blogs.Any())
//            {
//                return; //db has been seeded
//            }

//            else
//            {
//                var blogs = new Blog[]
//                {
//                    new Blog{Id=1, Author="Joe", Title="Test", Content="Hi, this is a test entry to seed your blog"}
//                };

//                foreach (Blog b in blogs)
//                {
//                    context.Blogs.Add(b);
//                }
//                context.SaveChanges();
//            }
            
//        }
//    }
//}
