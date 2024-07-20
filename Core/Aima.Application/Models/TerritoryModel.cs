﻿using Aima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aima.Application.Models
{
    public class TerritoryModel
    {
    }

    #region Region

    public class Region_Request : BaseEntity
    {
        public string? RegionName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Region_Response : BaseResponseEntity
    {
        public string? RegionName { get; set; }

        public bool? IsActive { get; set; }
    }

    #endregion

    #region State

    public class State_Request : BaseEntity
    {
        public string? StateName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class State_Response : BaseResponseEntity
    {
        public string? StateName { get; set; }

        public bool? IsActive { get; set; }
    }

    #endregion

    #region District

    public class District_Request : BaseEntity
    {
        public string? DistrictName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class District_Response : BaseResponseEntity
    {
        public string? DistrictName { get; set; }

        public bool? IsActive { get; set; }
    }

    #endregion

    #region City

    public class City_Request : BaseEntity
    {
        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class City_Response : BaseResponseEntity
    {
        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    #endregion

    #region Area

    public class Area_Request : BaseEntity
    {
        public string? AreaName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Area_Response : BaseResponseEntity
    {
        public string? AreaName { get; set; }

        public bool? IsActive { get; set; }
    }

    #endregion

    #region City Grade

    public class CityGrade_Request : BaseEntity
    {
        public string? CityGrade { get; set; }

        public bool? IsActive { get; set; }
    }

    public class CityGrade_Response : BaseResponseEntity
    {
        public string? CityGrade { get; set; }

        public bool? IsActive { get; set; }
    }

    #endregion

    #region Territories

    public class Territories_Request : BaseEntity
    {
        public int? RegionId { get; set; }

        public int? StateId { get; set; }

        public int? DistrictId { get; set; }

        public int? CityId { get; set; }

        public int? AreadId { get; set; }

        public int? CityGradeId { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Territories_Response : BaseResponseEntity
    {
        public int? RegionId { get; set; }

        public string? RegionName { get; set; }

        public int? StateId { get; set; }

        public string? StateName { get; set; }

        public int? DistrictId { get; set; }

        public string? DistrictName { get; set; }

        public int? CityId { get; set; }

        public string? CityName { get; set; }

        public int? AreadId { get; set; }

        public string? AreaName { get; set; }

        public int? CityGradeId { get; set; }

        public string? CityGrade { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Territories_State_Dist_City_Area_Search
    {
        public int? RegionId { get; set; }

        public int? StateId { get; set; }

        public int? DistrictId { get; set; }

        public int? CityId { get; set; }
        public int? CityGradeId { get; set; }
    }

    public class Territories_State_Dist_City_Area_Response
    {
        public int? Id { get; set; }

        public string? Value { get; set; }

        public string? Text { get; set; }
    }

    #endregion
}
