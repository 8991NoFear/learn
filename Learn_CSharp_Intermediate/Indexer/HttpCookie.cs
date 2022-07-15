using System;
using System.Collections.Generic;

namespace Indexer
{
    class HttpCookie
    {
        private Dictionary<string, string> _cookie;
        private DateTime _expiry;

        public HttpCookie(DateTime expiry)
        {
            _cookie = new Dictionary<string, string>();
            _expiry = expiry;
        }

        public string this[string key]
        {
            get { return _cookie[key]; }
            set { _cookie[key] = value; }
        }
    }
}
