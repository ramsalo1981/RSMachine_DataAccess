﻿using RSMachine_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSMachine_DataAccess.Repository.IRepository
{
    public interface IInquiryHeaderRepository : IRepository<InquiryHeader>
    {
        void Update(InquiryHeader obj);

    }
}
