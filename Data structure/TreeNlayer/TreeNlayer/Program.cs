using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TreeNlayer
{
    //internal class Tree
    //{
    //    internal class TreeNode
    //    {
    //        public int Value;
    //        public List<TreeNode> Childs;
    //    }
    //    public TreeNode Node;
    //}

    internal class Folder
    {
        public List<Folder> Folders;
        
        public List<File> Files;
        
        public string Name;

        public Folder(string name)
        {
            Name = name;
            Folders = new List<Folder>();
            Files = new List<File>();
        }

        public void SetFile(List<File> files)
        {
            Files = files;
        }

        public void SetFolder(List<Folder> folders)
        {
            Folders = folders;
        }
    }

    internal class File
    {
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Folder rootFolder = new Folder("RootFolder");
            List<Folder> folders = new List<Folder>();
            folders.Add(new Folder("1_1"));
            folders.Add(new Folder("1_2"));
            folders.Add(new Folder("1_3"));

            Console.WriteLine(folders[0].Folders.Count);

            folders[0].Folders.Add(new Folder("2_1"));
            folders[0].Folders.Add(new Folder("2_2"));
            folders[0].Folders.Add(new Folder("2_3"));

            folders[1].Folders.Add(new Folder("2_4"));
            folders[1].Folders.Add(new Folder("2_5"));
            folders[1].Folders.Add(new Folder("2_6"));

            folders[2].Folders.Add(new Folder("2_7"));
            folders[2].Folders.Add(new Folder("2_8"));
            folders[2].Folders.Add(new Folder("2_9"));

            folders[0].Folders[0].Folders.Add(new Folder("3_1"));
            folders[0].Folders[0].Folders.Add(new Folder("3_2"));
            folders[0].Folders[0].Folders.Add(new Folder("3_3"));

            folders[1].Folders[0].Folders.Add(new Folder("3_1"));
            folders[1].Folders[0].Folders.Add(new Folder("3_2"));
            folders[1].Folders[0].Folders.Add(new Folder("3_3"));

            folders[2].Folders[0].Folders.Add(new Folder("3_1"));
            folders[2].Folders[0].Folders.Add(new Folder("3_2"));
            folders[2].Folders[0].Folders.Add(new Folder("3_3"));



            rootFolder.SetFolder(folders);
            //Across(rootFolder, true);
            Console.WriteLine(Across(rootFolder));
        }
        public static bool Across(Folder RootFolder)
        {
            if (RootFolder.Files.Count > 0) return true;
            //var queue = new Queue<List<Folder>>();
            //queue.Enqueue(RootFolder.Folders);
            //var SearchFoldersLine = RootFolder.Folders;

            Queue<Folder> queue = new Queue<Folder>();
            queue.Enqueue(RootFolder);

            while (queue.Count > 0)
            {
                Folder folder = queue.Dequeue();
                Console.WriteLine(folder.Name);

                foreach (Folder child in folder.Folders)
                {
                    if (child.Files.Count > 0) return true;
                    queue.Enqueue(child);
                }
                //SearchFoldersLine = SearchFoldersLine[0].Folders;
            }
            return false;
        }
        //public static bool Across(Folder RootFolder, bool detailed)
        //{
        //    string s = "";
        //    var queue = new Queue<List<Folder>>();
        //    if (detailed) s += " заносим в очередь значение " + RootFolder.Name + Environment.NewLine;
        //    List<Folder> tmp = new List<Folder>();
        //    tmp.Add(RootFolder);
        //    queue.Enqueue(tmp);
        //    while (queue.Count != 0)
        //    {
        //        foreach (var elem in RootFolder.Folders)
        //        {
        //            if (queue.Peek().Count != 0)
        //            {
        //                if (detailed) s += "    заносим в очередь значение " + elem.Name + Environment.NewLine;
        //                queue.Enqueue(elem.Folders);
        //            }
        //        }
        //        if (detailed) s += "    извлекаем значение из очереди: " + queue.Peek()[0].Name + Environment.NewLine;
        //        else s += queue.Peek()[0].Name + " ";
        //        queue.Dequeue();
        //        Console.WriteLine(s);
        //    }
        //    return false;
        //}
    }
}
