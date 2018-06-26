using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class BinTree
    {
        public int data;
        public BinTree left,  //адрес левого поддерева 
                       right; //адрес правого поддерева
        public BinTree()
        {
            data = 0;
            left = null;
            right = null;
        }
        public BinTree(int d)
        {
            data = d;
            left = null;
            right = null;
        }
        public override string ToString()
        {
            return data + " ";
        }

        public static int[] FindTree(int[] arr, out int compare, out int forw)
        {
            compare = 0;
            forw = 0;
            BinTree tree = new BinTree(arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                BinTree p = tree;//корень дерева
                BinTree r = null;


                while (p != null)
                {
                    r = p;
                    compare += 2;
                    if (arr[i] < p.data) p = p.left;        //пойти в левое поддерево
                    else p = p.right;                       //пойти в правое поддерево
                }

                compare += 2;
                // если d<r->key, то добавляем его в левое поддерево
                if (arr[i] < r.data) r.left = new BinTree(arr[i]);

                // если d>r->key, то добавляем его в правое поддерево
                else r.right = new BinTree(arr[i]);
            }

            int index = 0;
            ShowTree(tree, ref arr, ref index, ref compare, ref forw);
            return arr;
        }

        public static void ShowTree(BinTree p, ref int[] mas, ref int index, ref int compare, ref int forw)
        {
            if (p != null)
            {
                BinTree.ShowTree(p.left, ref mas, ref index, ref compare, ref forw);//переход к левому поддереву
                forw++;
                mas[index] = p.data;
                index++;
                BinTree.ShowTree(p.right, ref mas, ref index, ref compare, ref forw);//переход к правому поддереву
            }
        }

    }
}
