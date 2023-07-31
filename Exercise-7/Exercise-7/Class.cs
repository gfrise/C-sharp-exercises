using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class Class
    {
        public string publicField = "public field";
        private string privateField = "private field";
        protected string protectedField = "protected field";
        internal string internalField = "internal field";

        public string GetPrivate() { return privateField; }
        public string GetProtected() { return protectedField;}
        public string GetInternal() { return internalField;}
        public string GetPublic() { return publicField;}
        
    }
}
