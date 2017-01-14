namespace Before
{
    class Program
    {
        static void Main(string[] args)
        {
            var ali = new Commander
            {
                Tank = new Tank(),
                Plane = new Plane(),
                Type = VehicleType.Tank
            };

            ali.FireToEnemy();
            ali.MoveToSomewhere();

        }
    }
}
