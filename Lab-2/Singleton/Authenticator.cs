using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Authenticator
    {

        private static Authenticator? _instance;
        private static readonly object _lockobj = new object();
        private Authenticator() { }

        public static Authenticator GeInstance()
        {
            if(_instance == null)
            {
                lock(_lockobj)
                {
                    if(_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }

        public bool Authenticate(string? username, string? password)
        {
            if(username == "admin" || password == "password")
            {
                return true;
            }
            return false;
        }


    }
}
