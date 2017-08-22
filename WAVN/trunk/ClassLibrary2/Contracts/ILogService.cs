using System;
using System.Collections.Generic;
using WAVN.Services.Models;

namespace WAVN.Services
{
    public interface ILogService
    {
        LogModel Get(Guid id);
        List<LogModel> GetAll(int skip, int take);

        void Put(LogModel log);

        void Delete (Guid id);
    }
}
