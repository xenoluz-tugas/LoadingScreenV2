Console.WriteLine("Input total steps: ");
int totalSteps = int.Parse(Console.ReadLine());
int step = 1;

while ( step <= totalSteps)
{
    Console.WriteLine($"Loading.. Step {step} of {totalSteps}");

    if (step % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached!");
    }

    step++;
}

Console.WriteLine("Dungeon is ready. Enter now? (Y/n)");