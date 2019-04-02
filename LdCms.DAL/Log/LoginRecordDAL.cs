﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LdCms.DAL.Log
{
    using EF.DbModels;
    using EF.DbEntitiesContext;
    using IDAL.Log;
    /// <summary>
    /// 
    /// </summary>
    public partial class LoginRecordDAL:BaseDAL<Ld_Log_LoginRecord>,ILoginRecordDAL
    {
        public LoginRecordDAL(LdCmsDbEntitiesContext dbContext) : base(dbContext)
        {
        }

    }
}
