using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Application.Common.Models
{
    public class Result
    {
        public bool Succeeded { get; init; } // Indicates whether the operation succeeded
        public string[] Errors { get; init; } // Contains any error messages if the operation failed


        // Internal constructor to initialize the Result object
        internal Result(bool successed, IEnumerable<string> errors)
        {
            Succeeded = successed;
            Errors = errors.ToArray();
        }


        // Static method to create a successful Result
        public static Result Success()
        {
            return new Result(true, Array.Empty<string>());
        }

        // Static method to create a failed Result with error messages
        public static Result Failure(IEnumerable<string> errors)
        {
           return new Result(false, errors);
        }
    }
}
