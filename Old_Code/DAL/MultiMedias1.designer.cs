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
	public partial class MultiMediasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMultiMediaPictures(MultiMediaPictures instance);
    partial void UpdateMultiMediaPictures(MultiMediaPictures instance);
    partial void DeleteMultiMediaPictures(MultiMediaPictures instance);
    partial void InsertMultiMedias(MultiMedias instance);
    partial void UpdateMultiMedias(MultiMedias instance);
    partial void DeleteMultiMedias(MultiMedias instance);
    #endregion
		
		public MultiMediasDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AceNewsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MultiMediasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MultiMediasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MultiMediasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MultiMediasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vMultiMediaPictures> vMultiMediaPictures
		{
			get
			{
				return this.GetTable<vMultiMediaPictures>();
			}
		}
		
		public System.Data.Linq.Table<MultiMediaPictures> MultiMediaPictures
		{
			get
			{
				return this.GetTable<MultiMediaPictures>();
			}
		}
		
		public System.Data.Linq.Table<MultiMedias> MultiMedias
		{
			get
			{
				return this.GetTable<MultiMedias>();
			}
		}
		
		public System.Data.Linq.Table<vMultiMedias> vMultiMedias
		{
			get
			{
				return this.GetTable<vMultiMedias>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vMultiMediaPictures")]
	public partial class vMultiMediaPictures
	{
		
		private int _Code;
		
		private int _MultiMediaCode;
		
		private string _PicFile;
		
		private string _Title;
		
		public vMultiMediaPictures()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MultiMediaCode", DbType="Int NOT NULL")]
		public int MultiMediaCode
		{
			get
			{
				return this._MultiMediaCode;
			}
			set
			{
				if ((this._MultiMediaCode != value))
				{
					this._MultiMediaCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PicFile", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
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
					this._PicFile = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200)")]
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MultiMediaPictures")]
	public partial class MultiMediaPictures : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private int _MultiMediaCode;
		
		private string _PicFile;
		
		private string _Title;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnMultiMediaCodeChanging(int value);
    partial void OnMultiMediaCodeChanged();
    partial void OnPicFileChanging(string value);
    partial void OnPicFileChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    #endregion
		
		public MultiMediaPictures()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MultiMediaCode", DbType="Int NOT NULL")]
		public int MultiMediaCode
		{
			get
			{
				return this._MultiMediaCode;
			}
			set
			{
				if ((this._MultiMediaCode != value))
				{
					this.OnMultiMediaCodeChanging(value);
					this.SendPropertyChanging();
					this._MultiMediaCode = value;
					this.SendPropertyChanged("MultiMediaCode");
					this.OnMultiMediaCodeChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200)")]
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MultiMedias")]
	public partial class MultiMedias : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Title;
		
		private string _Description;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private string _PicFile;
		
		private string _LargePicFile;
		
		private System.Nullable<int> _HCPicTypeCode;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    partial void OnPicFileChanging(string value);
    partial void OnPicFileChanged();
    partial void OnLargePicFileChanging(string value);
    partial void OnLargePicFileChanged();
    partial void OnHCPicTypeCodeChanging(System.Nullable<int> value);
    partial void OnHCPicTypeCodeChanged();
    #endregion
		
		public MultiMedias()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LargePicFile", DbType="NVarChar(200)")]
		public string LargePicFile
		{
			get
			{
				return this._LargePicFile;
			}
			set
			{
				if ((this._LargePicFile != value))
				{
					this.OnLargePicFileChanging(value);
					this.SendPropertyChanging();
					this._LargePicFile = value;
					this.SendPropertyChanged("LargePicFile");
					this.OnLargePicFileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCPicTypeCode", DbType="Int")]
		public System.Nullable<int> HCPicTypeCode
		{
			get
			{
				return this._HCPicTypeCode;
			}
			set
			{
				if ((this._HCPicTypeCode != value))
				{
					this.OnHCPicTypeCodeChanging(value);
					this.SendPropertyChanging();
					this._HCPicTypeCode = value;
					this.SendPropertyChanged("HCPicTypeCode");
					this.OnHCPicTypeCodeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vMultiMedias")]
	public partial class vMultiMedias
	{
		
		private int _Code;
		
		private string _Title;
		
		private string _CDate;
		
		private string _PicType;
		
		private System.Nullable<int> _HCPicTypeCode;
		
		private string _LargePicFile;
		
		private string _PicFile;
		
		private string _Description;
		
		public vMultiMedias()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CDate", DbType="VarChar(10)")]
		public string CDate
		{
			get
			{
				return this._CDate;
			}
			set
			{
				if ((this._CDate != value))
				{
					this._CDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PicType", DbType="NVarChar(500)")]
		public string PicType
		{
			get
			{
				return this._PicType;
			}
			set
			{
				if ((this._PicType != value))
				{
					this._PicType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HCPicTypeCode", DbType="Int")]
		public System.Nullable<int> HCPicTypeCode
		{
			get
			{
				return this._HCPicTypeCode;
			}
			set
			{
				if ((this._HCPicTypeCode != value))
				{
					this._HCPicTypeCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LargePicFile", DbType="NVarChar(200)")]
		public string LargePicFile
		{
			get
			{
				return this._LargePicFile;
			}
			set
			{
				if ((this._LargePicFile != value))
				{
					this._LargePicFile = value;
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
					this._PicFile = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
