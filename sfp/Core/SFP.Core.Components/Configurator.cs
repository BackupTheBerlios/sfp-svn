#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

#endregion

namespace SFP.Core.Components
{
	/// <summary>
	/// 
	/// </summary>
	public class Configurator
	{
		// Configuration file name.  The name is built using the 
		// directory of the application.  When in development this
		// is likely the \bin\Debug directory in the project folder.
		private readonly string _FILENAME =  System.AppDomain.CurrentDomain.BaseDirectory + "config.xml";
		// XML containing configuration settings
		private XmlDocument _ConfigFile = null;

		/// <summary>
		/// Constructor
		/// </summary>
		public Configurator()
		{
			this._ConfigFile = new XmlDocument();
			XmlTextReader reader = null;

			try
			{
				// Load the XML file
				reader = new XmlTextReader(this._FILENAME);
				reader.Read();
				this._ConfigFile.Load(reader);
			}
			catch
			{
				// Unable to load the XML file and verify file path
				System.Diagnostics.Debug.WriteLine("Unable to open file: " + this._FILENAME);
				this._ConfigFile = null;
			}
			finally
			{
				reader.Close();
			}
		}
		/// <summary>
		/// Get the value for the desired setting.
		/// </summary>
		/// <param name="SettingName">Name of setting value to 
		///             retrieve. </param>
		/// <returns>String containing setting value. </returns>
		public string GetSetting(string SettingName)
		{
			string returnValue = "";      // Value to return

			// Retrieve the appropriate Parameter node from the XML
			XmlNode node =
			  this._ConfigFile.DocumentElement.SelectSingleNode(
			   "descendant::Parameter[@Name='" + SettingName + "']");
			if (node != null)
			{
				// Retrieve the setting value from the Value attribute
				returnValue =
					node.Attributes.GetNamedItem("Value").InnerText;
			}
			return returnValue;
		}

		/// <summary>
		/// Save a new value for the desired setting.  If the setting 
		/// does not already exist then it will be automatically created.
		/// </summary>
		/// <param name="SettingName">Name - Key der Wertes. </param>
		/// <param name="SettingValue">Wert. </param>
		public void SaveSetting(string SettingName, string SettingValue)
		{
			// Value vom XMl holen
			XmlNode node =	  
				this._ConfigFile.DocumentElement.SelectSingleNode(
			   "descendant::Parameter[@Name='" + SettingName + "']");
			if (node != null)
			{
				// Neuen Wert des Values setzen
				node.Attributes.GetNamedItem("Value").InnerText = SettingValue;
			}
			else
			{
				// Parameter nich vorhanden also anlegen
				XmlElement setting =
					  this._ConfigFile.CreateElement("Parameter");
				setting.SetAttribute("Name", SettingName);
				setting.SetAttribute("Value", SettingValue);
				this._ConfigFile.DocumentElement.AppendChild(setting);
			}
			this._ConfigFile.Save(this._FILENAME);
		}
	}
}
