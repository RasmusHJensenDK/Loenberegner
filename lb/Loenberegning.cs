using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Administration")]

namespace lb
{
    internal class Loenberegning
    {
        private static double bruttoloen { get; set; }
        private static double ambidrag { get; set; }
        private static double bruttoloenminusambidrag { get; set; }
        private static double loenminusfradrag { get; set; }
        private static double skat { get; set; }
        private static double nettoloen { get; set; }
        private static double at { get; set; }
        private static double tl { get; set; }
        private static double fd { get; set; }
        private static double sp { get;set; }
        internal Loenberegning(double antalTimer, double timeLøn, double fradrag, double skatteProcent)
        {
            at = antalTimer;
            tl = timeLøn;
            fd = fradrag;
            sp = skatteProcent;
        }
        internal void BeregnLoen()
        {
            bruttoloen = at * tl;
            ambidrag = 0.08 * bruttoloen;

            bruttoloenminusambidrag = bruttoloen - ambidrag;
            loenminusfradrag = bruttoloenminusambidrag - fd;

            skat = sp * loenminusfradrag / 100;
            nettoloen = bruttoloenminusambidrag - skat;
        }
        internal string TilfoejTimer(double timerTilføjes)
        {
            at = at + timerTilføjes;
            return at.ToString();
        }
        internal double getNettoLoen()
        {
            BeregnLoen();
            return nettoloen;
        }
    }
}
