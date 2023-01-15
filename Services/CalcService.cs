using static CosinusApp.Messages.Message.CalcMessage;

namespace CosinusApp.Services
{
    public class CalcService
    {
        public CalcOutput CosineTheorem(CalcInput input)
        {
            
            double a = input.a;
            double b = input.b;
            double C = input.angleC;
            double c = Math.Sqrt(a*a + b*b - 2*a*b*Math.Cos(C));
            return new CalcOutput(c);

        }
    }
}
