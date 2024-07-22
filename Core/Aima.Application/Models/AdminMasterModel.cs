using Aima.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aima.Application.Models
{
    public class AdminMasterModel
    {
    }

    #region Gender
    public class Gender_Request : BaseEntity
    {
        [DefaultValue("")]
        public string? GenderName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class Gender_Response : BaseResponseEntity
    {
        public string? GenderName { get; set; }

        public bool? IsActive { get; set; }
    }
    #endregion

    #region User Designation
    public class UserDesignation_Request : BaseEntity
    {
        [DefaultValue("")]
        public string? UserDesignationName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class UserDesignation_Response : BaseResponseEntity
    {
        public string? UserDesignationName { get; set; }

        public bool? IsActive { get; set; }
    }
    #endregion
}
