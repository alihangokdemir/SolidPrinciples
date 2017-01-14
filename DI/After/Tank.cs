using System;

namespace After
{
    /// <summary>
    /// Concrete Class
    /// </summary>
    public class Tank : IVehicle
    {
        public void Fire()
        {
            Console.WriteLine("Fired from the Tank");
        }

        public void Move()
        {
            Console.WriteLine("Moved from the Tank");
        }
    }
}
