using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Helpers.Extensions;

namespace Helpers.Infraestructure
{
    public static class Error
    {
        static Dictionary<int, string> Errors;

        public const int CorrectTransaction = 0;
        public const int EmptyModel = 1;
        public const int InvalidUser = 2;
        public const int RecordNotFound = 3;
        public const int InternalServiceErro = 4;
        public const int UnexpectedError = 5;
        public const int NotAuthorized = 6;

        static Error()
        {
            Errors = new Dictionary<int, string>();
            if (Errors.Count > 0)
                return;

            foreach(var field in typeof(Error).GetFields())
            {
                Errors.Add((int)field.GetValue(null), field.Name.SplitCameCase());
            }
        }

        public static string GetErrorMessage(int error)
        {
            return Errors.SingleOrDefault(i => i.Key == error).Value;
        }
    }
}
