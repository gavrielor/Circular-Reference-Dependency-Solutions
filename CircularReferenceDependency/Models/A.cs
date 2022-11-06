using System;

namespace CircularReferenceDependency.Models
{
    public class A : IFriendsCaller
    {
        public void RunWithAction()
        {
            B b = new B();
            b.MakeCoffee(CallFriends);
        }

        public void RunWithInterface()
        {
            B b = new B();
            b.MakeCoffee(this);
        }

        public void CallFriends()
        {
            Console.WriteLine("Calling friends");
        }
    }
}
