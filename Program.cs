int[] Klargest = {20, 30, 40, 100, 60, 70, 80, 90, 1};
int K = Klargest.Max();
int N = Klargest.ToList().IndexOf(K);
Console.WriteLine(Klargest[N].ToString());