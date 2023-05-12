using System;

namespace SalesWebMVC.Services.exception
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message): base(message)
        {
        }
    }
}
