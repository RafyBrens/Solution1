using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Infrastructure
{
    public class ServiceResult
    {
        public Boolean Success { get; set; }
        public dynamic ResultObject { get; set; }
        public String ResultTitle { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
    }
}
