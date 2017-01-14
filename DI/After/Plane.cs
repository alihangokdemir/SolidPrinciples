using System;

namespace After
{
    public class Plane : IVehicle
    {
        /// <summary>
        /// Concrete Class
        /// </summary>
        public void Fire()
        {
            Console.WriteLine("Fired from the Plane");
        }

        public void Move()
        {
            Console.WriteLine("Moved from the Plane");
        }
    }
}
