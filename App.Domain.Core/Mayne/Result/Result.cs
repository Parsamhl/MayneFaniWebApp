using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Mayne.Result
{
    public  class Result
    {
        public  string Message { get; set; }
        public  bool IsSuccess { get; set; }
        //public Result(bool isSuccess, string? message = null)
        //{
        //    IsSuccess = isSuccess;
        //    Message = message;
        //}
    }
}
