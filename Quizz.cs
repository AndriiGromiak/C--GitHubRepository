using System;
namespace TriangleItMax
{
	
	class MainClass
	{
		
		static int[] Sort(int[] mas)
		{

			int temp;
			for (int i = 0; i < mas.Length - 1; i++)
			{
				for (int j = i + 1; j < mas.Length; j++)
				{
					if (mas[j] > mas[i])
					{
						temp = mas[j];
						mas[j] = mas[i];
						mas[i] = temp;
					}
				
				}

			}
			return mas;
		}

		public static void Main(string[] args)
		{

			int mas0 = 75;
			int[] mas1= new int[2] { 64, 95 };
			int[] mas2 = new int[3] { 17,47,82 };
			int[] mas3 = new int[4] { 18,35,87,10 };
			int[] mas4 = new int[5] { 20,4,82,47,65 };
			int[] mas5 = new int[6] { 19,1,23,75,3,34 };
			int[] mas6 = new int[7] { 88,2,77,73,7,63,67 };
			int[] mas7 = new int[8] { 99,65,04,28,6,16,70,92 };
			int[] mas8 = new int[9] { 41,41,26,56,83,40,80,70,33 };
			int[] mas9 = new int[10] { 41,48,72,33,47,32,37,16,94,29};
			int[] mas10 = new int[11] { 53,71,44,65,25,43,91,52,97,51,14 };
			int[] mas11 = new int[12] { 70,11,33,28,77,73,17,78,39,68,17,57 };
			int[] mas12 = new int[13] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
			int[] mas13 = new int[14] { 63, 66, 4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
			int[] mas14 = new int[15] { 4, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 4, 23 };

			Sort(mas1);
			Sort(mas2);
			Sort(mas3);
			Sort(mas4);
			Sort(mas5);
			Sort(mas6);
			Sort(mas7);
			Sort(mas8);
			Sort(mas9);
			Sort(mas10);
			Sort(mas11);
			Sort(mas12);
			Sort(mas13);
			Sort(mas14);
			Console.WriteLine(mas0);
			Console.WriteLine("\n" + mas1[0]);
			Console.WriteLine("\n" + mas2[0]);
			Console.WriteLine("\n" + mas3[0]);
			Console.WriteLine("\n" + mas4[0]);
			Console.WriteLine("\n" + mas5[0]);
			Console.WriteLine("\n" + mas6[0]);
			Console.WriteLine("\n" + mas7[0]);
			Console.WriteLine("\n" + mas8[0]);
			Console.WriteLine("\n" + mas9[0]);
			Console.WriteLine("\n" + mas10[0]);
			Console.WriteLine("\n" + mas11[0]);
			Console.WriteLine("\n" + mas12[0]);
			Console.WriteLine("\n" + mas13[0]);
			Console.WriteLine("\n" + mas14[0]);
			Console.WriteLine("\nThe max. path sum is: " + (mas0 + mas1[0] + mas2[0] + mas3[0] + mas4[0] + mas5[0] + mas6[0] + mas7[0] + mas8[0] + mas9[0] + mas10[0] + mas11[0] + mas12[0] + mas13[0]+ mas14[0]));
			Console.ReadKey();
}
	}
}
