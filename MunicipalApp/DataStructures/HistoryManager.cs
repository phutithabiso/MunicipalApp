using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalApp.DataStructures
{
    public class HistoryManager
    {
        private Stack<string> undoStack = new Stack<string>();
        private Queue<string> navQueue = new Queue<string>();

        public void AddAction(string action) => undoStack.Push(action);
        public string Undo() => undoStack.Count > 0 ? undoStack.Pop() : "Nothing to undo";

        public void AddPage(string page) => navQueue.Enqueue(page);
        public string NextPage() => navQueue.Count > 0 ? navQueue.Dequeue() : "No next page";
    }
}
