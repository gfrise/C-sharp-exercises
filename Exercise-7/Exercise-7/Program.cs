using Exercise_7;
using System;

public class Program
{
    static void Main()
    {
        Class myclass = new Class();

        //These can be accessed directly

        Console.WriteLine(myclass.publicField);
        Console.WriteLine(myclass.internalField);

        myclass.PublicMethod();
        myclass.InternalMethod();

    //  These cause an error

     //   myclass.ProtectedMethod();
     //   myclass.PrivateMethod();
     //  Console.WriteLine(myclass.privateField);
     // Console.WriteLine(myclass.protectedField);

    //  the protected field and method are available like this
        ClassInheriting otherclass = new ClassInheriting();
        otherclass.Access();

        // This makes private fields and methods available
        myclass.AccessPrivate();
    }
}

public class ClassInheriting :  Class
{
    public void Access()
    {
        protectedField = 3;
        ProtectedMethod();
        Console.WriteLine($"Accessed protected field through child class: {protectedField}");
    }

}