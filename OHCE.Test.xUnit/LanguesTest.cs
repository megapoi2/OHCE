using OHCE.Langues;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory]
        [InlineData(PériodeJournée.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PériodeJournée.Matin, Expressions.Français.Bonjour)]
        public void DireBonjourTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueFrançaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }
        [Theory]
        [InlineData(Expressions.Français.AuRevoir)]
        public void DireAuRevoirTest(string aurevoirAttendue)
        {
            
            var ohce = new Ohce(new Langues.LangueFrançaise(), PériodeJournée.Matin);
            Console.WriteLine(ohce.DireBonjour());
            Console.WriteLine(ohce.DemanderUnPalindrome());

            var aurevoir = ohce.DireAurevoir();

            Assert.Equal(aurevoirAttendue, aurevoir);
        }
        [Theory]
        [InlineData(Expressions.English.AuRevoir)]
        public void DireAuRevoirTestEN(string aurevoirAttendue)
        {

            var ohce = new Ohce(new Langues.LangueAnglaise(), PériodeJournée.Matin);
            Console.WriteLine(ohce.DireBonjour());
            Console.WriteLine(ohce.DemanderUnPalindrome());

            var aurevoir = ohce.DireAurevoir();

            Assert.Equal(aurevoirAttendue, aurevoir);
        }

    }
}

