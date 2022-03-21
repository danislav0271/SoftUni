using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();
            
            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] cmdArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs[0] == "Add")
                {
                    if (!lessons.Contains(cmdArgs[1]))
                    {
                        lessons.Add(cmdArgs[1]);
                    }
                }
                else if (cmdArgs[0] == "Insert")
                {
                    if (!lessons.Contains(cmdArgs[1]))
                    {
                        lessons.Insert(int.Parse(cmdArgs[2]), cmdArgs[1]);
                    }
                }
                else if (cmdArgs[0] == "Remove")
                {
                    string lesson = cmdArgs[1];
                    if (lessons.Contains(lesson))
                    {
                        int index = lessons.IndexOf(lesson);
                        if (isThereExercise(lessons, lesson))
                        {
                            lessons.RemoveAt(index + 1);
                            lessons.Remove(lesson);
                        }
                        else
                        {
                            lessons.Remove(lesson);
                        }
                    }
                }
                else if (cmdArgs[0] == "Swap")
                {
                    string firstLesson = cmdArgs[1];
                    string secondLesson = cmdArgs[2];

                    Swap(lessons, firstLesson, secondLesson);
                }
                else if (cmdArgs[0] == "Exercise")
                {
                    if (!lessons.Contains(cmdArgs[1] + "-Exercise"))
                    {
                        string lesson = cmdArgs[1];
                        Exercise(lessons, lesson);
                    }
                }
            }

            PrintList(lessons);
        }

        static bool isThereExercise(List<string> lessons, string lesson)
        {
            int index = lessons.IndexOf(lesson);
            if (index + 1 < lessons.Count)
            {
                if (lessons[index + 1] == lesson + "-Exercise")
                {
                    return true;
                }
            }
            return false;
        }

        static void Exercise(List<string> lessons, string lesson)
        {
            if (lessons.Contains(lesson))
            {
                int index = lessons.IndexOf(lesson);
                lessons.Insert(index + 1, lesson + "-Exercise");
            }
            else
            {
                lessons.Add(lesson);
                lessons.Add(lesson + "-Exercise");
            }
        }

        static void Swap(List<string> lessons, string firstLesson, string secondLesson)
        {
            if (!lessons.Contains(firstLesson) || !lessons.Contains(secondLesson))
            {
                return;
            }

            int firstIndex = lessons.IndexOf(firstLesson);
            int secondIndex = lessons.IndexOf(secondLesson);

            if (isThereExercise(lessons, firstLesson) && isThereExercise(lessons, secondLesson))
            {
                string firstExLesson = lessons[firstIndex + 1];
                string secondExLesson = lessons[secondIndex + 1];

                lessons.Insert(firstIndex, secondLesson);
                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex, firstLesson);
                lessons.RemoveAt(secondIndex + 1);

                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex + 1, firstExLesson);
                lessons.RemoveAt(secondIndex + 1);
                lessons.Insert(firstIndex + 1, secondExLesson);
            }
            else if (isThereExercise(lessons, firstLesson))
            {
                string firstExLesson = lessons[firstIndex + 1];

                lessons.Insert(firstIndex, secondLesson);
                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex, firstLesson);
                lessons.RemoveAt(secondIndex + 1);

                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex + 1, firstExLesson);
            }
            else if (isThereExercise(lessons, secondLesson))
            {
                string secondExLesson = lessons[secondIndex + 1];

                lessons.Insert(firstIndex, secondLesson);
                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex, firstLesson);
                lessons.RemoveAt(secondIndex + 1);

                lessons.RemoveAt(secondIndex + 1);
                lessons.Insert(firstIndex + 1, secondExLesson);
            }
            else
            {
                lessons.Insert(firstIndex, secondLesson);
                lessons.RemoveAt(firstIndex + 1);
                lessons.Insert(secondIndex, firstLesson);
                lessons.RemoveAt(secondIndex + 1);
            }
        }

        static void PrintList(List<string> lessons)
        {
            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
