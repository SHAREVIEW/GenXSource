// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="none" email=""/>
//     <version>$Revision: 1989 $</version>
// </file>

// 

using System;
using System.ComponentModel;

namespace ICSharpCode.SharpDevelop.Gui
{
	/// <summary>
	/// GlobalizedObject implements ICustomTypeDescriptor to enable 
	/// required functionality to describe a type (class).<br></br>
	/// The main task of this class is to instantiate our own property descriptor 
	/// of type GlobalizedPropertyDescriptor.  
	/// </summary>
	public class LocalizedObject : ICustomTypeDescriptor
	{
		PropertyDescriptorCollection globalizedProps;
		
		string ICustomTypeDescriptor.GetClassName()
		{
			return TypeDescriptor.GetClassName(this,true);
		}

		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this,true);
		}

		string ICustomTypeDescriptor.GetComponentName()
		{
			return TypeDescriptor.GetComponentName(this, true);
		}

		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent() 
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty() 
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		object ICustomTypeDescriptor.GetEditor(Type editorBaseType) 
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes) 
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		protected virtual void FilterProperties(PropertyDescriptorCollection globalizedProps)
		{
		}
		
		/// <summary>
		/// Called to get the properties of a type.
		/// </summary>
		/// <param name="attributes"></param>
		/// <returns></returns>
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			if ( globalizedProps == null) {
				// Get the collection of properties
				PropertyDescriptorCollection baseProps = TypeDescriptor.GetProperties(this, attributes, true);

				globalizedProps = new PropertyDescriptorCollection(null);

				// For each property use a property descriptor of our own that is able to be globalized
				foreach (PropertyDescriptor oProp in baseProps) {
					globalizedProps.Add(new LocalizedPropertyDescriptor(oProp));
				}
				FilterProperties(globalizedProps);
			}
			return globalizedProps;
		}

		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			// Only do once
			if (globalizedProps == null) {
				// Get the collection of properties
				PropertyDescriptorCollection baseProps = TypeDescriptor.GetProperties(this, true);
				globalizedProps = new PropertyDescriptorCollection(null);

				// For each property use a property descriptor of our own that is able to be globalized
				foreach (PropertyDescriptor oProp in baseProps) {
					globalizedProps.Add(new LocalizedPropertyDescriptor(oProp));
				}
				FilterProperties(globalizedProps);
			}
			return globalizedProps;
		}

		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) 
		{
			return this;
		}
		
		public virtual void InformSetValue(LocalizedPropertyDescriptor localizedPropertyDescriptor, object component, object value)
		{
			
		}
	}
}
