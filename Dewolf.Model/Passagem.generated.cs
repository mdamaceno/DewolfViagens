#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using Dewolf.Model;

namespace Dewolf.Model	
{
	public partial class Passagem
	{
		private int _idpassagem;
		public virtual int Idpassagem
		{
			get
			{
				return this._idpassagem;
			}
			set
			{
				this._idpassagem = value;
			}
		}
		
		private int _viagem;
		public virtual int Viagem
		{
			get
			{
				return this._viagem;
			}
			set
			{
				this._viagem = value;
			}
		}
		
		private int _passageiro;
		public virtual int Passageiro
		{
			get
			{
				return this._passageiro;
			}
			set
			{
				this._passageiro = value;
			}
		}
		
		private int _numPoltrona;
		public virtual int NumPoltrona
		{
			get
			{
				return this._numPoltrona;
			}
			set
			{
				this._numPoltrona = value;
			}
		}
		
		private decimal _vrDistancia;
		public virtual decimal VrDistancia
		{
			get
			{
				return this._vrDistancia;
			}
			set
			{
				this._vrDistancia = value;
			}
		}
		
		private decimal _vrPedagio;
		public virtual decimal VrPedagio
		{
			get
			{
				return this._vrPedagio;
			}
			set
			{
				this._vrPedagio = value;
			}
		}
		
		private decimal _vrTotal;
		public virtual decimal VrTotal
		{
			get
			{
				return this._vrTotal;
			}
			set
			{
				this._vrTotal = value;
			}
		}
		
		private Passageiro _passageiro1;
		public virtual Passageiro Passageiro1
		{
			get
			{
				return this._passageiro1;
			}
			set
			{
				this._passageiro1 = value;
			}
		}
		
		private Viagem _viagem1;
		public virtual Viagem Viagem1
		{
			get
			{
				return this._viagem1;
			}
			set
			{
				this._viagem1 = value;
			}
		}
		
	}
}
#pragma warning restore 1591