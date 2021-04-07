using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace LibraryProject.Controllers
{
    public class ClientsController
    {
        DbHelper dbHelper = new DbHelper();

        public List<Models.clients> ClientsInfoOutput()
        {
            return dbHelper.context.clients.ToList();
        }

        public List<Models.clients> ClientsMatchUpInfoOutput(string info)
        {
         return  dbHelper.context.clients.Where(t => t.name.Contains(info) || t.surname.Contains(info) ||
                                                t.patronymic.Contains(info) || t.trading.ticket.Contains(info)).ToList();
        }

        /// <summary>
        /// Проверка логина и пароля при авторизации
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUser(string login, string password)
        {
            var user = dbHelper.context.clients.AsNoTracking().FirstOrDefault(t => t.login == login && t.password == password);

            if(user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return false;
            }

            return true;    
        }

        public void AddNewUser(string userName, string userSurname, string userPatronymic, DateTime userDate, string userAddress, string userWorkplace, string userStudyplace, string userPhone, string userLogin, string userPassword)
        {
            dbHelper.context.clients.Add(new Models.clients
            {
                id_trading = null,
                id_role = 3,
                name = userName,
                surname = userSurname,
                patronymic = userPatronymic,
                birthday = userDate,
                address = userAddress,
                workplace = userWorkplace,
                studyplace = userStudyplace,
                phone = userPhone,
                login = userLogin,
                password = userPassword
            });

            dbHelper.context.SaveChanges();
        }

        public bool CheckForAnExistingkUser(string userLogin, string userPassword)
        {
            var check = dbHelper.context.clients.AsNoTracking().FirstOrDefault(t => t.login != userLogin || t.password != userPassword);

            if (check != null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return false;
            }

            return true;
        }
    }
}
