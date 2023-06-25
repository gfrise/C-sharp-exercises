using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    public class Class
    {
            public int publicField;

            private int privateField;

        protected int protectedField;

            internal int internalField;

        public Class()
        {
            publicField = 1;
            privateField = 2;
            protectedField = 3; 
            internalField = 4;
        }

        public void PublicMethod()
            {
                Console.WriteLine("public method.");

            }

            internal void InternalMethod()
            {
                Console.WriteLine("internal method.");

            }

        public void AccessPrivate()
        {
            Console.WriteLine($"This is the only way to access private fields, which btw in this case is equale to{privateField}");
            PrivateMethod();
        }
            protected void ProtectedMethod()
            {
                Console.WriteLine("protected method.");

            }

            private void PrivateMethod()
            {
                Console.WriteLine("private method.");

            }
        
    }
}
