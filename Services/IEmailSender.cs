using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demoproj_1._1.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
