﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    /// <summary>Сотрудник</summary>
    public class Worker
    {
        public int Id { get; set; }

        /// <summary>Имя</summary>
        public string FirstName { get; set; }

        /// <summary>Фамилия</summary>
        public string LastName { get; set; }

        /// <summary>Отчество</summary>
        public string Patronymic { get; set; }

        /// <summary>Возраст</summary>
        public int Age { get; set; }

        /// <summary>Должность</summary>
        
        public string Position { get; set; }
    }
}
