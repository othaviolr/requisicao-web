using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTP
{
    class Tarefa
    {

        public string userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine("Objeto Tarefa");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Finalizou?: {completed}");
            Console.WriteLine("");
            Console.WriteLine("========================");

        }

  }
}

