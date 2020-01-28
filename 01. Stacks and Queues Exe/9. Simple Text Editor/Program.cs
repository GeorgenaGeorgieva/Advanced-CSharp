namespace SimpleTextEditor
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    
    class Program
    {
        static void Main(string[] args)
        {   
            Stack<string> versions = new Stack<string>();
            StringBuilder text = new StringBuilder();
            
            int numberOfOperations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] comandsInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                
                string comand = comandsInfo[0];

                switch (comand)
                {
                    case "1":
                        versions.Push(text.ToString());
                        string textToAdd = comandsInfo[1];
                        text.Append(textToAdd);
                        break;
                    case "2":
                        versions.Push(text.ToString());
                        int removeElement = int.Parse(comandsInfo[1]);
                        text.Remove(text.Length - removeElement, removeElement);
                        break;
                    case "3":
                        int index = int.Parse(comandsInfo[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(versions.Pop());
                        break;
                }
            }
        }
    }
}
