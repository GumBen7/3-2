namespace ThreeTwo {
    class Program {
        static void Main(string[] args) {
            int numSys = System.Int32.Parse(System.Console.ReadLine());
            string number = System.Console.ReadLine();
            int Decimal = 0;
            int k = number.Length - 1;
            foreach(char c in number) {
                if (c >= 'a') {
                    Decimal += (int)System.Math.Pow(numSys, k) * (c - 'a' + 10);
                }
                else {
                    Decimal += (int)System.Math.Pow(numSys, k) * (c - '0');
                }
                --k;
            }
            System.Console.WriteLine(Decimal);
        }
    }
}