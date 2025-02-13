// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision: 1661 $</version>
// </file>

using System;
using ICSharpCode.Core;

namespace ICSharpCode.SharpDevelop
{
	/// <summary>
	/// Class containing static properties for the code completion options.
	/// </summary>
	public static class CodeCompletionOptions
	{
		static Properties properties = PropertyService.Get("CodeCompletionOptions", new Properties());
		
		public static Properties Properties {
			get {
				return properties;
			}
		}
		
		public static bool EnableCodeCompletion {
			get {
				return properties.Get("EnableCC", true);
			}
			set {
				properties.Set("EnableCC", value);
			}
		}
		
		public static bool DataUsageCacheEnabled {
			get {
				return properties.Get("DataUsageCacheEnabled", true);
			}
			set {
				properties.Set("DataUsageCacheEnabled", value);
			}
		}
		
		public static int DataUsageCacheItemCount {
			get {
				return properties.Get("DataUsageCacheItemCount", 500);
			}
			set {
				properties.Set("DataUsageCacheItemCount", value);
			}
		}
		
		public static bool TooltipsEnabled {
			get {
				return properties.Get("TooltipsEnabled", true);
			}
			set {
				properties.Set("TooltipsEnabled", value);
			}
		}
		
		public static bool TooltipsOnlyWhenDebugging {
			get {
				return properties.Get("TooltipsOnlyWhenDebugging", false);
			}
			set {
				properties.Set("TooltipsOnlyWhenDebugging", value);
			}
		}
		
		public static bool KeywordCompletionEnabled {
			get {
				return properties.Get("KeywordCompletionEnabled", true);
			}
			set {
				properties.Set("KeywordCompletionEnabled", value);
			}
		}
		
		public static bool InsightEnabled {
			get {
				return properties.Get("InsightEnabled", true);
			}
			set {
				properties.Set("InsightEnabled", value);
			}
		}
		
		public static bool InsightRefreshOnComma {
			get {
				return properties.Get("InsightRefreshOnComma", true);
			}
			set {
				properties.Set("InsightRefreshOnComma", value);
			}
		}
	}
}
