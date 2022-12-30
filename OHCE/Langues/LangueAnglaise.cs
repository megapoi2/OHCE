namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;
        public string DemanderUnPalindrome => Expressions.English.DemanderUnPalindrome;
        /// <inheritdoc />
        public string DireBonjour(PériodeJournée période) => Expressions.English.Bonjour;

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.AuRevoir;
    }
}
