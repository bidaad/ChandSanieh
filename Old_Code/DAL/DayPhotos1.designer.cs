﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AceNews.Old_Code.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AceNews")]
	public partial class DayPhotosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDayPhotos(DayPhotos instance);
    partial void UpdateDayPhotos(DayPhotos instance);
    partial void DeleteDayPhotos(DayPhotos instance);
    #endregion
		
		public DayPhotosDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AceNewsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DayPhotosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DayPhotosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DayPhotosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DayPhotosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DayPhotos> DayPhotos
		{
			get
			{
				return this.GetTable<DayPhotos>();
			}
		}
		
		public System.Data.Linq.Table<vDayPhotos> vDayPhotos
		{
			get
			{
				return this.GetTable<vDayPhotos>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DayPhotos")]
	public partial class DayPhotos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private System.Nullable<System.DateTime> _DayDate;
		
		private string _Title;
		
		private string _PicFile;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnDayDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDayDateChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnPicFileChanging(string value);
    partial void OnPicFileChanged();
    #endregion
		
		public DayPhotos()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DayDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> DayDate
		{
			get
			{
				return this._DayDate;
			}
			set
			{
				if ((this._DayDate != value))
				{
					this.OnDayDateChanging(value);
					this.SendPropertyChanging();
					this._DayDate = value;
					this.SendPropertyChanged("DayDate");
					this.OnDayDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PicFile", DbType="NVarChar(200)")]
		public string PicFile
		{
			get
			{
				return this._PicFile;
			}
			set
			{
				if ((this._PicFile != value))
				{
					this.OnPicFileChanging(value);
					this.SendPropertyChanging();
					this._PicFile = value;
					this.SendPropertyChanged("PicFile");
					this.OnPicFileChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vDayPhotos")]
	public partial class vDayPhotos
	{
		
		private int _Code;
		
		private string _Title;
		
		private string _DDate;
		
		public vDayPhotos()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this._Code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(500) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DDate", DbType="VarChar(10)")]
		public string DDate
		{
			get
			{
				return this._DDate;
			}
			set
			{
				if ((this._DDate != value))
				{
					this._DDate = value;
				}
			}
		}
	}
}
#pragma warning restore 1591