using ComplexExamples;

var c1 = new Complex(1, 2);
var c2 = new Complex(4, 1);

var sum = c1 + c2; // Сложение комплексных чисел
Console.WriteLine($"Сумма {c1}+{c2}={sum}");
var prod = c1 * c2;// Произведение комплексных чисел
Console.WriteLine($"Произведение ({c1})*({c2})={prod}");

var num = (double)c1;// Явное (explicit) преобразование в вещественное число
Console.WriteLine($"Явное (explicit) преобразование {c1} в вещественное число {num}");

Complex c3 = num;// Неявное (implicit) преобразование в комплексное число
Console.WriteLine($"Неявное (implicit) преобразование {num} в комплексное число {c3}");