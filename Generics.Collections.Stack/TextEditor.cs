using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections.Stack
{
    public class TextEditor
    {
        private Stack<char> UndoStack = new Stack<char>();
        private string text = "";

        public void Write(char c)
        {
            text += c;
            UndoStack.Push(c);
            Console.WriteLine($"Texto: {text}");
        }

        public void Undo()
        {
            if (UndoStack.Count > 0)
            {
                var lastChar = UndoStack.Pop();
                text = text.Substring(0, text.Length - 1);
                Console.WriteLine($"Texto: {text}");
            }
        }
    }
}
