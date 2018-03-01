using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Infrastructure
{
    public class DataResult
    {
        public Boolean Success { get; set; }
        public dynamic Data { get; set; }
        public DataResult()
        {
            this.Success = true;
        }
        public void LogError(Exception ex)
        {
            this.Success = false;
            this.Data = ex.Message;
        }
    }
}
