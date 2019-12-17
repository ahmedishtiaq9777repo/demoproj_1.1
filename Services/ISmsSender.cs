using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoproj_1._1.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
