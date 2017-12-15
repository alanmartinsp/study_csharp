﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curso_1931___Dev_App_Web_com_ASP.NET_MVC.Models
{
    public class Product
    {
        [Display(Name = "Código")] // Alterando nome da propriedade na view (Somente quando utilizamos o htmlHelper)
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Data")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
    }
}