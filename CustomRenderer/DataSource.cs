using System;
using System.Collections.Generic;

namespace CustomRenderer
{
	public class DataSource
	{
		public string HostName { get; set; }

		public string OSName { get; set; }

        public string IPAddress { get; set; }

        public string OnlineSince { get; set; }

        public string ImageFilename { get; set; }

		public DataSource (string hostName, string osName, string ipAddress, string onlineSince, string imageFilename)
		{
            HostName = hostName;
            OSName = osName;
            IPAddress = ipAddress;
            OnlineSince = onlineSince;

            ImageFilename = imageFilename;
		}

		public static List<DataSource> GetList ()
		{
			var l = new List<DataSource> ();

			l.Add (new DataSource ("HBA101010", "REDHAT V7", "10.30.140.10", "10/10/2016 12:23:24","Image1"));
			l.Add (new DataSource ("HBA483821", "WINDOWS 10", "10.30.140.11", "10/10/2016 12:23:24", "Image1"));
			l.Add (new DataSource ("HBA194626", "REDHAT V10", "10.30.140.12", "10/10/2016 12:23:24", "Image1"));
			l.Add (new DataSource ("HBA345267", "REDHAT V12", "10.30.140.13", "10/10/2016 12:23:24", "Image1"));
			l.Add (new DataSource ("HBA101922", "Windows 2008", "10.30.140.14", "10/10/2016 12:23:24", "Image1"));
			l.Add (new DataSource ("HBA281857", "Windows 2008", "10.30.140.14", "10/10/2016 12:23:24", "Image1"));
			l.Add (new DataSource ("HBA352627", "Windows 2010", "10.30.140.16", "10/10/2016 12:23:24", "Image1"));


			return l;
		}
	}
}
