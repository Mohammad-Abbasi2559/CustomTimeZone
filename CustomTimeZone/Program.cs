using System;

namespace CustomTimeZone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomTimeZone.TehranTimeZone().ToString() + "   (GMT+03:30) Iran/Tehran Time");
            Console.WriteLine(CustomTimeZone.BaghdadTimeZone().ToString() + "   (GMT+03) Iraq/Baghdad Time");
            Console.WriteLine(CustomTimeZone.BeirutTimeZone().ToString() + "   (GMT+02) Lebanon/Beirut Time");
            Console.WriteLine(CustomTimeZone.BerlinTimeZone().ToString() + "   (GMT+02) Germany/Berlin Time");
            Console.WriteLine(CustomTimeZone.BeijingTimeZone().ToString() + "   (GMT+08) China/Beijigng Time");
            Console.WriteLine(CustomTimeZone.TokyoTimeZone().ToString() + "   (GMT+09) Jpan/Tokyo Time");
            Console.WriteLine(CustomTimeZone.LondonTimeZone().ToString() + "   (GMT+01) United Kingdom/London Time");
            Console.WriteLine(CustomTimeZone.NewYorkTimeZone().ToString() + "   (GMT-05) United State/New York Time");
            Console.ReadKey();
        }
    }
}
