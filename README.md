# Append
 Appends filename to existing files
 
 # Useage: 
 ```[option] [Append Name] [Directory]```
 
   ### Options:
       First -> Appends name to beginning of file name
       Last -> Appends name to end of file name
  
  You can substitute a "." for the directory name if your console in in the desired directory
  **CAUTION:** this tool changes the name of **EVERY** file in the directory.
       
      
# Building: 
There is no nuget file in the project, so you will have to download and build it yourself. Project was built aginst .net5.0. Download and from the project root run ```dotnet build``` then ```dotnet pack```

# Thanks:
The command line parsing part of this project was inspired by https://github.com/romanov/MonoGame-Console
