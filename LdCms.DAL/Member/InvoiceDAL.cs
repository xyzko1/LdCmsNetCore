﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LdCms.DAL.Member
{
    using EF.DbModels;
    using EF.DbEntitiesContext;
    using IDAL.Member;

    public partial class InvoiceDAL : BaseDAL<Ld_Member_Invoice>, IInvoiceDAL
    {
        public InvoiceDAL(LdCmsDbEntitiesContext dbContext) : base(dbContext)
        {
        }

    }
}
