using System;

namespace CircularReferenceDependency.Models
{
    internal class B
    {
        internal void MakeCoffee(Action callFriends)
        {
            Start();
            callFriends();
            Finish();
        }

        internal void MakeCoffee(IFriendsCaller caller)
        {
            Start();
            caller.CallFriends();
            Finish();
        }

        private void Start() => Console.WriteLine("Start Making coffee");

        private void Finish() => Console.WriteLine("Finish Making coffee");
    }
}
