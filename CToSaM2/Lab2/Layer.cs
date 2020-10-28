namespace CToSaM2
{
    public class Layer
    {
        public double Width { get; }
        public double ParamA { get; }
        public double ParamB { get; }
        public double ParamC { get; }
        public double ParamTE { get; }
        public double ParamP { get; }
        public double Lambda { get; set; }
        public double Temp { get; set; }

        public Layer(double w, double pA, double pB, double pC, double pTE, double pP)
        {
            Width = w;
            ParamA = pA;
            ParamB = pB;
            ParamC = pC;
            ParamTE = pTE;
            ParamP = pP;
        }
    }
}