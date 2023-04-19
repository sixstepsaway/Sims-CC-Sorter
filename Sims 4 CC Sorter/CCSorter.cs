using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using s4pi.Interfaces;
using s4pi.Package;


namespace FindPackages.PackageDiscovery {
    class ParsePackageFolder {
        string packageExtension = "package";
        public List<FileInfo> allPackages = new List<FileInfo>();
        public List<FileInfo> notPackages = new List<FileInfo>();
        public string[] packageContents;


        public void IdentifyPackages(string ModFolder){
            Console.WriteLine("Looking for packages inside: " + ModFolder);
            string[] files = Directory.GetFiles(ModFolder, "*." + packageExtension, SearchOption.AllDirectories);
            foreach (string file in files) {
                FileInfo packageFile = new FileInfo(file);
                if (packageExtension.Any(packageFile.Extension.Contains)) {
                    allPackages.Add(packageFile);
                } else {
                    notPackages.Add(packageFile);
                }
            }
        }

        void LineType<T>(T LineType) {
            Console.WriteLine(typeof(T));
        }
        public void GetPackageInfo(FileInfo packageFile){
            //FileStream getInfo = new FileStream(packageFile.FullName, FileMode.OpenOrCreate);
            Console.WriteLine("Opened " + packageFile.Name);
            dynamic packageCont = File.ReadAllLines(packageFile.FullName);
            foreach (dynamic item in packageCont) {
                LineType(item);
                //Console.Write(item);
            }
        }
    }
}