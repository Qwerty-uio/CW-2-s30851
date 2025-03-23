using CW_2_s30851;

ContainerShip containerShip = new ContainerShip(100,100,10000);

Container[] containers = { 
    new LiquidContainer(15,200,400,20,false),
    new GasContainer(15,200,400,20,6),
    new CoolingContainer(15,200,400,20,"Bananas",10)
}; 
containerShip.AddContainer(containers[0]);
containerShip.AddContainer(containers[1]);
containerShip.AddContainer(containers[2]);

containerShip.PrintContainerShip();
Console.WriteLine("==================");
containerShip.RemoveContainer(containers[1]);
containerShip.PrintContainerShip();

Console.WriteLine("==================");
containers[1].PrintInfo();
containers[1].SetEmpty();
containers[1].PrintInfo();
containers[1].FillCargo(10);
containers[1].PrintInfo();
Console.WriteLine("==================");

List<Container> containerList = new List<Container>{new LiquidContainer(35,200,400,40,false),new LiquidContainer(15,200,400,30,true)};

containerShip.AddContainers(containerList);
containerShip.PrintContainerShip();
Console.WriteLine("===================");

containerShip.ReplaceContainer("CON-C-2", containers[1]);
containerShip.PrintContainerShip();
Console.WriteLine("====================");

ContainerShip containerShip2 = new ContainerShip(100,100,10000);
containerShip.MoveContainer(containers[1], containerShip2);
containerShip2.PrintContainerShip();