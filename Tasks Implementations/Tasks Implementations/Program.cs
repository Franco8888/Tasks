
await MakeTea();

async Task MakeTea()
{
    var boilTask = Task.Run(async () => await BoilWater());
    var otherTasks = Task.Run(async () =>
    {
        await GetCup();
        await InsertTeabag();
        await GetMilk();
    });

    await Task.WhenAll(new[] { boilTask, otherTasks });

    await PourBoiledWater();
    await StirTeaBag();
    await PourMilk();
    await FinalStir();
}

async Task BoilWater()
{
    Console.WriteLine("boiling water...");
    await Task.Delay(23000);
    Console.WriteLine("finished boiling water!!!");
    Console.WriteLine("-----------------------");
}

async Task InsertTeabag()
{
    Console.WriteLine("taking out tea bag box out of cupboard and insert it into cup...");
    await Task.Delay(5000);
    Console.WriteLine("finished inserting teabag!!!");
    Console.WriteLine("-----------------------");
}

async Task GetCup()
{
    Console.WriteLine("taking out tea cup out of cupboard...");
    await Task.Delay(2000);
    Console.WriteLine("finished taking out cup!!!");
    Console.WriteLine("-----------------------");
}

async Task GetMilk()
{
    Console.WriteLine("taking out milk out of the fridge...");
    await Task.Delay(4000);
    Console.WriteLine("finished taking getting milk!!!");
    Console.WriteLine("-----------------------");
}

async Task PourMilk()
{
    Console.WriteLine("pouring milk...");
    await Task.Delay(3000);
    Console.WriteLine("finished pouring milk!!!");
    Console.WriteLine("-----------------------");
}

async Task PourBoiledWater()
{
    Console.WriteLine("pouring boiling water...");
    await Task.Delay(3000);
    Console.WriteLine("finished pouring boiling water!!!");
    Console.WriteLine("-----------------------");
}

async Task StirTeaBag()
{
    Console.WriteLine("stirring teabag with boiled water...");
    await Task.Delay(9000);
    Console.WriteLine("finihsed stirring!!!");
    Console.WriteLine("-----------------------");
}

async Task FinalStir()
{
    Console.WriteLine("stirring milk into tea...");
    await Task.Delay(2000);
    Console.WriteLine("finished stirring!!!");
    Console.WriteLine("-----------------------");
}


