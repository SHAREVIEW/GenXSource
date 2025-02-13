using System;
using Genetibase.NuGenHL7.model;
using Genetibase.NuGenHL7.model.v25.datatype;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
namespace Genetibase.NuGenHL7.model.v25.segment
{
	
	/// <summary> <p>Represents an HL7 LCH message segment. 
	/// This segment has the following fields:</p><p>
	/// LCH-1: Primary Key Value - LCH (PL)<br> 
	/// LCH-2: Segment Action Code (ID)<br> 
	/// LCH-3: Segment Unique Key (EI)<br> 
	/// LCH-4: Location Characteristic ID (CE)<br> 
	/// LCH-5: Location Characteristic Value-LCH (CE)<br> 
	/// </p><p>The get...() methods return data from individual fields.  These methods 
	/// do not throw exceptions and may therefore have to handle exceptions internally.  
	/// If an exception is handled internally, it is logged and null is returned.  
	/// This is not expected to happen - if it does happen this indicates not so much 
	/// an exceptional circumstance as a bug in the code for this class.</p>    
	/// </summary>
	[Serializable]
	public class LCH:AbstractSegment
	{
		/// <summary> Returns Primary Key Value - LCH (LCH-1).</summary>
		virtual public PL PrimaryKeyValueLCH
		{
			get
			{
				PL ret = null;
				try
				{
					Type t = this.getField(1, 0);
					ret = (PL) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Segment Action Code (LCH-2).</summary>
		virtual public ID SegmentActionCode
		{
			get
			{
				ID ret = null;
				try
				{
					Type t = this.getField(2, 0);
					ret = (ID) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Segment Unique Key (LCH-3).</summary>
		virtual public EI SegmentUniqueKey
		{
			get
			{
				EI ret = null;
				try
				{
					Type t = this.getField(3, 0);
					ret = (EI) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Location Characteristic ID (LCH-4).</summary>
		virtual public CE LocationCharacteristicID
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(4, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns Location Characteristic Value-LCH (LCH-5).</summary>
		virtual public CE LocationCharacteristicValueLCH
		{
			get
			{
				CE ret = null;
				try
				{
					Type t = this.getField(5, 0);
					ret = (CE) t;
				}
				catch (System.InvalidCastException )
				{
					throw new Exception();
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		
		/// <summary> Creates a LCH (Location Characteristic) segment object that belongs to the given 
		/// message.  
		/// </summary>
		public LCH(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			Message message = Message;
			try
			{
				this.add(typeof(PL), true, 1, 200, new System.Object[]{message});
				this.add(typeof(ID), false, 1, 3, new System.Object[]{message, 206});
				this.add(typeof(EI), false, 1, 80, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
				this.add(typeof(CE), true, 1, 250, new System.Object[]{message});
			}
			catch (NuGenHL7Exception)
			{
			}
		}
	}
}