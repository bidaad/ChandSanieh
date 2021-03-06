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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AceNewsDB")]
	public partial class ErrorLogsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertErrorLogs(ErrorLogs instance);
    partial void UpdateErrorLogs(ErrorLogs instance);
    partial void DeleteErrorLogs(ErrorLogs instance);
    partial void InsertExceptions(Exceptions instance);
    partial void UpdateExceptions(Exceptions instance);
    partial void DeleteExceptions(Exceptions instance);
    #endregion
		
		public ErrorLogsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["AceNewsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ErrorLogsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vErrorLogs> vErrorLogs
		{
			get
			{
				return this.GetTable<vErrorLogs>();
			}
		}
		
		public System.Data.Linq.Table<ErrorLogs> ErrorLogs
		{
			get
			{
				return this.GetTable<ErrorLogs>();
			}
		}
		
		public System.Data.Linq.Table<Exceptions> Exceptions
		{
			get
			{
				return this.GetTable<Exceptions>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vErrorLogs")]
	public partial class vErrorLogs
	{
		
		private int _Code;
		
		private string _Message;
		
		private System.Nullable<System.DateTime> _DateTime;
		
		public vErrorLogs()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="VarChar(1000)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this._Message = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this._DateTime = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ErrorLogs")]
	public partial class ErrorLogs : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Code;
		
		private string _Message;
		
		private System.Nullable<System.DateTime> _DateTime;
		
		private string _AbsolutePath;
		
		private string _QueryString;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(int value);
    partial void OnCodeChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    partial void OnDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDateTimeChanged();
    partial void OnAbsolutePathChanging(string value);
    partial void OnAbsolutePathChanged();
    partial void OnQueryStringChanging(string value);
    partial void OnQueryStringChanged();
    #endregion
		
		public ErrorLogs()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="VarChar(1000)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AbsolutePath", DbType="VarChar(200)")]
		public string AbsolutePath
		{
			get
			{
				return this._AbsolutePath;
			}
			set
			{
				if ((this._AbsolutePath != value))
				{
					this.OnAbsolutePathChanging(value);
					this.SendPropertyChanging();
					this._AbsolutePath = value;
					this.SendPropertyChanged("AbsolutePath");
					this.OnAbsolutePathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QueryString", DbType="VarChar(1000)")]
		public string QueryString
		{
			get
			{
				return this._QueryString;
			}
			set
			{
				if ((this._QueryString != value))
				{
					this.OnQueryStringChanging(value);
					this.SendPropertyChanging();
					this._QueryString = value;
					this.SendPropertyChanged("QueryString");
					this.OnQueryStringChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Exceptions")]
	public partial class Exceptions : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExceptionCode;
		
		private string _Data;
		
		private string _Message;
		
		private string _Source;
		
		private string _TargetSite;
		
		private string _StackTrace;
		
		private string _ExtraData;
		
		private System.Nullable<System.DateTime> _OccuredTime;
		
		private string _ClientIP;
		
		private string _ServerDomain;
		
		private string _CertificateThumbPrint;
		
		private System.Nullable<int> _UserCode;
		
		private System.Nullable<int> _SyncStatusType;
		
		private System.Nullable<int> _DataSourceType;
		
		private string _MyVersion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExceptionCodeChanging(int value);
    partial void OnExceptionCodeChanged();
    partial void OnDataChanging(string value);
    partial void OnDataChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    partial void OnSourceChanging(string value);
    partial void OnSourceChanged();
    partial void OnTargetSiteChanging(string value);
    partial void OnTargetSiteChanged();
    partial void OnStackTraceChanging(string value);
    partial void OnStackTraceChanged();
    partial void OnExtraDataChanging(string value);
    partial void OnExtraDataChanged();
    partial void OnOccuredTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnOccuredTimeChanged();
    partial void OnClientIPChanging(string value);
    partial void OnClientIPChanged();
    partial void OnServerDomainChanging(string value);
    partial void OnServerDomainChanged();
    partial void OnCertificateThumbPrintChanging(string value);
    partial void OnCertificateThumbPrintChanged();
    partial void OnUserCodeChanging(System.Nullable<int> value);
    partial void OnUserCodeChanged();
    partial void OnSyncStatusTypeChanging(System.Nullable<int> value);
    partial void OnSyncStatusTypeChanged();
    partial void OnDataSourceTypeChanging(System.Nullable<int> value);
    partial void OnDataSourceTypeChanged();
    partial void OnMyVersionChanging(string value);
    partial void OnMyVersionChanged();
    #endregion
		
		public Exceptions()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExceptionCode", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ExceptionCode
		{
			get
			{
				return this._ExceptionCode;
			}
			set
			{
				if ((this._ExceptionCode != value))
				{
					this.OnExceptionCodeChanging(value);
					this.SendPropertyChanging();
					this._ExceptionCode = value;
					this.SendPropertyChanged("ExceptionCode");
					this.OnExceptionCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="NVarChar(MAX)")]
		public string Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(MAX)")]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Source", DbType="NVarChar(MAX)")]
		public string Source
		{
			get
			{
				return this._Source;
			}
			set
			{
				if ((this._Source != value))
				{
					this.OnSourceChanging(value);
					this.SendPropertyChanging();
					this._Source = value;
					this.SendPropertyChanged("Source");
					this.OnSourceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TargetSite", DbType="NVarChar(MAX)")]
		public string TargetSite
		{
			get
			{
				return this._TargetSite;
			}
			set
			{
				if ((this._TargetSite != value))
				{
					this.OnTargetSiteChanging(value);
					this.SendPropertyChanging();
					this._TargetSite = value;
					this.SendPropertyChanged("TargetSite");
					this.OnTargetSiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StackTrace", DbType="NVarChar(MAX)")]
		public string StackTrace
		{
			get
			{
				return this._StackTrace;
			}
			set
			{
				if ((this._StackTrace != value))
				{
					this.OnStackTraceChanging(value);
					this.SendPropertyChanging();
					this._StackTrace = value;
					this.SendPropertyChanged("StackTrace");
					this.OnStackTraceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExtraData", DbType="NVarChar(MAX)")]
		public string ExtraData
		{
			get
			{
				return this._ExtraData;
			}
			set
			{
				if ((this._ExtraData != value))
				{
					this.OnExtraDataChanging(value);
					this.SendPropertyChanging();
					this._ExtraData = value;
					this.SendPropertyChanged("ExtraData");
					this.OnExtraDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OccuredTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> OccuredTime
		{
			get
			{
				return this._OccuredTime;
			}
			set
			{
				if ((this._OccuredTime != value))
				{
					this.OnOccuredTimeChanging(value);
					this.SendPropertyChanging();
					this._OccuredTime = value;
					this.SendPropertyChanged("OccuredTime");
					this.OnOccuredTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientIP", DbType="NVarChar(16)")]
		public string ClientIP
		{
			get
			{
				return this._ClientIP;
			}
			set
			{
				if ((this._ClientIP != value))
				{
					this.OnClientIPChanging(value);
					this.SendPropertyChanging();
					this._ClientIP = value;
					this.SendPropertyChanged("ClientIP");
					this.OnClientIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ServerDomain", DbType="NVarChar(200)")]
		public string ServerDomain
		{
			get
			{
				return this._ServerDomain;
			}
			set
			{
				if ((this._ServerDomain != value))
				{
					this.OnServerDomainChanging(value);
					this.SendPropertyChanging();
					this._ServerDomain = value;
					this.SendPropertyChanged("ServerDomain");
					this.OnServerDomainChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CertificateThumbPrint", DbType="NVarChar(MAX)")]
		public string CertificateThumbPrint
		{
			get
			{
				return this._CertificateThumbPrint;
			}
			set
			{
				if ((this._CertificateThumbPrint != value))
				{
					this.OnCertificateThumbPrintChanging(value);
					this.SendPropertyChanging();
					this._CertificateThumbPrint = value;
					this.SendPropertyChanged("CertificateThumbPrint");
					this.OnCertificateThumbPrintChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserCode", DbType="Int")]
		public System.Nullable<int> UserCode
		{
			get
			{
				return this._UserCode;
			}
			set
			{
				if ((this._UserCode != value))
				{
					this.OnUserCodeChanging(value);
					this.SendPropertyChanging();
					this._UserCode = value;
					this.SendPropertyChanged("UserCode");
					this.OnUserCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SyncStatusType", DbType="Int")]
		public System.Nullable<int> SyncStatusType
		{
			get
			{
				return this._SyncStatusType;
			}
			set
			{
				if ((this._SyncStatusType != value))
				{
					this.OnSyncStatusTypeChanging(value);
					this.SendPropertyChanging();
					this._SyncStatusType = value;
					this.SendPropertyChanged("SyncStatusType");
					this.OnSyncStatusTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataSourceType", DbType="Int")]
		public System.Nullable<int> DataSourceType
		{
			get
			{
				return this._DataSourceType;
			}
			set
			{
				if ((this._DataSourceType != value))
				{
					this.OnDataSourceTypeChanging(value);
					this.SendPropertyChanging();
					this._DataSourceType = value;
					this.SendPropertyChanged("DataSourceType");
					this.OnDataSourceTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MyVersion", DbType="NVarChar(50)")]
		public string MyVersion
		{
			get
			{
				return this._MyVersion;
			}
			set
			{
				if ((this._MyVersion != value))
				{
					this.OnMyVersionChanging(value);
					this.SendPropertyChanging();
					this._MyVersion = value;
					this.SendPropertyChanged("MyVersion");
					this.OnMyVersionChanged();
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
