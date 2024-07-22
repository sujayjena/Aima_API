using Aima.Application.Models;
using Aima.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aima.Application.Interfaces
{
    public interface IAdminMasterRepository
    {
        #region Gender
        Task<int> SaveGender(Gender_Request parameters);

        Task<IEnumerable<Gender_Response>> GetGenderList(BaseSearchEntity parameters);

        Task<Gender_Response?> GetGenderById(int Id);
        #endregion

        #region User Designation
        Task<int> SaveUserDesignation(UserDesignation_Request parameters);

        Task<IEnumerable<UserDesignation_Response>> GetUserDesignationList(BaseSearchEntity parameters);

        Task<UserDesignation_Response?> GetUserDesignationById(int Id);
        #endregion
    }
}
