# File Finder
A tool to help developers make their development fast on larger scale projects

### Note:
Currently Unable to search pdf files.Its code is different.Will implement when i will find time.Rest file formats are searchable.Like most code files of different languages.Except pdf its working what i have tested for now.For now when the same text is present in dozens of files,it starts to be unresposiveness may be because of large loop or load or lot of memory consumption.Will check that later.

Also if you will enter a path then the folders,subfolders and files in that folders will be searched but the root path files will not be searched.So the files you want to search you have to be one step behind in path and then the text will be searched in all the files.Also if the path is generic like you start from a path which contains so many sub paths and folders and sub folders it will start hanging because of dozens of loops execution.So it will respond but will take time as it had to do a lot of work behind the scene.So start from path that you assume is near to text.Like the project repo src folder and its further sub folder where you can assume the text you are searching its file is present.

## About File Finder
A c# tool that will increase the development speed.The tool is useful for developers.What it will do is it will search the entered string starting from the path you will give. It will loop through all the available directories,paths and will give you the file path and name where the string is present. As in larger softwares there are hundreds of files and thousands of lines of code so its much harder to go through all the files and start working where its required to start. So My Aim is to help the developers to fast track their development so that they can start immediately on the file where the working is required.For that you are required to enter the extension of the file in which the text is most likely to be i.e .jsx contains code files in react projects or .js so you have to enter this also the path from where you want to start search. Also the text which you want to find or you've seen in the running project and now you want to start working right in the file where that text is present.It will be mostly helpful to the developers who are working on some one's other developer project and had a hard time to figure out the starting point where to start in which file to start.

## Running the software
To download the setup you can download the folder in this repository root folder named  SELABPROJECT_SEARCHING 
