using OHCE;
using OHCE.Console;

var ohce = new Ohce(SystemLangProxy.SystemLangProxyGetLang(), SystemTimePériodeJournéeAdapter.PériodeActuelle());
Console.WriteLine(ohce.DireBonjour());
Console.WriteLine(ohce.DemanderUnPalindrome());
//On peut toujours faire une boucle si l'utilisateur veut tester plusieurs palindrome, mais dans ce cas là, ce n'est pas nécessaire
Console.WriteLine(ohce.Palindrome(Console.ReadLine() ?? string.Empty));
Console.WriteLine(ohce.DireAurevoir());
