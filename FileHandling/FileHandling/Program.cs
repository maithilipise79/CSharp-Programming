//File Handling in C#

//Using File class to create a file and write some text into it
//File is a static class in the System.IO namespace
//that provides methods for creating,copying, deleting, moving, and opening files,
//and helps in the creation of FileStream objects.



using System;
using System.ComponentModel;
using System.IO;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Text;



//==================================================================================================
//==================================================================================================
//-------------- File---------------



//1)
//File.Create("C:\\2025\\CSharp-Programming\\text.txt").Close();  //create text file at this location
//create file text.txt and close immediately


//-----------------------------------
//2)
//File.WriteAllText()
// If the file already exists, its old content is replaced with the new text.
//If the file doesn’t exist, it is created and the text is written inside.
//-File.WriteAllText() will delete the old content and replace it entirely with the new text you provide.

//File.WriteAllText("C:\\2025\\CSharp-Programming\\text.txt", " Using File class to create a file and write some text into it .File is a static class in the System.IO namespace that provides methods for creating, copying, deleting, moving, and opening files,and helps in the creation of FileStream objects.");




//----------------------------------
//3)
//File.AppendAllText()
//adds new text to the end of an existing file, or creates the file if it doesn’t exist — without deleting the old content.

//File.AppendAllText("C:\\2025\\CSharp-Programming\\text.txt", "\n\n File.WriteAllText() will delete the old content and replace it entirely with the new text you provide.");




//-----------------------------------
//4)
//File.WriteAllLines()
//File.WriteAllLines() in C# is used to write an array or list of strings to a file, with each string written on a new line.
//- It creates or overwrites a file and writes multiple lines of text into it

//File.WriteAllLines("C:\\2025\\CSharp-Programming\\text.txt", new string[] { "Maithili", "Gayatri", "Shivtej","Aryan","Vaishnavi","Sanket","Aniket" });




//-----------------------------------
//5)File.AppendAllLines()
//File.AppendAllLines() in C# is used to add multiple lines of text to the end of a file without removing the existing content.

//File.AppendAllLines("C:\\2025\\CSharp-Programming\\text.txt", new string[] { "Pranav", "Rohit", "Aarav", "Sanavi", "Sanchita" });





//------------------------------------
//6)File.ReadAllText()
//File.ReadAllText() in C# is used to read all the text from a file into a single string
//var data = File.ReadAllText("C:\\2025\\CSharp-Programming\\text.txt"); //string comes
//Console.WriteLine(data);




//-------------------------------------
//7)File.ReadAllBytes() 
//File.ReadAllBytes() in C# is used to read the entire contents of a file as a byte array
//If example.txt contains text "Hello", then data2 will hold the byte values (ASCII/UTF‑8 codes) for each character.

//var data2 = File.ReadAllBytes("C:\\2025\\CSharp-Programming\\text.txt");
//Console.WriteLine(data2);
//foreach (var item in data2)
//{
//    Console.WriteLine(item);
//}





//-------------------------------------
//8)File.ReadAllLines(...)
//File.ReadAllLines(...) → Reads all lines from the file into a string array
//File.ReadAllLines("C:\\2025\\CSharp-Programming\\text.txt").ToList().ForEach(Console.WriteLine);

//File.ReadAllLines(...) → Reads all lines from the file into a string array.
//.ToList() → Converts that array into a list.
//.ForEach(Console.WriteLine) → Prints each line to the console, one by one.





//-------------------------------------
//9)File.Copy("source.txt", "destination.txt");
//File.Copy() in C# is used to copy a file from one location to another
//This will copy the contents of source.txt into a new file called destination.txt

//File.Copy("C:\\2025\\CSharp-Programming\\text.txt", "C:\\2025\\CSharp-Programming\\text1.txt");





//---------------------------------------
//10)File.Move()
//File.Move() in C# is used to move a file from one location to another

//File.Move("C:\\2025\\CSharp-Programming\\text.txt", "C:\\2025\\project\\text2.txt");

//-Copy keeps the original file.
//- Move deletes the original after placing it in the new location.



//----------------------------------------
////11)File.Exists
//bool result=File.Exists("C:\\2025\\project\\text7.txt");
//Console.WriteLine(result);



//----------------------------------------
//12)File.Delete()
//File.Delete("C:\\2025\\project\\text2.txt");



//---------------------------------------
//13)File.Replace(src,dest,backup)
//File.Create("C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt");
//File.Replace("C:\\2025\\CSharp-Programming\\DemoFolder\\demo3.txt", "C:\\2025\\CSharp-Programming\\DemoFolder\\demo2.txt ", "C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt ");



//---------------------------------------
//14) File.GetCreationTime()
//var result = File.GetCreationTime("C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt");
//Console.WriteLine(result);



//--------------------------------------
//15)File.GetLastWriteTime()
//var result=File.GetLastWriteTime("C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt");
//Console.WriteLine(result);


//--------------------------------------
//16) File.GetLastAccessTime()
//var result = File.GetLastAccessTime("C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt");
//Console.WriteLine(result);



//--------------------------------------
//17)File.GetAttributes()



//--------------------------------------
//18)File.SetAttributes();



//-------------------------------------
//19)File.GetCreationTimeUTC
//var result = File.GetCreationTimeUtc("C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt");
//Console.WriteLine(result);



//-------------------------------------
//20)
//var result = File.GetLastWriteTimeUtc("C:\\2025\\CSharp-Programming\\DemoFolder\\demo7.txt");
//Console.WriteLine(result);





//================================================================================================================
//================================================================================================================
//-----------------Directory------------------------


//1)
//Directory.CreateDirectory("C:\\2025\\CSharp-Programming\\DemoFolder");
//Directory.CreateDirectory("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");
//Directory.CreateDirectory("C:\\2025\\CSharp-Programming\\DemoFolder\\Subfolder2");



//2)
//bool ans=Directory.Exists("C:\\2025\\CSharp-Programming\\DemoFolder");
//Console.WriteLine(ans);


//3)
//File.Create("C:\\2025\\CSharp-Programming\\DemoFolder\\demo1.txt");
//File.Create("C:\\2025\\CSharp-Programming\\DemoFolder\\demo2.txt");
//File.Create("C:\\2025\\CSharp-Programming\\DemoFolder\\demo3.txt");


////4)
//Directory.GetFiles("C:\\2025\\CSharp-Programming\\DemoFolder").ToList().ForEach(Console.WriteLine);


//5)
//Directory.GetDirectories("C:\\2025\\CSharp-Programming\\DemoFolder").ToList().ForEach((s) => Console.WriteLine(s));



//6)
//string result=Directory.GetCurrentDirectory();
//Console.WriteLine(result);


//7)
//Directory.GetParent(path) 
//it  is used to get the parent directory of a given path.
//Console.WriteLine(Directory.GetParent("C:\\2025\\CSharp-Programming\\DemoFolder\\Subfolder2"));


//8)
//Directory.SetCurrentDirectory("");
////- It sets the folder your program will treat as the "current directory" for file and folder operations.
//Directory.SetCurrentDirectory("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");
//Console.WriteLine(Directory.GetCurrentDirectory());



//9)
//Directory.Move(source, destination)
//It transfers an entire directory (and its contents) to a new path, removing it from the old location.
//Directory.Move("C:\\2025\\CSharp-Programming\\DemoFolder\\Subfolder2", "C:\\Users\\SHREE\\OneDrive\\Desktop\\tryfolder");



//10)
//Directory.Delete(path, true)
//It removes the specified folder completely, including everything inside it
//Directory.Delete("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");



//11)
//Directory.Delete(path)
//- It removes a folder only if it has no files or subdirectories inside
//- If the directory contains files or subfolders, you’ll get an exception
//Directory.Delete("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");



//12)GetCreationTime(path)
//var result = Directory.GetCreationTimeUtc("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");
//Console.WriteLine(result);



//13
//var result = Directory.GetLastAccessTime("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");
//Console.WriteLine(result);






//=================================================================================================================================================================
//=================================================================================================================================================================
//04/03/2026
//Class-Work



//public class Program
//{
//

//static string CurrentPath = "C:\\Users\\SHREE\\OneDrive\\Desktop";
/*"C:\Users\SHREE\OneDrive\Pictures\image_0.jpg"*/
//private static void Main(string[] args)
//{
//var res = Directory.GetCreationTimeUtc();

//  var res= Directory.GetCurrentDirectory();
//Console.WriteLine(res);

//Directory.CreateDirectory("C:/Test/A/B");



//var res=Directory.GetFiles("C:/MinGW/bin");
//foreach (var dir in res)
//{
//    Console.WriteLine(dir);
//}

//    string imagePath = Path.Combine(CurrentPath, "Image", "Fav");
//    Console.WriteLine(imagePath);
//    if(! Directory.Exists(imagePath))
//    {
//        Directory.CreateDirectory(imagePath);
//    }

//    FileStream ob1 = new FileStream("C:\\Users\\SHREE\\OneDrive\\Pictures\\image_0.jpg",FileMode.Open);

//   var imageName= Path.Combine(imagePath, "flag.jpg");
//    if (!File.Exists(imageName))
//    {
//       FileStream ob= File.Create(imageName);
//        ob1.CopyTo(ob);

//    }


//}

//=========================================================================================================================================
//05/03/2026
//Class-Work


//        FileStream fs = new FileStream("C:/Test/A.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

//        Console.WriteLine(fs.Length);
//        Console.WriteLine(fs.CanRead);
//        Console.WriteLine(fs.CanWrite);


//        StreamWriter sw = new StreamWriter(fs);

//        sw.Write("Raju ");
//        sw.Write(1);
//        sw.Write(false);
//        sw.Flush();



//    }
//    }








//=========================================================================================================================================
//=========================================================================================================================================
//-----------FileInfo and DirectoryInfo--------------
//05/03/2026



//FileInfo and DirectoryInfo Classes in C#
//Both are part of the System.IO namespace and provide object‑oriented ways to work with files and directories.
//Unlike the static File and Directory classes, these are instance classes that let you create objects
//and access properties/methods more flexibly



//FileInfo===========================
//for the FileInfo class need to object for a specific file and then use its properties and
//methods to inspect or manipulate that file

//FileInfo file = new FileInfo("C:\\2025\\CSharp-Programming\\DemoFolder\\demo2.txt");
//if(!file.Exists)
//{
//    file.Create();
//}
//Console.WriteLine(file.FullName);
//Console.WriteLine(file.Name);
//Console.WriteLine(file.Extension);
//Console.WriteLine(file.Length);
//Console.WriteLine(file.CreationTimeUtc);
//Console.WriteLine(file.LastAccessTimeUtc);
//file.CopyTo("c:\\2025\\demofile2.txt", true);
//file.Delete();






//DirectoryInfo======================
//The DirectoryInfo class (in System.IO) provides an object‑oriented way to work with directories (folders).
//Unlike the static Directory class, you create a DirectoryInfo object for a specific folder and
//then use its properties and methods to inspect or manipulate that folder.

//DirectoryInfo directory = new DirectoryInfo("C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1");
//Console.WriteLine(directory.FullName);
//Console.WriteLine(directory.Name);
//Console.WriteLine(directory.CreationTime);
//Console.WriteLine(directory.LastAccessTime);
//Console.WriteLine(directory.LastWriteTime);
//directory.CreateSubdirectory("subfolder4");
//directory.GetFiles().ToList().ForEach(Console.WriteLine);
//directory.GetDirectories().ToList().ForEach(d =>Console.WriteLine(d.Name));




//========================================================================================================================
//========================================================================================================================
//----------------Path------------------


//File/Directory classes →
//actually work with the file system (create, delete, move, copy, list).
//Path class →
//only manipulates path strings. It doesn’t touch the disk, doesn’t check if files exist, and doesn’t create anything
//The Path class (in System.IO) provides static methods for working with file and directory path strings.
//It doesn’t touch the file system directly —
//instead, it helps you manipulate paths (combine, split, extract extensions, etc.).



//string path = "C:\\2025\\CSharp-Programming\\DemoFolder\\SubFolder1";
//string filePath = "C:\\2025\\CSharp-Programming\\DemoFolder\\demo2.txt";
//Console.WriteLine(Path.GetDirectoryName(path));
//Console.WriteLine(Path.GetFileName(filePath));
//Console.WriteLine(Path.GetPathRoot(filePath));
//Console.WriteLine(Path.GetExtension(filePath));
//Console.WriteLine(Path.GetFileNameWithoutExtension(filePath));
//Console.WriteLine(Path.GetTempPath());
//Console.WriteLine(Path.Combine(path, filePath));




//=======================================================================================================================================
//=======================================================================================================================================
//----------------- Stream---------------------

//Stream
//A Stream is an abstract class (System.IO.Stream) that represents a sequence of bytes flowing from a source to a destination.
//It’s abstract → you don’t use Stream directly, but through derived classes like:
//FileStream → for files
//MemoryStream → for memory
//Supports synchronous and asynchronous I/O.

//-Universal interface → same methods(Read, Write, Seek) work for files, memory, or network.
//- Efficient data handling → you don’t need to load the whole file into memory; you can process data piece by piece.
//- Flexibility → works for text, binary data, images, audio, etc.
//- Foundation → higher‑level classes (FileStream, MemoryStream, NetworkStream, StreamReader) are all built on Stream.







//-----------------FileStream---------------------


//Namespace: System.IO
//Inherits from: Stream
//Used for: Low‑level file I / O(reading / writing bytes, controlling file modes and access).

//When creating a FileStream, you specify:
//-File path → "C:\\Demo\\file.txt"
//- FileMode → how to open/create the file
//- FileAccess → read, write, or both
//- FileShare → how other processes can access the file

//When creating a FileStream, you specify:
//-File path → "C:\\Demo\\file.txt"(required)
//- FileMode → how to open/create the file
//- FileAccess → read, write, or both
//- FileShare → how other processes can access the fil



FileStream fs = new FileStream("C:\\2025\\CSharp-Programming\\DemoFolder\\demo11.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
//Console.WriteLine(fs.Name);
//Console.WriteLine(fs.Length);
//Console.WriteLine(fs.Position);
//Console.WriteLine(fs.CanRead);
//Console.WriteLine(fs.CanWrite);
Console.WriteLine(fs.CanSeek);

//byte[] data = Encoding.UTF8.GetBytes("Hello World");
//fs.Write(data);
//fs.ReadByte();

