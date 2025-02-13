﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 2045 $</version>
// </file>

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Project;
using Microsoft.Build.BuildEngine;

namespace ICSharpCode.SharpDevelop.Internal.Templates
{
	public class FileDescriptionTemplate
	{
		string name;
		string language;
		
		// Either content or contentData is set, the other is null
		string content;
		byte[] contentData;
		
		string itemType;
		Dictionary<string, string> metadata = new Dictionary<string, string>();
		
		public bool IsDependentFile {
			get {
				return metadata.ContainsKey("DependentUpon");
			}
		}
		
		static readonly Set<string> knownAttributes = new Set<string>(
			"name", "language", "buildAction", "src", "binary"
		);
		
		public FileDescriptionTemplate(XmlElement xml, string hintPath)
		{
			TemplateLoadException.AssertAttributeExists(xml, "name");
			
			name = xml.GetAttribute("name");
			language = xml.GetAttribute("language");
			if (xml.HasAttribute("buildAction")) {
				itemType = xml.GetAttribute("buildAction");
			}
			foreach (XmlAttribute attribute in xml.Attributes) {
				string attributeName = attribute.Name;
				if (!knownAttributes.Contains(attributeName)) {
					if (attributeName == "copyToOutputDirectory") {
						ProjectTemplate.WarnObsoleteAttribute(xml, attributeName, "Use upper-case attribute names for MSBuild metadata values!");
						attributeName = "CopyToOutputDirectory";
					}
					if (attributeName == "dependentUpon") {
						ProjectTemplate.WarnObsoleteAttribute(xml, attributeName, "Use upper-case attribute names for MSBuild metadata values!");
						attributeName = "DependentUpon";
					}
					if (attributeName == "subType") {
						ProjectTemplate.WarnObsoleteAttribute(xml, attributeName, "Use upper-case attribute names for MSBuild metadata values!");
						attributeName = "SubType";
					}
					
					metadata[attributeName] = attribute.Value;
				}
			}
			if (xml.HasAttribute("src")) {
				string fileName = Path.Combine(hintPath, StringParser.Parse(xml.GetAttribute("src")));
				try {
					if (xml.HasAttribute("binary") && bool.Parse(xml.GetAttribute("binary"))) {
						contentData = File.ReadAllBytes(fileName);
					} else {
						content = File.ReadAllText(fileName);
					}
				} catch (Exception e) {
					content = "Error reading content from " + fileName + ":\n" + e.ToString();
					LoggingService.Warn(content);
				}
			} else {
				content = xml.InnerText;
			}
		}
		
		/// <summary>
		/// Sets meta data properties.
		/// </summary>
		/// <returns>Returns <c>true</c> when the projectItem was changed
		/// (in ItemType or MetaData)</returns>
		public bool SetProjectItemProperties(ProjectItem projectItem)
		{
			if (projectItem == null)
				throw new ArgumentNullException("projectItem");
			if (itemType != null) {
				projectItem.ItemType = new ItemType(itemType);
			}
			foreach (KeyValuePair<string, string> pair in metadata) {
				projectItem.SetMetadata(pair.Key, StringParser.Parse(pair.Value));
			}
			return itemType != null || metadata.Count > 0;
		}
		
		public FileDescriptionTemplate(string name, string language, string content)
		{
			this.name    = name;
			this.language = language;
			this.content  = content;
		}
		
		public string Name {
			get {
				return name;
			}
		}
		
		public string Language {
			get {
				return language;
			}
		}
		
		public string Content {
			get {
				return content;
			}
		}
		
		public byte[] ContentData {
			get {
				return contentData;
			}
		}
	}
}
