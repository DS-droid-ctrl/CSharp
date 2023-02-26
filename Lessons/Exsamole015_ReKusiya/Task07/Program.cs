// РАБОТА С ДЕРИКТОРИЯМИ

string path = "/Users/mdr20/Desktop/CSharp/CSharp/Lessons/Exsamole011_IntroArray";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);

// Просмотр папок в директории
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}