using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Controllers
{
    public class BooksController
    {
        DbHelper dbHelper = new DbHelper(); 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List <Models.books> BooksInfoOutput()
        {   
            return dbHelper.context.books.ToList();
        }

        /// <summary>
        /// Проверка на совпадение вводимых данных с данными в бд
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public List<Models.books> BooksMatchUpInfoOutput(string author)
        {
            return dbHelper.context.books.Where(t => t.author.Contains(author) || t.isbn.Contains(author)).ToList();
        }
    }
}
