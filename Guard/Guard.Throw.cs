using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guard
{
    public static partial class Guard
    {
        public static void Throw(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Throw<TException>(Action action, string? message = null) where TException : Exception
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                throw (TException)Activator.CreateInstance(typeof(TException), message ?? ex.Message, ex);
            }
        }
    }
}
