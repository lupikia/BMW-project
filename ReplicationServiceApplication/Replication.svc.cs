using ReplicationLibrary;
using ReplicationServiceApplication.Http;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text.RegularExpressions;

namespace ReplicationServiceApplication
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Replication : IReplication
    {
        private string [] sourcePath = new string [1];
        private List<string> directoryDelete = new List<string>();
        private string originalSourcePath =null;
        private string destinationPath;
        private int buildingPathIndex=0;
        private string newPath;
        private string checkDirectory = null;

        public ResponseReplication BackUpForReplication(string source, string destination, bool includeSubDirectory, bool cleanDestination)
        {
            sourcePath = GetPath(@source);
            originalSourcePath = @source;
            destinationPath = @destination;


            ResponseReplication reps = new ResponseReplication();

            
            DirectoryInfo sourceDirectoryCheck = new DirectoryInfo(originalSourcePath);
            var checkSource = sourceDirectoryCheck.Root.ToString();//.Substring(0, sourceDirectoryCheck.Root.ToString().Length - 1); ;
            string[] sourceDirectoryCount = getDirectory(checkSource);


            try { 
                
                ////-->check if file exist in destination
                if (pathExistInDEstination())
                {
                    //--check if file is only file and is the same size
                    if (includeSubDirectory)
                    {
                        if (DestiantionFileIsDifferent())
                        {
                            //-->filese not the same
                            DeleteDirectory();
                            DeleteFileAtDestination();
                            CopyFileToDestination();
                        }
                        else
                        {
                            //--> file are the same
                            DeleteFileAtDestination();
                            CopyFileToDestination();
                        }
                    }

                }
                else
                {
                    //-->create directories beause the destination was not found
                    createDirectoryPath();
                    DeleteFileAtDestination();
                    CopyFileToDestination();
                }

                reps.message = "Sucess";

                return reps;
            }
            catch(Exception e)
            {
                reps.message = e.Message;

                return reps;

            }
        }

        private bool DestiantionSubDirectoryIsDifferent()
        {
            //-->searching for difference in folders
            if (CheckAdditionalDirectory())
            {
                //-->folder changes
                return false;
            }
            else
            {
                //-->no folder changes
                return true;
            }
        }
        private bool DestiantionFileIsDifferent(bool includeSubdirectories=false)
        {
        
            string[] filesCheck = Directory.GetFiles(destinationPath, "*.*");

            //-->check how many files
            if (filesCheck.Length==1)
            {
                //-->check size of the file
                FileInfo destinationFileInfo = new FileInfo(filesCheck[0]);
                FileInfo sourceFileInfo = new FileInfo(originalSourcePath);
              
                if (sourceFileInfo.Length==destinationFileInfo.Length && sourceFileInfo.CreationTime == destinationFileInfo.CreationTime )
                {
                    //-->no file changes
                    return false;
                }
                else
                {
                    //-->If file  has changes in size or date change
                    return true;
                }
            }

            //-->more than one file exist in destination or difference in file size or creationTime
            return true;
        }

        //-->recursion check directories
        private bool CheckAdditionalDirectory()
        {
            bool checkDone = false;
            string[] directories = sourcePath[0].Split('\\');
           
            DirectoryInfo destinationDirectoryCheck = new DirectoryInfo(destinationPath);
            DirectoryInfo sourceDirectoryCheck = new DirectoryInfo(originalSourcePath);

            var checkDestination = destinationDirectoryCheck.Root.ToString();
            var checkSource = sourceDirectoryCheck.Root.ToString();
            for(var r=0;r< directories.Length;r++)
            {
                string pathcheck = null;
                if (r!=0) { 
                 pathcheck = "\\" + directories[r];
                }
                checkDestination += pathcheck;
                checkSource+= pathcheck;

                string[] destinationDirectoryCount = getDirectory(checkDestination);
                string[] sourceDirectoryCount = getDirectory(checkSource);

                //-->clean up outpaths
                for (var u =0;u< sourceDirectoryCount.Length;u++)
                {
                    sourceDirectoryCount[u] = sourceDirectoryCount[u].Substring(3);
                }
                
                if(!destinationDirectoryCount.SequenceEqual(sourceDirectoryCount))
                {
                    //-->get the difference between directories
                    foreach(var sourceD in destinationDirectoryCount) {

                        if (!sourceDirectoryCount.Contains((sourceD.Substring(3)))) { 
                            directoryDelete.Add(sourceD);
                        }
                    }
                }
            }

         return checkDone;
        }
        
        //-->recursion for creating directories
        private bool createDirectoryPath()
        {
            bool creationDone = false;
            newPath += sourcePath[buildingPathIndex] +"\\";

           
            if (buildingPathIndex==(sourcePath.Length-1))
            {
                creationDone= true;
            }
            else
            {
                Directory.CreateDirectory(newPath);

                if (buildingPathIndex!=(sourcePath.Length - 1))
                {
                    buildingPathIndex++;
                }
                createDirectoryPath();
            }

            return creationDone;
        }


        private void CopyFileToDestination()
        {
            File.Copy(originalSourcePath,@"c:\", true);
        }
         private bool pathExistInDEstination()
        {
            return File.Exists(destinationPath +"\\"+sourcePath[1]);
        }

        private bool DeleteDirectory()
        {
            //-->check if path are exactly the same
            foreach(var unwantedDirectory in directoryDelete)
            { 
                DirectoryInfo subDirectory = new DirectoryInfo(unwantedDirectory);
             //   subDirectory.Delete();
            }
            return true;
        }private void DeleteFileAtDestination()
        {
            File.Delete((destinationPath+"\\"+sourcePath[1]));
            
        }
        private string [] getDirectory(string path)
        {
            return Directory.GetDirectories(path);
        }
        private string [] GetPath(string path)
        {
            String[] tempSourcePath = path.Split('\\');
            string new_path = null;

            Regex regex = new Regex(@"\.");
            Match match = regex.Match(tempSourcePath.Last());
            if (match.Success)
            {
                for (var t = 0; t < (tempSourcePath.Length - 1); t++)
                {
                    new_path += tempSourcePath[t] + "\\";

                }
                new_path= new_path.Substring(0, new_path.Length - 1);
            }

            return new string []{ new_path, tempSourcePath.Last() };
        }

        private bool WriteToLog(string replicationJob)
        {
            var LogFile = @ConfigurationManager.AppSettings["logPath"];
            if (File.Exists(LogFile)) { 
                using (StreamWriter file = new StreamWriter(LogFile, true))
                {
                    file.WriteLine(replicationJob);
                    file.Close();
                }
            }
            else
            {
                using (StreamWriter file = File.CreateText(LogFile))
                {
                    file.WriteLine(replicationJob);
                    file.Close();
                }
            }
            return true;
        }
    }
}
