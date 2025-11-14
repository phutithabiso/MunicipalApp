using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class MST
    {
        public int FindMST(int[,] graph)
        {
            int count = graph.GetLength(0);
            int[] key = new int[count];
            bool[] mstSet = new bool[count];

            for (int i = 0; i < count; i++)
                key[i] = int.MaxValue;

            key[0] = 0;
            int mstWeight = 0;

            for (int i = 0; i < count - 1; i++)
            {
                int min = int.MaxValue;
                int u = -1;

                for (int v = 0; v < count; v++)
                    if (!mstSet[v] && key[v] < min)
                    {
                        min = key[v];
                        u = v;
                    }

                mstSet[u] = true;
                mstWeight += min;

                for (int v = 0; v < count; v++)
                    if (graph[u, v] != 0 && !mstSet[v] && graph[u, v] < key[v])
                        key[v] = graph[u, v];
            }

            return mstWeight;
        }
    }
}