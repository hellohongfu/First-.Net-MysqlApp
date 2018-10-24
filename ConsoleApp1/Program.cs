using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            FirstMySqlEntityModel context = new FirstMySqlEntityModel();

            Video entity = new Video() {  Id=1, Name="家有儿女", Url= "www.0run.com",Price = 122 };
            Video entity2 = new Video() { Id = 2, Name = "家有儿女2", Url = "www.0run.com", Price = 122 };
            context.Videos.Add( entity);
            context.Videos.Add(entity2);
            context.SaveChanges();

            var list = context.Videos.ToList();

            foreach (var item in list)
            {
                Console.Write(item.Url);
            }


            //

        }
    }
}
