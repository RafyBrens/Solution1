using System;
using System.Collections.Generic;
using System.Text;
using Models.Infrastructure;

namespace Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static ServiceResult LogError(this ServiceResult sr, Exception ex)
        {
            sr.Success = true;
            sr.ResultObject = "";
            sr.Messages.Add(ex.Message);

            return sr;
        }
    }

}
