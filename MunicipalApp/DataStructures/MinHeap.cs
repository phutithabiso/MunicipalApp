using MunicipalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class MinHeap
    {
        private List<ServiceRequest> heap = new List<ServiceRequest>();

        private int Parent(int i) => (i - 1) / 2;
        private int Left(int i) => 2 * i + 1;
        private int Right(int i) => 2 * i + 2;

        public void Insert(ServiceRequest req)
        {
            heap.Add(req);
            int i = heap.Count - 1;

            while (i > 0 && heap[(i - 1) / 2].RequestId > heap[i].RequestId)
            {
                var temp = heap[i];
                heap[i] = heap[(i - 1) / 2];
                heap[(i - 1) / 2] = temp;
                i = (i - 1) / 2;
            }
        }

        public ServiceRequest ExtractMin()
        {
            if (heap.Count == 0) return null;
            var root = heap[0];
            heap[0] = heap[1];
            heap.RemoveAt(heap.Count - 1);
            Heapify(0);
            return root;
        }

        private void Heapify(int i)
        {
            int smallest = i;
            int l = Left(i), r = Right(i);

            if (l < heap.Count && heap[l].RequestId < heap[smallest].RequestId)
                smallest = l;
            if (r < heap.Count && heap[r].RequestId < heap[smallest].RequestId)
                smallest = r;
            if (smallest != i)
            {
                (heap[i], heap[smallest]) = (heap[smallest], heap[i]);
                Heapify(smallest);
            }
        }

        public List<ServiceRequest> GetAll() => heap;
    }
}

