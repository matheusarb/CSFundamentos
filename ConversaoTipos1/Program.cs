//Console.WriteLine("Conversão Tipos de Dados1 \n- - - - -");

////a ideia é que é possível fazer a conversão ÍMPLICITA de tipo quando é do tipo menor (int) aos maiores
////o caminho inverso só é possível através da CONVERSÃO EXPLÍCITA (exemplo abaixo)
//double val = 100.32;
//int val2 = (int)val;
//int val3 = Convert.ToInt32(val);
//Console.WriteLine(val2);
//Console.WriteLine(val3);
//Console.WriteLine("-------");

//int n1 = 10;
//int n2 = 4;
//float result = ((float) n1 / n2);
//Console.WriteLine(result);

//Console.WriteLine("");

Console.WriteLine("Conversão para STRINGS \n - - - - -");
int s = 28;
//Convert.ToString(s);
var x = Convert.ToString(s);
//Console.WriteLine(Convert.ToString(s));
Convert.ToString(s);

Console.WriteLine(x.GetType());
//tipo continua vindo como int??