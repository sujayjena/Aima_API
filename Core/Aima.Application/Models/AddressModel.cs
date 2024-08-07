﻿using Aima.Domain.Entities;
using Aima.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Aima.Application.Models
{
    public class AddressModel
    {
    }

    public class Address_Search : BaseSearchEntity
    {
        public long RefId { get; set; }

        public string? RefType { get; set; }
    }

    public class Address_Request : BaseEntity
    {
        //[JsonIgnore]
        public int? RefId { get; set; }

        //[JsonIgnore]
        public string? RefType { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public int? RegionId { get; set; }

        public int? StateId { get; set; }

        public int? DistrictId { get; set; }

        public int? CityId { get; set; }

        public string? PinCode { get; set; }

        public bool? IsDefault { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }
    }

    public class Address_Response : BaseResponseEntity
    {
        public int? RefId { get; set; }

        public string? RefType { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public int? RegionId { get; set; }

        public string? RegionName { get; set; }

        public int? StateId { get; set; }

        public string? StateName { get; set; }

        public int? DistrictId { get; set; }

        public string? DistrictName { get; set; }

        public int? CityId { get; set; }

        public string? CityName { get; set; }

        public string? PinCode { get; set; }

        public bool? IsDefault { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
