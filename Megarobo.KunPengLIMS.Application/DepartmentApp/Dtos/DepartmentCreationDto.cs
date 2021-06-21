﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Megarobo.KunPengLIMS.Application.DepartmentApp.Dtos
{
    public class DepartmentCreationDto
    {
        public string Name { get; set; }

        public string Manager { get; set; }

        public string ContactNumber { get; set; }

        public int OrdinalNumber { get; set; }

        public bool IsActive { get; set; }

        public Guid ParentId { get; set; }
    }
}