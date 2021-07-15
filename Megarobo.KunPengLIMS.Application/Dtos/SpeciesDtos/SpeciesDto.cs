using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.Dtos
{
    public class SpeciesDto
    {
        public Guid Id { get; set; }

        public string ChineseName { get; set; }

        public string EnglishName { get; set; }

        public string LatinName { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }
    }
}
