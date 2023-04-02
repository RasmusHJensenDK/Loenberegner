using lb;

Console.WriteLine("Tilføjer 100 timer, 135 i timeløn, 5000 i fradrag, 40% træk");

Loenberegning loen = new Loenberegning(100, 135, 5000, 40);

Console.WriteLine("Løn beregning for denne måned :" + loen.getNettoLoen());

Console.WriteLine("Tilføjer 100 timer, ny antal timer for denne måned : " + loen.TilfoejTimer(100));

Console.WriteLine("Løn beregning for denne måned :" + loen.getNettoLoen());


Console.ReadKey();