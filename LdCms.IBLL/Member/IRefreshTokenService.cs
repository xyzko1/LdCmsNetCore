﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LdCms.IBLL.Member
{
    using EF.DbModels;
    using LdCms.EF.DbStoredProcedure;
    public partial interface IRefreshTokenService:IBaseService<Ld_Member_RefreshToken>
    {
    }
}
