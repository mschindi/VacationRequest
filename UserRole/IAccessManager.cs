using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Storage;

namespace VacationRequest.UserRole
{
    public interface IAccessManager
    {
        public List<EAction> GetAccessForRole(List<Role> roleType);
    }
}