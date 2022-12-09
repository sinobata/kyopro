using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            Console.WriteLine("atcoder".Substring(int.Parse(array[0]) - 1,int.Parse(array[1]) - int.Parse(array[0]) + 1));
        }
    }
}

// 文字列の入力
// string s = Console.ReadLine();

// 整数の入力
// long n = long.Parse(Console.ReadLine());

// 文字列配列の入力
// string[] inputStrArray = Console.ReadLine().Split(' ');

// 整数配列の入力
// long[] inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
// int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

//１つの値の出力
//  Console.WriteLine(a);
//  Console.WriteLine(String.Join(' ', array));

// //複数の数字の出力
//  int e = 1;
//  int f = 2;

//  Console.WriteLine("e={0}, f={2}", e, f);

//整数配列で読み込みたいとき
//  int[] c = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//  //stringをintに変える場合
//  string[] input = Console.ReadLine().Split(' ');
//  int d = int.Parse(input[0]);


// 配列を生成する
// var array = new int[] {0, 2, 4, 6};

// [0,1...] の配列を生成する
// var array = Enumerable.Range(0, 5).ToArray(); // {0, 1, 2, 3, 4}

// 初期値が全て同じ配列を生成する
// var array = Enumerable.Repeat(-1, 5).ToArray(); // { -1, -1, -1, -1, -1}

// ソート
// Array.Sort(array);

//2次元配列で読み込みたい場合
//  int[,] X = new int[2, 2];//今回は2x2の行列で考える

//  for (int i = 0; i < 2; i++)
//  {
//    int[] gyou= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//行の読み込み
//    for (int j = 0; j < 2; j++)
//    {
//        X[i, j] = gyou[j];//列への割り当て
//    }
//  }

