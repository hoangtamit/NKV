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

namespace QuanLySanXuat.LinqToSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="NKV")]
	public partial class DonHangTemVaiAveryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttbDonHangTemVaiAvery(tbDonHangTemVaiAvery instance);
    partial void UpdatetbDonHangTemVaiAvery(tbDonHangTemVaiAvery instance);
    partial void DeletetbDonHangTemVaiAvery(tbDonHangTemVaiAvery instance);
    #endregion
		
		public DonHangTemVaiAveryDataContext() : 
				base(global::QuanLySanXuat.Properties.Settings.Default.NKVConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public DonHangTemVaiAveryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DonHangTemVaiAveryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DonHangTemVaiAveryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DonHangTemVaiAveryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbDonHangTemVaiAvery> tbDonHangTemVaiAveries
		{
			get
			{
				return this.GetTable<tbDonHangTemVaiAvery>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbDonHangTemVaiAvery")]
	public partial class tbDonHangTemVaiAvery : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDDonHangTemVaiAvery;
		
		private string _Item;
		
		private string _SO;
		
		private string _XacNhan;
		
		private string _XacNhan2;
		
		private System.Nullable<int> _XacNhan3;
		
		private string _GhiChu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDDonHangTemVaiAveryChanging(string value);
    partial void OnIDDonHangTemVaiAveryChanged();
    partial void OnItemChanging(string value);
    partial void OnItemChanged();
    partial void OnSOChanging(string value);
    partial void OnSOChanged();
    partial void OnXacNhanChanging(string value);
    partial void OnXacNhanChanged();
    partial void OnXacNhan2Changing(string value);
    partial void OnXacNhan2Changed();
    partial void OnXacNhan3Changing(System.Nullable<int> value);
    partial void OnXacNhan3Changed();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public tbDonHangTemVaiAvery()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDDonHangTemVaiAvery", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDDonHangTemVaiAvery
		{
			get
			{
				return this._IDDonHangTemVaiAvery;
			}
			set
			{
				if ((this._IDDonHangTemVaiAvery != value))
				{
					this.OnIDDonHangTemVaiAveryChanging(value);
					this.SendPropertyChanging();
					this._IDDonHangTemVaiAvery = value;
					this.SendPropertyChanged("IDDonHangTemVaiAvery");
					this.OnIDDonHangTemVaiAveryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Item", DbType="NVarChar(50)")]
		public string Item
		{
			get
			{
				return this._Item;
			}
			set
			{
				if ((this._Item != value))
				{
					this.OnItemChanging(value);
					this.SendPropertyChanging();
					this._Item = value;
					this.SendPropertyChanged("Item");
					this.OnItemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SO", DbType="NVarChar(255)")]
		public string SO
		{
			get
			{
				return this._SO;
			}
			set
			{
				if ((this._SO != value))
				{
					this.OnSOChanging(value);
					this.SendPropertyChanging();
					this._SO = value;
					this.SendPropertyChanged("SO");
					this.OnSOChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XacNhan", DbType="NVarChar(50)")]
		public string XacNhan
		{
			get
			{
				return this._XacNhan;
			}
			set
			{
				if ((this._XacNhan != value))
				{
					this.OnXacNhanChanging(value);
					this.SendPropertyChanging();
					this._XacNhan = value;
					this.SendPropertyChanged("XacNhan");
					this.OnXacNhanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XacNhan2", DbType="NVarChar(50)")]
		public string XacNhan2
		{
			get
			{
				return this._XacNhan2;
			}
			set
			{
				if ((this._XacNhan2 != value))
				{
					this.OnXacNhan2Changing(value);
					this.SendPropertyChanging();
					this._XacNhan2 = value;
					this.SendPropertyChanged("XacNhan2");
					this.OnXacNhan2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_XacNhan3", DbType="Int")]
		public System.Nullable<int> XacNhan3
		{
			get
			{
				return this._XacNhan3;
			}
			set
			{
				if ((this._XacNhan3 != value))
				{
					this.OnXacNhan3Changing(value);
					this.SendPropertyChanging();
					this._XacNhan3 = value;
					this.SendPropertyChanged("XacNhan3");
					this.OnXacNhan3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(255)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
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
