using System;

namespace Before
{
    public class Commander
    {
        public Tank Tank { get; set; }
        public Plane Plane { get; set; }
        public VehicleType Type { get; set; }

        public void FireToEnemy()
        {
            switch (Type)
            {
                case VehicleType.Tank:
                    Tank.Fire();
                    break;
                case VehicleType.Plane:
                    Plane.Fire();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void MoveToSomewhere()
        {
            switch (Type)
            {
                case VehicleType.Tank:
                    Tank.Move();
                    break;
                case VehicleType.Plane:
                    Plane.Move();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
