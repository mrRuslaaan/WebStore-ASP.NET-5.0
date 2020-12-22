using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace WebStore.ViewModels
{
    public class WorkerViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        /// <summary>Имя</summary>
        [Display(Name ="Имя")]
        [Required(ErrorMessage ="Обязательное поле")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Имя должно быть больше 1 и меньше 100")]
        public string FirstName { get; set; }

        /// <summary>Фамилия</summary>
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Обязательное поле")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Фамилия дожна быть больше 1 и меньше 100")]
        public string LastName { get; set; }

        /// <summary>Отчество</summary>
        [Display(Name = "Отчество")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Отчество быть больше 1 и меньше 100")]
        public string Patronymic { get; set; }

        /// <summary>Возраст</summary>
        [Display(Name = "Возраст")]
        [Range(18,65)]
        public int Age { get; set; }

        /// <summary>Должность</summary>
        [Display(Name = "Должность")]
        public string Position { get; set; }
    }
}
