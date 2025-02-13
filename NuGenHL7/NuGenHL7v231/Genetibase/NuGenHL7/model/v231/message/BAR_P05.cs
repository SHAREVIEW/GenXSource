using System;
using Genetibase.NuGenHL7.model.v231.group;
using Genetibase.NuGenHL7.model.v231.segment;
using HL7Exception = Genetibase.NuGenHL7.NuGenHL7Exception;
using ModelClassFactory = Genetibase.NuGenHL7.parser.NuGenModelClassFactory;
using DefaultModelClassFactory = Genetibase.NuGenHL7.parser.NuGenDefaultModelClassFactory;
using AbstractMessage = Genetibase.NuGenHL7.model.AbstractMessage;
namespace Genetibase.NuGenHL7.model.v231.message
{
	
	/// <summary> <p>Represents a BAR_P05 message structure (see chapter ?). This structure contains the 
	/// following elements: </p>
	/// 0: MSH (MSH - message header segment) <b></b><br>
	/// 1: EVN (EVN - event type segment) <b></b><br>
	/// 2: PID (PID - patient identification segment) <b></b><br>
	/// 3: PD1 (PD1 - patient additional demographic segment) <b>optional </b><br>
	/// 4: BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 (a Group object) <b>repeating</b><br>
	/// </summary>
	[Serializable]
	public class BAR_P05:AbstractMessage
	{
		/// <summary> Returns MSH (MSH - message header segment) - creates it if necessary</summary>
		virtual public MSH MSH
		{
			get
			{
				MSH ret = null;
				try
				{
					ret = (MSH) this.get_Renamed("MSH");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns EVN (EVN - event type segment) - creates it if necessary</summary>
		virtual public EVN EVN
		{
			get
			{
				EVN ret = null;
				try
				{
					ret = (EVN) this.get_Renamed("EVN");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PID (PID - patient identification segment) - creates it if necessary</summary>
		virtual public PID PID
		{
			get
			{
				PID ret = null;
				try
				{
					ret = (PID) this.get_Renamed("PID");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns PD1 (PD1 - patient additional demographic segment) - creates it if necessary</summary>
		virtual public PD1 PD1
		{
			get
			{
				PD1 ret = null;
				try
				{
					ret = (PD1) this.get_Renamed("PD1");
				}
				catch (NuGenHL7Exception)
				{
					throw new Exception();
				}
				return ret;
			}
			
		}
		/// <summary> Returns the number of existing repetitions of BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 </summary>
		virtual public int PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2Reps
		{
			get
			{
				int reps = - 1;
				try
				{
					reps = this.getAll("PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2").Length;
				}
				catch (NuGenHL7Exception)
				{
					System.String message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
					throw new System.SystemException(message);
				}
				return reps;
			}
			
		}
		
		/// <summary> Creates a new BAR_P05 Group with custom ModelClassFactory.</summary>
		public BAR_P05(ModelClassFactory factory):base(factory)
		{
			init(factory);
		}
		
		/// <summary> Creates a new BAR_P05 Group with DefaultModelClassFactory. </summary>
		public BAR_P05():base(new DefaultModelClassFactory())
		{
			init(new DefaultModelClassFactory());
		}
		
		private void  init(ModelClassFactory factory)
		{
			try
			{
				this.add(typeof(MSH), true, false);
				this.add(typeof(EVN), true, false);
				this.add(typeof(PID), true, false);
				this.add(typeof(PD1), false, false);
				this.add(typeof(BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2), true, true);
			}
			catch (NuGenHL7Exception)
			{
			}
		}
		
		/// <summary> Returns  first repetition of BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 (a Group object) - creates it if necessary</summary>
		public virtual BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 getPV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2()
		{
			BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 ret = null;
			try
			{
				ret = (BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2) this.get_Renamed("PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2");
			}
			catch (NuGenHL7Exception)
			{
				throw new Exception();
			}
			return ret;
		}
		
		/// <summary> Returns a specific repetition of BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2
		/// (a Group object) - creates it if necessary
		/// throws HL7Exception if the repetition requested is more than one 
		/// greater than the number of existing repetitions.
		/// </summary>
		public virtual BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2 getPV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2(int rep)
		{
			return (BAR_P05_PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2) this.get_Renamed("PV1PV2DB1OBXAL1DG1DRGPR1ROLGT1NK1IN1IN2IN3ACCUB1UB2", rep);
		}
	}
}