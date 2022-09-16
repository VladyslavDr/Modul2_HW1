using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Result
    {
        public Result()
        {
        }

        public bool Status { get; set; }
        public string TextError => "Something went wrong!";
    }
}
