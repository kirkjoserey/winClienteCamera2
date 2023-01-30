using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace winClienteCamera2
{
	class Params
	{
	
		public String getXMLSetSubscribe()
		{
			string aux= "C:\\Sources\\setSubscribe.xml";

			string auxi = System.IO.File.ReadAllText(aux);

			return auxi;
		}

		public String getXMLGetMessages()
		{
			string aux = "C:\\Sources\\GetMessages.xml";

			string auxi = System.IO.File.ReadAllText(aux);

			return auxi;

		}

	}
}
