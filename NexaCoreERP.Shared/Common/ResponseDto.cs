using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexaCoreERP.Shared.Common
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public string Errors { get; set; }
    }
}
