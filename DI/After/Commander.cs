namespace After
{
    public class Commander
    {
        private readonly IVehicle _vehicle;
        
        /// <summary>
        /// Constructor injection , It's the way of dependency injection.
        /// We could have used method or property injection too.
        /// </summary>
        /// <param name="vehicle"></param>
        public Commander(IVehicle vehicle)
        {
            this._vehicle = vehicle;
        }

        public void Move()
        {
            _vehicle.Move();
        }

        public void Fire()
        {
            _vehicle.Fire();
        }
    }
}
