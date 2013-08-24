// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it 
// the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free 
// any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                // downloading file on desktop
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\logo.jpg");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
        }
    }
}