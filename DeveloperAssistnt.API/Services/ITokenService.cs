using DeveloperAssistnt.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperAssistnt.API.Services
{
   public  interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
