

using System;
using System.Collections.Generic;
using System.Text;

namespace x
{
    class Program
    {
        public static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            HashSet<int> array = new HashSet<int>();
            array.Add(s);
            int n =s;

            for(int i = 2; true;i++) {
                int next;
                if(n % 2 == 0) {
                    next = n / 2;
                } else {
                    next = n * 3 + 1;
                }
                if(array.Contains(next)) {
                    Console.WriteLine(i);
                    return;
                } else {
                    array.Add(next);
                }
                n = next;
            }
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


// 100 → 200へ配列のサイズを変更
// int[] array = new int[100];
// Array.Resize(ref array, 200/*新しいサイズ*/);

// // 201件目に要素を追加
// Array.Resize(ref array, array.Length + 1);
// array[Length -1] = 999;