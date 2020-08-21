using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication
{
    public static class SecureStringExtensions
    {
        public static string GetString(SecureString i_SecureString)
        {
            int length = i_SecureString.Length;
            char[] charArray = new char[length];
            IntPtr pointer = IntPtr.Zero;
            string result = null;

            if(i_SecureString == null)
            {
                throw new ArgumentNullException();
            }

            try
            {
                pointer = Marshal.SecureStringToBSTR(i_SecureString);
                Marshal.Copy(pointer, charArray, 0, length);
                result = string.Join(string.Empty, charArray);
            }
            catch(Exception ex)
            {
               throw new ArgumentException();
            }
            finally
            {
                if(pointer != IntPtr.Zero)
                {
                    Marshal.ZeroFreeBSTR(pointer);
                }
            }

            return result;
        }
    }
}
