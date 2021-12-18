namespace Green
{
    public class Class_Collection
    {

        public static int Int_Input(string str)
        {
            int value = 0;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("{0}", str);
            }
            return value;
        }
        public static float Float_Input(string str)
        {
            float value = 0;
            while (!float.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("{0}", str);
            }
            return value;
        }

        public static double Double_Input(string str)
        {
            double value = 0;
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("{0}", str);
            }
            return value;
        }
    }
}