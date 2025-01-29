using System;

namespace AccessModifiers
{
    public class BaseClass
    {
        private string PrivateProperty => "Private - Only accessible within BaseClass";
        protected string ProtectedProperty => "Protected - Accessible in BaseClass and DerivedClass";
        internal string InternalProperty => "Internal - Accessible within the same assembly";
        protected internal string ProtectedInternalProperty => "Protected Internal - Accessible within assembly or derived classes";
        public string PublicProperty => "Public - Accessible everywhere";

        public void ShowProperties()
        {
            Console.WriteLine(PrivateProperty);
            Console.WriteLine(ProtectedProperty);
            Console.WriteLine(InternalProperty);
            Console.WriteLine(ProtectedInternalProperty);
            Console.WriteLine(PublicProperty);
        }
    }

    public class DerivedClass : BaseClass
    {
        public void ShowInheritedProperties()
        {
            // Console.WriteLine(PrivateProperty); // Not accessible
            Console.WriteLine(ProtectedProperty); // Accessible
            Console.WriteLine(InternalProperty); // Accessible (same assembly)
            Console.WriteLine(ProtectedInternalProperty); // Accessible
            Console.WriteLine(PublicProperty); // Accessible
        }
    }

    internal class Program
    {
        private static void Main()
        {
            BaseClass baseClass = new BaseClass();
            baseClass.ShowProperties();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.ShowInheritedProperties();

            // Accessing properties from outside
            Console.WriteLine(baseClass.PublicProperty);
            // Console.WriteLine(baseClass.PrivateProperty); // Error
            // Console.WriteLine(baseClass.ProtectedProperty); // Error
            Console.WriteLine(baseClass.InternalProperty); // Accessible within the same assembly
            Console.WriteLine(baseClass.ProtectedInternalProperty); // Accessible
        }
    }
}