Console.WriteLine("Trabalhando com o tipo DateTime");

DateTime dataAtual = DateTime.Now;
//dataAtual.AddDays(30);

//Console.WriteLine(dataAtual.DayOfWeek);
//Console.WriteLine(dataAtual.DayOfYear);
//Console.WriteLine(dataAtual.TimeOfDay);

//Console.WriteLine(dataAtual.AddDays(30));
//Console.WriteLine(dataAtual);

//DateTime dataCriada = new DateTime(2002, 08, 21, 23, 08, 57);
//Console.WriteLine(dataCriada);
//Console.WriteLine(dataCriada.Year);
//Console.WriteLine(dataCriada.Month);
//Console.WriteLine(dataCriada.Day);
//Console.WriteLine(dataCriada.Hour);
//Console.WriteLine(dataCriada.Minute);
//Console.WriteLine(dataCriada.Second);

//data no formato longo e curto
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToLongDateString());

Console.WriteLine(dataAtual.ToShortTimeString());
Console.WriteLine(dataAtual.ToShortDateString());

Console.ReadKey();