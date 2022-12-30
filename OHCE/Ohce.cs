using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string Palindrome(string input)
    {

        var stringBuilder = new StringBuilder();

        var reversed = new string(
            input.Reverse().ToArray()
        );

        

        if (reversed.Equals(input))
            stringBuilder.Append(_langue.BienDit);
        else { stringBuilder.Append(reversed); }
        return stringBuilder.ToString();
    }

    public string DireAurevoir()
    {
        return _langue.AuRevoir;
    }

    public string DireBonjour()
    {
        return _langue.DireBonjour(_périodeJournée);
    }

    public string DemanderUnPalindrome()
    {
        return _langue.DemanderUnPalindrome;

    }
}