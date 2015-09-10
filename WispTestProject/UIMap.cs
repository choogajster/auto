using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;


namespace WispTestProject
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;




    
    
    public class UIMapMain : BrowserWindow
    {
		protected static BrowserWindow browserWindow = new BrowserWindow();
		protected int WAIT_FOR_CONTROL = Parameters.WAIT_FOR_CONTROL;
		public static void ClickLinkByName(string name)
		{

			#region Variable Declarations

			HtmlHyperlink lnk = new HtmlHyperlink(browserWindow);
			lnk.SearchProperties.Add(HtmlCustom.PropertyNames.InnerText, name,
				PropertyExpressionOperator.EqualTo);

			lnk.SearchProperties.Add(HtmlCustom.PropertyNames.InnerText, name, PropertyExpressionOperator.Contains);
			lnk.SearchProperties.Add(HtmlCustom.PropertyNames.FriendlyName, name, PropertyExpressionOperator.Contains);
			#endregion


			lnk.WaitForControlExist();
			Mouse.Click(lnk);
		}

		public static void EnterTextInSingleline(string fieldName, string text)
		{
			HtmlEdit Edit = new HtmlEdit(browserWindow);
			//Edit.SearchProperties.Add(HtmlEdit.PropertyNames.Type, "SINGLELINE", PropertyExpressionOperator.EqualTo);
			Edit.SearchProperties.Add(HtmlEdit.PropertyNames.Name, fieldName, PropertyExpressionOperator.EqualTo);
			Edit.FilterProperties.Add(HtmlEdit.PropertyNames.Id, fieldName, PropertyExpressionOperator.Contains);
			Edit.FilterProperties.Add(HtmlEdit.PropertyNames.ControlDefinition, fieldName, PropertyExpressionOperator.Contains);

			//Edit.WaitForControlExist(Parameters.WAIT_FOR_CONTROL);
			Edit.WaitForControlExist();
			Edit.Text = text;
		}

		public static void ClickButton(string btnName, string btnType)
		{
			HtmlButton Btn = new HtmlButton(browserWindow);
			Btn.SearchProperties.Add(HtmlEdit.PropertyNames.Type, btnType, PropertyExpressionOperator.EqualTo);
			Btn.SearchProperties.Add(HtmlEdit.PropertyNames.InnerText, btnName, PropertyExpressionOperator.EqualTo);


			Btn.WaitForControlExist();

			Mouse.Click(Btn);
		}

    }
}
