using JobSchedulers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JobSchedulers
{
  public  class JoBDownloadWebsite : IJob
    {
       public void Execute (DateTime signalTime)
        {
            string url = Console.ReadLine();
            WebClient wc = new WebClient();
            string html = wc.DownloadString(url);
            File.WriteAllText(@"E:\LessС#\Less linq\LinqSample-master\LinqSamples\JobScheduler\DownloadWebsite.txt", html);
        }

    }
}
