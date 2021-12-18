
await MakeTea();

async Task MakeTea()
{
    await Task.Run(() => {

        Task.Run(() => BoilWater());
        Task.Run(() =>
        {
            GetCup();
            InsertTeabag();
            GetMilk();
        });

    });

    PourBoiledWater();
    StirTeaBag();
    PourMilk();
    FinalStir();
}

async Task BoilWater()
{
    Console.WriteLine("boiling water...");
    Thread.Sleep(20000);
    Console.WriteLine("finished boiling water!!!");
    Console.WriteLine("-----------------------");
}

async Task InsertTeabag()
{
    Console.WriteLine("taking out tea bag box out of cupboard and insert it into cup...");
    Thread.Sleep(5000);
    Console.WriteLine("finished inserting teabag!!!");
    Console.WriteLine("-----------------------");
}

async Task GetCup()
{
    Console.WriteLine("taking out tea cup out of cupboard...");
    Thread.Sleep(2000);
    Console.WriteLine("finished taking out cup!!!");
    Console.WriteLine("-----------------------");
}

async Task GetMilk()
{
    Console.WriteLine("taking out milk out of the fridge...");
    Thread.Sleep(4000);
    Console.WriteLine("finished taking getting milk!!!");
    Console.WriteLine("-----------------------");
}

async Task PourMilk()
{
    Console.WriteLine("pouring milk...");
    Thread.Sleep(3000);
    Console.WriteLine("finished pouring milk!!!");
    Console.WriteLine("-----------------------");
}

async Task PourBoiledWater()
{
    Console.WriteLine("pouring boiling water...");
    Thread.Sleep(3000);
    Console.WriteLine("finished pouring boiling water!!!");
    Console.WriteLine("-----------------------");
}

async Task StirTeaBag()
{
    Console.WriteLine("stirring teabag with boiled water...");
    Thread.Sleep(9000);
    Console.WriteLine("finihsed stirring!!!");
    Console.WriteLine("-----------------------");
}

async Task FinalStir()
{
    Console.WriteLine("stirring milk into tea...");
    Thread.Sleep(2000);
    Console.WriteLine("finished stirring!!!");
    Console.WriteLine("-----------------------");
}


