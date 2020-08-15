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

namespace Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ColegioDB")]
	public partial class ColegioContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Inserttb_alumno(tb_alumno instance);
    partial void Updatetb_alumno(tb_alumno instance);
    partial void Deletetb_alumno(tb_alumno instance);
    #endregion
		
		public ColegioContextDataContext() : 
				base(global::Linq.Properties.Settings.Default.ColegioDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ColegioContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tb_alumno> tb_alumno
		{
			get
			{
				return this.GetTable<tb_alumno>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_alumno")]
	public partial class tb_alumno : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _nombres;
		
		private string _apellidos;
		
		private System.Nullable<int> _calificacion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnombresChanging(string value);
    partial void OnnombresChanged();
    partial void OnapellidosChanging(string value);
    partial void OnapellidosChanged();
    partial void OncalificacionChanging(System.Nullable<int> value);
    partial void OncalificacionChanged();
    #endregion
		
		public tb_alumno()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombres", DbType="VarChar(250)")]
		public string nombres
		{
			get
			{
				return this._nombres;
			}
			set
			{
				if ((this._nombres != value))
				{
					this.OnnombresChanging(value);
					this.SendPropertyChanging();
					this._nombres = value;
					this.SendPropertyChanged("nombres");
					this.OnnombresChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_apellidos", DbType="VarChar(250)")]
		public string apellidos
		{
			get
			{
				return this._apellidos;
			}
			set
			{
				if ((this._apellidos != value))
				{
					this.OnapellidosChanging(value);
					this.SendPropertyChanging();
					this._apellidos = value;
					this.SendPropertyChanged("apellidos");
					this.OnapellidosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_calificacion", DbType="Int")]
		public System.Nullable<int> calificacion
		{
			get
			{
				return this._calificacion;
			}
			set
			{
				if ((this._calificacion != value))
				{
					this.OncalificacionChanging(value);
					this.SendPropertyChanging();
					this._calificacion = value;
					this.SendPropertyChanged("calificacion");
					this.OncalificacionChanged();
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