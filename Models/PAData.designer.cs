﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COVIDProyecto2._0.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="YoApoyoPeruBD")]
	public partial class PADataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertBOPersonalAdmin(BOPersonalAdmin instance);
    partial void UpdateBOPersonalAdmin(BOPersonalAdmin instance);
    partial void DeleteBOPersonalAdmin(BOPersonalAdmin instance);
    #endregion
		
		public PADataDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["YoApoyoPeruBDConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PADataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PADataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PADataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PADataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BOPersonalAdmin> BOPersonalAdmin
		{
			get
			{
				return this.GetTable<BOPersonalAdmin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PersonalAdmin")]
	public partial class BOPersonalAdmin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_personal;
		
		private string _nombrePersonal;
		
		private string _apellidosPersonal;
		
		private string _contraseña;
		
		private int _estado;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_personalChanging(int value);
    partial void Onid_personalChanged();
    partial void OnnombrePersonalChanging(string value);
    partial void OnnombrePersonalChanged();
    partial void OnapellidosPersonalChanging(string value);
    partial void OnapellidosPersonalChanged();
    partial void OncontraseñaChanging(string value);
    partial void OncontraseñaChanged();
    partial void OnestadoChanging(int value);
    partial void OnestadoChanged();
    #endregion
		
		public BOPersonalAdmin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_personal", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_personal
		{
			get
			{
				return this._id_personal;
			}
			set
			{
				if ((this._id_personal != value))
				{
					this.Onid_personalChanging(value);
					this.SendPropertyChanging();
					this._id_personal = value;
					this.SendPropertyChanged("id_personal");
					this.Onid_personalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombrePersonal", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string nombrePersonal
		{
			get
			{
				return this._nombrePersonal;
			}
			set
			{
				if ((this._nombrePersonal != value))
				{
					this.OnnombrePersonalChanging(value);
					this.SendPropertyChanging();
					this._nombrePersonal = value;
					this.SendPropertyChanged("nombrePersonal");
					this.OnnombrePersonalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidosPersonal", DbType="VarChar(100)")]
		public string apellidosPersonal
		{
			get
			{
				return this._apellidosPersonal;
			}
			set
			{
				if ((this._apellidosPersonal != value))
				{
					this.OnapellidosPersonalChanging(value);
					this.SendPropertyChanging();
					this._apellidosPersonal = value;
					this.SendPropertyChanged("apellidosPersonal");
					this.OnapellidosPersonalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contraseña", DbType="VarChar(100)")]
		public string contraseña
		{
			get
			{
				return this._contraseña;
			}
			set
			{
				if ((this._contraseña != value))
				{
					this.OncontraseñaChanging(value);
					this.SendPropertyChanging();
					this._contraseña = value;
					this.SendPropertyChanged("contraseña");
					this.OncontraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="Int NOT NULL")]
		public int estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
