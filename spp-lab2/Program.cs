using System;

namespace spp_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input source path");
            string sourcePath = Console.ReadLine();
            Console.WriteLine("Input destination path");
            string destPath = Console.ReadLine();

            CopyFiles copier = new CopyFiles();

            Console.WriteLine("Copied files " + copier.Copy(sourcePath, destPath));

        }
    }
}