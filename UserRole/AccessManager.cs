using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace VacationRequest.UserRole
{
    public class AccessManager : IAccessManager
    {
        public List<EAction> GetAccessForRole(List<Role> roleType)
        {
            // ADMIN RECHTE
            if (roleType.Select(x => x.Type).Contains(ERoleType.Admin))
            {

                return new List<EAction>()
                {
                    EAction.AllowRequest,
                    EAction.RejectRequest,
                    EAction.PendingRequest,
                    EAction.CreateRequest,
                    EAction.ReadRequest,
                    EAction.UpdateRequest,
                    EAction.DeleteRequest
                };
            }
            
            // MANAGER RECHTE
            if (roleType.Select(x =>x.Type).Contains(ERoleType.Manager))
            {
                return new List<EAction>()
                {
                    EAction.AllowRequest,
                    EAction.RejectRequest,
                    EAction.PendingRequest,
                    EAction.CreateRequest,
                    EAction.ReadRequest,
                    EAction.UpdateRequest,
                    EAction.DeleteRequest
                };
            }
            
            // REDAKTEUR RECHTE
            if (roleType.Select(x => x.Type).Contains(ERoleType.Editor))
            {
                return new List<EAction>()
                {
                    EAction.CreateRequest,
                    EAction.ReadRequest,
                    EAction.UpdateRequest,
                    EAction.DeleteRequest
                };
            }
            
            // EMPLOYEE RECHTE
            if (roleType.Select(x => x.Type).Contains(ERoleType.Employee))
            {
                return new List<EAction>()
                {
                    EAction.ReadRequest
                };
            }

            throw new Exception("Keine Implementierung vorhanden");
        }
    }
}