using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignMonitor
{
    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException()
        {
        }

        public InvalidTriangleException(string message)
        : base(message)
        {
        }

        public InvalidTriangleException(string message, Exception inner)
        : base(message, inner)
        {
        }
    }
}
