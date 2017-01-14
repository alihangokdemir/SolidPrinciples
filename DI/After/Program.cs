namespace After
{
    class Program
    {
        static void Main(string[] args)
        {
            // At this point I recommend you to look at the IoC Containers.

            IVehicle tank = new Tank(); // Polymorphism 
            Commander commander = new Commander(tank);
            commander.Move();
            commander.Fire();

            // I've used Autofac IoC Container 

            //var builder = new ContainerBuilder();
            //builder.RegisterType<Tank>().As<IVehicle>();

            //var container = builder.Build();

            //using (var scope = container.BeginLifetimeScope())
            //{
            //    var tank = scope.Resolve<IVehicle>();
            //    tank.Move();
            //    tank.Fire();
            //}
        }
    }
}
