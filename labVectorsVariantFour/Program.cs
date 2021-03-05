using System;
using System.IO;

namespace labVectorsVariantFour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"D:\Inlet.in.txt"); 

            string [] inputData =  streamReader.ReadLine().Trim().Split(' '); 

            streamReader.Close();

            int [] A = new int[inputData.Length];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(inputData[i]);
            }

            Array.Sort(A);

            int[] B;

            if (A.Length == 2 || A.Length == 1)
            {
                B = new int[1];
                B[0] = -1;
            }
            else
            {
                B = new int[A.Length - 2]; 
                    
                for (int i = 0; i < B.Length; i++)
                {
                    B[i] = A[i+1];
                }
            }

            File.Create(@"D:\Outlet.out.txt").Close();

            StreamWriter streamWriter = new StreamWriter(@"D:\Outlet.out.txt");

            for (int i = 0; i < B.Length; i++)
            {
                streamWriter.WriteLine(B[i]);
            }

            streamWriter.Close();
        }
    }
}
