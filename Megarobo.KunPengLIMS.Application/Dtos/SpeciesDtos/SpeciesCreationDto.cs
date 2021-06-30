using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Megarobo.KunPengLIMS.Domain.Entities;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SpeciesCreationDto
    {
        [Required(ErrorMessage ="请提供中文")]
        public string ChineseName { get; set; }

        [Required(ErrorMessage ="请提供英文")]
        public string EnglishName { get; set; }

        [Required(ErrorMessage ="请提供拉丁文")]
        public string LatinName { get; set; }

        public Link SpeciesId { get; set; }
    }
}
