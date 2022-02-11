// See https://aka.ms/new-console-template for more information
using POOconcept;

try
{
    Console.WriteLine(new Date(2022, 12, 7));
    Console.WriteLine(new Date(1974, 2, 8));
    Console.WriteLine(new Date(1985, 11, 43));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}
