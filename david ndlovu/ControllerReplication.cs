using david_ndlovu.ReplicationSerivce;
using ReplicationServiceApplication.Http;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace david_ndlovu
{
    class ControllerReplication
    {

        public string GetPath(string path)
        {
            String[] tempSourcePath = path.Split('\\');
            string new_path = null;

            Regex regex = new Regex(@"\.");
            Match match = regex.Match(tempSourcePath.Last());
            if (match.Success)
            {
                for (var t =0;t<(tempSourcePath.Length -1);t++)
                {
                    new_path += tempSourcePath[t]+"\\";

                }
                return new_path.Substring(0,new_path.Length-1);
            }

            return path;
        }

        public bool PostForBackUp(string source,string destination,bool includeSubDirectory=false, bool cleanDestination=false)
        {

            try {

                ReplicationSerivce.ReplicationClient client = new ReplicationSerivce.ReplicationClient();
                ResponseReplication t = client.BackUpForReplication( source,  destination,  includeSubDirectory,  cleanDestination);

                if (t.status == "200")
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
               
            }catch(Exception e)
            {
                return false;
            }
        }
    }


}
