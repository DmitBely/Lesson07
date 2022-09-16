string path = @"/Документы/обучение/C#/C#/Lections/";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime); // время создани директории
FileInfo[] fi =  di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}