using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using NUnit.Framework;
using Nest.Tests.Integration.Yaml;


namespace Nest.Tests.Integration.Yaml.Ping
{
	public partial class PingTests
	{	


		public class PingReturnsTrueTests : YamlTestsBase
		{
			[Test]
			public void PingReturnsTrueTest()
			{	

				//do ping 
				this.Do(()=> this._client.PingHead());

				//is_true this._status; 
				this.IsTrue(this._status);

			}
		}
	}
}
