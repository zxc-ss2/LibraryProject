﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCheckLib
{
    public class StringCheck
    {
        /// <summary>
        /// Проверка строки userName на структуру написания имени: 1 заглавгая буква + буквы русского алфавита
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool CheckName(string userName)
        {
            string pattern = @"[А-Я]{1}[а-я]$";

            if(Regex.Match(userName, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userSurname на структуру написания фамилии: 1 заглавгая буква + буквы русского алфавита
        /// </summary>
        /// <param name="userSurname"></param>
        /// <returns></returns>
        public bool CheckSurname(string userSurname)
        {
            string pattern = @"[А-Я]{1}[а-я]$";

            if (Regex.Match(userSurname, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userPatronymic на структуру написания Отчества: 1 заглавгая буква + буквы русского алфавита
        /// </summary>
        /// <param name="userPatronymic"></param>
        /// <returns></returns>
        public bool CheckSPatronymic(string userPatronymic)
        {
            string pattern = @"[А-Я]{1}[а-я]$";

            if (Regex.Match(userPatronymic, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userAddress на структуру написания Адреса: буквы русского алфавита + запятая/пробле/тире + три цифры
        /// </summary>
        /// <param name="userAddress"></param>
        /// <returns></returns>
        public bool CheckAddress(string userAddress)
        {
            string pattern = @"[а-я]+((\,)|(\s)|(\-))+[0-9]{3}";

            if (Regex.Match(userAddress, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userWorkplace на структуру написания места работы: буквы русского алфавита или буквы латинского алфавита или цифры
        /// </summary>
        /// <param name="userWorkplace"></param>
        /// <returns></returns>
        public bool CheckWorkplace(string userWorkplace)
        {
            string pattern = @"[а-я]|[a-z]|[А-Я]|[A-Z]|[0-9]";

            if (Regex.Match(userWorkplace, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userWorkplace на структуру написания места учебы: буквы русского алфавита или буквы латинского алфавита или цифры
        /// </summary>
        /// <param name="userStudyplace"></param>
        /// <returns></returns>
        public bool CheckStudyplace(string userStudyplace)
        {
            string pattern = @"[а-я]|[a-z]|[А-Я]|[A-Z]|[0-9]";

            if (Regex.Match(userStudyplace, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userPhone на структуру написания телефона: 1 цифра(7/+7/8) +10 цифр
        /// </summary>
        /// <param name="userPhone"></param>
        /// <returns></returns>
        public bool CheckPhone(string userPhone)
        {
            string pattern = @"^(\+7|7|8)+([0-9]){10}$";

            if (Regex.Match(userPhone, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userLogin на структуру написания логина: Начинается и кончается на букву/цифру и содержит не более двух "_"/"-" и не подряд.
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
        public bool CheckLogin(string userLogin)
        {
            string pattern = @"^[a-z]+([-_]?[a-z0-9]+){0,2}$";

            if (Regex.Match(userLogin, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка строки userPassword на структуру написания пароля: Содержит строчные/заглавные буквы латинского алфавита, спецсимволы, цифры; должен быть не менее шести символов
        /// </summary>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public bool CheckPassword(string userPassword)
        {
            string pattern = @"(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";

            if (Regex.Match(userPassword, pattern, RegexOptions.IgnoreCase).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
