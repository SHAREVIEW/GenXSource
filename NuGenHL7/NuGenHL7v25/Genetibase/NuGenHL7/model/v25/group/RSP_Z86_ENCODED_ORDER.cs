using System;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using Genetibase.NuGenHL7.model.v25.segment;
using Genetibase.NuGenHL7.model;
namespace Genetibase.NuGenHL7.model.v25.group
{
	/// <summary> <p>Represents the RSP_Z86_ENCODED_ORDER Group.  A Group is an ordered collection of message 
	/// segments that can repeat together or be optionally in/excluded together.
	/// This Group contains the following elements: </p>
	/// 0: RXE (Pharmacy/Treatment Encoded Order) <b></b><br>
	/// 1: RSP_Z86_TIMING_ENCODED (a Group object) <b>optional repeating</b><br>
	/// 2: RXR (Pharmacy/Treatment Route) <b>repeating</b><br>
	/// 3: RXC (Pharmacy/Treatment Component Order) <b>optional repeating</b><br>
	/// </summary>
	[Serializable]
	public class RSP_Z86_ENCODED_ORDER:AbstractGroup
	{
		/// <summary> Returns RXE (Pharmacy/Treatment Encoded Order) - creates it if necessary</summary>
		virtual public RXE RXE
		{
			get
			{
				RXE ret = null;
				try
				{
					ret = (RXE) this.get_Renamed("RXE");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RSP_Z86_TIMING_ENCODED </summary>
		virtual public int TIMING_ENCODEDReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("TIMING_ENCODED").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RXR </summary>
		virtual public int RXRReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXR").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of RXC </summary>
		virtual public int RXCReps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("RXC").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new RSP_Z86_ENCODED_ORDER Group.</summary>
		public RSP_Z86_ENCODED_ORDER(Group parent, ModelClassFactory factory):base(parent, factory)
		{
			try
			{
				this.add(typeof(RXE), true, false);
				this.add(typeof(RSP_Z86_TIMING_ENCODED), false, true);
				this.add(typeof(RXR), true, true);
				this.add(typeof(RXC), false, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of RSP_Z86_TIMING_ENCODED (a Group object) - creates it if necessary</summary>
		public virtual RSP_Z86_TIMING_ENCODED getTIMING_ENCODED()
		{
			RSP_Z86_TIMING_ENCODED ret = null;
			try
			{
				ret = (RSP_Z86_TIMING_ENCODED) this.get_Renamed("TIMING_ENCODED");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RSP_Z86_TIMING_ENCODED
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RSP_Z86_TIMING_ENCODED getTIMING_ENCODED(int rep)
		{
			return (RSP_Z86_TIMING_ENCODED) this.get_Renamed("TIMING_ENCODED", rep);
		}
		
		/// <summary> Returns  first repetition of RXR (Pharmacy/Treatment Route) - creates it if necessary</summary>
		public virtual RXR getRXR()
		{
			RXR ret = null;
			try
			{
				ret = (RXR) this.get_Renamed("RXR");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXR
		/// (Pharmacy/Treatment Route) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXR getRXR(int rep)
		{
			return (RXR) this.get_Renamed("RXR", rep);
		}
		
		/// <summary> Returns  first repetition of RXC (Pharmacy/Treatment Component Order) - creates it if necessary</summary>
		public virtual RXC getRXC()
		{
			RXC ret = null;
			try
			{
				ret = (RXC) this.get_Renamed("RXC");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of RXC
		/// (Pharmacy/Treatment Component Order) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual RXC getRXC(int rep)
		{
			return (RXC) this.get_Renamed("RXC", rep);
		}
	}
}