using System.IO.Compression;

string folderPath = @"D:\Folder";

string zipFilePath = @"Archive.zip";

ZipFile.CreateFromDirectory(folderPath,zipFilePath);


