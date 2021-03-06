﻿using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace Abp.VNext.Hello
{
    public partial class StateProvince : Entity<int>
    {
        public StateProvince()
        {
            Cities = new HashSet<City>();
        }
        public virtual string StateProvinceCode { get; set; }
        public virtual string StateProvinceName { get; set; }

        public virtual string ChineseName { get; set; }

        public long Population { get; set; }

        public virtual string CountryId { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }

}
