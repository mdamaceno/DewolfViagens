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
	public partial class Passageiro
	{
		private int _idpassageiro;
		public virtual int Idpassageiro
		{
			get
			{
				return this._idpassageiro;
			}
			set
			{
				this._idpassageiro = value;
			}
		}
		
		private string _nome;
		public virtual string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				this._nome = value;
			}
		}
		
		private int _idade;
		public virtual int Idade
		{
			get
			{
				return this._idade;
			}
			set
			{
				this._idade = value;
			}
		}
		
		private string _cpf;
		public virtual string Cpf
		{
			get
			{
				return this._cpf;
			}
			set
			{
				this._cpf = value;
			}
		}
		
		private string _rg;
		public virtual string Rg
		{
			get
			{
				return this._rg;
			}
			set
			{
				this._rg = value;
			}
		}
		
		private int? _autorizacao;
		public virtual int? Autorizacao
		{
			get
			{
				return this._autorizacao;
			}
			set
			{
				this._autorizacao = value;
			}
		}
		
		private Autorizacao _autorizacao1;
		public virtual Autorizacao Autorizacao1
		{
			get
			{
				return this._autorizacao1;
			}
			set
			{
				this._autorizacao1 = value;
			}
		}
		
		private IList<Passagem> _passagems = new List<Passagem>();
		public virtual IList<Passagem> Passagems
		{
			get
			{
				return this._passagems;
			}
		}
		
	}
}
#pragma warning restore 1591