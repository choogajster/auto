using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITest.Common;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace WispTestProject
{
	/// <summary>
	/// Summary description for contacts
	/// </summary>
	[CodedUITest]
	public class Contacts : TestTemplate
	{

		[TestMethod]
			public void login()
			{

				LaunchBrowser_Keep("https://agaveqa.inside.cactussoft.biz/admin", true);
				UIMapMain.EnterTextInSingleline("username","alexander.isayonok@cactussoft.biz");
				UIMapMain.EnterTextInSingleline("password", "Secret12");
				UIMapMain.ClickButton("sign in", "submit");
			
				UIMapMain.ClickLinkByName("Brand New Test");
				//UIMapMain.ClickButton("New Company", "button");
			//test
			}
	}
}
