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

namespace BantuanRumahLayakHuni.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_SPK_PBRLH")]
	public partial class DB_SPK_PBRLHDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTBL_M_CALON_PENERIMA(TBL_M_CALON_PENERIMA instance);
    partial void UpdateTBL_M_CALON_PENERIMA(TBL_M_CALON_PENERIMA instance);
    partial void DeleteTBL_M_CALON_PENERIMA(TBL_M_CALON_PENERIMA instance);
    partial void InsertTBL_M_KRITERIA(TBL_M_KRITERIA instance);
    partial void UpdateTBL_M_KRITERIA(TBL_M_KRITERIA instance);
    partial void DeleteTBL_M_KRITERIA(TBL_M_KRITERIA instance);
    partial void InsertTBL_M_KRITERIA_DETAIL(TBL_M_KRITERIA_DETAIL instance);
    partial void UpdateTBL_M_KRITERIA_DETAIL(TBL_M_KRITERIA_DETAIL instance);
    partial void DeleteTBL_M_KRITERIA_DETAIL(TBL_M_KRITERIA_DETAIL instance);
    partial void InsertTBL_T_HASIL(TBL_T_HASIL instance);
    partial void UpdateTBL_T_HASIL(TBL_T_HASIL instance);
    partial void DeleteTBL_T_HASIL(TBL_T_HASIL instance);
    partial void InsertTBL_T_KRITERIA(TBL_T_KRITERIA instance);
    partial void UpdateTBL_T_KRITERIA(TBL_T_KRITERIA instance);
    partial void DeleteTBL_T_KRITERIA(TBL_T_KRITERIA instance);
    partial void InsertTBL_T_LOGIN(TBL_T_LOGIN instance);
    partial void UpdateTBL_T_LOGIN(TBL_T_LOGIN instance);
    partial void DeleteTBL_T_LOGIN(TBL_T_LOGIN instance);
    #endregion
		
		public DB_SPK_PBRLHDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DB_SPK_PBRLHDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DB_SPK_PBRLHDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DB_SPK_PBRLHDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TBL_M_CALON_PENERIMA> TBL_M_CALON_PENERIMAs
		{
			get
			{
				return this.GetTable<TBL_M_CALON_PENERIMA>();
			}
		}
		
		public System.Data.Linq.Table<TBL_M_KRITERIA> TBL_M_KRITERIAs
		{
			get
			{
				return this.GetTable<TBL_M_KRITERIA>();
			}
		}
		
		public System.Data.Linq.Table<TBL_M_KRITERIA_DETAIL> TBL_M_KRITERIA_DETAILs
		{
			get
			{
				return this.GetTable<TBL_M_KRITERIA_DETAIL>();
			}
		}
		
		public System.Data.Linq.Table<TBL_T_HASIL> TBL_T_HASILs
		{
			get
			{
				return this.GetTable<TBL_T_HASIL>();
			}
		}
		
		public System.Data.Linq.Table<TBL_T_KRITERIA> TBL_T_KRITERIAs
		{
			get
			{
				return this.GetTable<TBL_T_KRITERIA>();
			}
		}
		
		public System.Data.Linq.Table<VW_REKOMENDASI_SAW> VW_REKOMENDASI_SAWs
		{
			get
			{
				return this.GetTable<VW_REKOMENDASI_SAW>();
			}
		}
		
		public System.Data.Linq.Table<TBL_T_LOGIN> TBL_T_LOGINs
		{
			get
			{
				return this.GetTable<TBL_T_LOGIN>();
			}
		}
		
		public System.Data.Linq.Table<VW_NILAI_KRITERIA> VW_NILAI_KRITERIAs
		{
			get
			{
				return this.GetTable<VW_NILAI_KRITERIA>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_M_CALON_PENERIMA")]
	public partial class TBL_M_CALON_PENERIMA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NAMA;
		
		private string _JENIS_KELAMIN;
		
		private string _ALAMAT;
		
		private System.Nullable<int> _USIA;
		
		private EntityRef<TBL_T_HASIL> _TBL_T_HASIL;
		
		private EntitySet<TBL_T_KRITERIA> _TBL_T_KRITERIAs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNAMAChanging(string value);
    partial void OnNAMAChanged();
    partial void OnJENIS_KELAMINChanging(string value);
    partial void OnJENIS_KELAMINChanged();
    partial void OnALAMATChanging(string value);
    partial void OnALAMATChanged();
    partial void OnUSIAChanging(System.Nullable<int> value);
    partial void OnUSIAChanged();
    #endregion
		
		public TBL_M_CALON_PENERIMA()
		{
			this._TBL_T_HASIL = default(EntityRef<TBL_T_HASIL>);
			this._TBL_T_KRITERIAs = new EntitySet<TBL_T_KRITERIA>(new Action<TBL_T_KRITERIA>(this.attach_TBL_T_KRITERIAs), new Action<TBL_T_KRITERIA>(this.detach_TBL_T_KRITERIAs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMA", DbType="VarChar(50)")]
		public string NAMA
		{
			get
			{
				return this._NAMA;
			}
			set
			{
				if ((this._NAMA != value))
				{
					this.OnNAMAChanging(value);
					this.SendPropertyChanging();
					this._NAMA = value;
					this.SendPropertyChanged("NAMA");
					this.OnNAMAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JENIS_KELAMIN", DbType="VarChar(1)")]
		public string JENIS_KELAMIN
		{
			get
			{
				return this._JENIS_KELAMIN;
			}
			set
			{
				if ((this._JENIS_KELAMIN != value))
				{
					this.OnJENIS_KELAMINChanging(value);
					this.SendPropertyChanging();
					this._JENIS_KELAMIN = value;
					this.SendPropertyChanged("JENIS_KELAMIN");
					this.OnJENIS_KELAMINChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALAMAT", DbType="VarChar(100)")]
		public string ALAMAT
		{
			get
			{
				return this._ALAMAT;
			}
			set
			{
				if ((this._ALAMAT != value))
				{
					this.OnALAMATChanging(value);
					this.SendPropertyChanging();
					this._ALAMAT = value;
					this.SendPropertyChanged("ALAMAT");
					this.OnALAMATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USIA", DbType="Int")]
		public System.Nullable<int> USIA
		{
			get
			{
				return this._USIA;
			}
			set
			{
				if ((this._USIA != value))
				{
					this.OnUSIAChanging(value);
					this.SendPropertyChanging();
					this._USIA = value;
					this.SendPropertyChanged("USIA");
					this.OnUSIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_CALON_PENERIMA_TBL_T_HASIL", Storage="_TBL_T_HASIL", ThisKey="ID", OtherKey="ID_CALON_PENERIMA", IsUnique=true, IsForeignKey=false)]
		public TBL_T_HASIL TBL_T_HASIL
		{
			get
			{
				return this._TBL_T_HASIL.Entity;
			}
			set
			{
				TBL_T_HASIL previousValue = this._TBL_T_HASIL.Entity;
				if (((previousValue != value) 
							|| (this._TBL_T_HASIL.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBL_T_HASIL.Entity = null;
						previousValue.TBL_M_CALON_PENERIMA = null;
					}
					this._TBL_T_HASIL.Entity = value;
					if ((value != null))
					{
						value.TBL_M_CALON_PENERIMA = this;
					}
					this.SendPropertyChanged("TBL_T_HASIL");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_CALON_PENERIMA_TBL_T_KRITERIA", Storage="_TBL_T_KRITERIAs", ThisKey="ID", OtherKey="ID_CALON_PENERIMA")]
		public EntitySet<TBL_T_KRITERIA> TBL_T_KRITERIAs
		{
			get
			{
				return this._TBL_T_KRITERIAs;
			}
			set
			{
				this._TBL_T_KRITERIAs.Assign(value);
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
		
		private void attach_TBL_T_KRITERIAs(TBL_T_KRITERIA entity)
		{
			this.SendPropertyChanging();
			entity.TBL_M_CALON_PENERIMA = this;
		}
		
		private void detach_TBL_T_KRITERIAs(TBL_T_KRITERIA entity)
		{
			this.SendPropertyChanging();
			entity.TBL_M_CALON_PENERIMA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_M_KRITERIA")]
	public partial class TBL_M_KRITERIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _KRITERIA;
		
		private string _SIFAT;
		
		private System.Nullable<int> _BOBOT;
		
		private EntitySet<TBL_M_KRITERIA_DETAIL> _TBL_M_KRITERIA_DETAILs;
		
		private EntitySet<TBL_T_KRITERIA> _TBL_T_KRITERIAs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnKRITERIAChanging(string value);
    partial void OnKRITERIAChanged();
    partial void OnSIFATChanging(string value);
    partial void OnSIFATChanged();
    partial void OnBOBOTChanging(System.Nullable<int> value);
    partial void OnBOBOTChanged();
    #endregion
		
		public TBL_M_KRITERIA()
		{
			this._TBL_M_KRITERIA_DETAILs = new EntitySet<TBL_M_KRITERIA_DETAIL>(new Action<TBL_M_KRITERIA_DETAIL>(this.attach_TBL_M_KRITERIA_DETAILs), new Action<TBL_M_KRITERIA_DETAIL>(this.detach_TBL_M_KRITERIA_DETAILs));
			this._TBL_T_KRITERIAs = new EntitySet<TBL_T_KRITERIA>(new Action<TBL_T_KRITERIA>(this.attach_TBL_T_KRITERIAs), new Action<TBL_T_KRITERIA>(this.detach_TBL_T_KRITERIAs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KRITERIA", DbType="VarChar(50)")]
		public string KRITERIA
		{
			get
			{
				return this._KRITERIA;
			}
			set
			{
				if ((this._KRITERIA != value))
				{
					this.OnKRITERIAChanging(value);
					this.SendPropertyChanging();
					this._KRITERIA = value;
					this.SendPropertyChanged("KRITERIA");
					this.OnKRITERIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SIFAT", DbType="VarChar(50)")]
		public string SIFAT
		{
			get
			{
				return this._SIFAT;
			}
			set
			{
				if ((this._SIFAT != value))
				{
					this.OnSIFATChanging(value);
					this.SendPropertyChanging();
					this._SIFAT = value;
					this.SendPropertyChanged("SIFAT");
					this.OnSIFATChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BOBOT", DbType="Int")]
		public System.Nullable<int> BOBOT
		{
			get
			{
				return this._BOBOT;
			}
			set
			{
				if ((this._BOBOT != value))
				{
					this.OnBOBOTChanging(value);
					this.SendPropertyChanging();
					this._BOBOT = value;
					this.SendPropertyChanged("BOBOT");
					this.OnBOBOTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_KRITERIA_TBL_M_KRITERIA_DETAIL", Storage="_TBL_M_KRITERIA_DETAILs", ThisKey="ID", OtherKey="ID_KRITERIA")]
		public EntitySet<TBL_M_KRITERIA_DETAIL> TBL_M_KRITERIA_DETAILs
		{
			get
			{
				return this._TBL_M_KRITERIA_DETAILs;
			}
			set
			{
				this._TBL_M_KRITERIA_DETAILs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_KRITERIA_TBL_T_KRITERIA", Storage="_TBL_T_KRITERIAs", ThisKey="ID", OtherKey="ID_KRITERIA")]
		public EntitySet<TBL_T_KRITERIA> TBL_T_KRITERIAs
		{
			get
			{
				return this._TBL_T_KRITERIAs;
			}
			set
			{
				this._TBL_T_KRITERIAs.Assign(value);
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
		
		private void attach_TBL_M_KRITERIA_DETAILs(TBL_M_KRITERIA_DETAIL entity)
		{
			this.SendPropertyChanging();
			entity.TBL_M_KRITERIA = this;
		}
		
		private void detach_TBL_M_KRITERIA_DETAILs(TBL_M_KRITERIA_DETAIL entity)
		{
			this.SendPropertyChanging();
			entity.TBL_M_KRITERIA = null;
		}
		
		private void attach_TBL_T_KRITERIAs(TBL_T_KRITERIA entity)
		{
			this.SendPropertyChanging();
			entity.TBL_M_KRITERIA = this;
		}
		
		private void detach_TBL_T_KRITERIAs(TBL_T_KRITERIA entity)
		{
			this.SendPropertyChanging();
			entity.TBL_M_KRITERIA = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_M_KRITERIA_DETAIL")]
	public partial class TBL_M_KRITERIA_DETAIL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _ID_KRITERIA;
		
		private string _DETAIL;
		
		private System.Nullable<int> _NILAI;
		
		private EntityRef<TBL_M_KRITERIA> _TBL_M_KRITERIA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnID_KRITERIAChanging(int value);
    partial void OnID_KRITERIAChanged();
    partial void OnDETAILChanging(string value);
    partial void OnDETAILChanged();
    partial void OnNILAIChanging(System.Nullable<int> value);
    partial void OnNILAIChanged();
    #endregion
		
		public TBL_M_KRITERIA_DETAIL()
		{
			this._TBL_M_KRITERIA = default(EntityRef<TBL_M_KRITERIA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_KRITERIA", DbType="Int NOT NULL")]
		public int ID_KRITERIA
		{
			get
			{
				return this._ID_KRITERIA;
			}
			set
			{
				if ((this._ID_KRITERIA != value))
				{
					if (this._TBL_M_KRITERIA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_KRITERIAChanging(value);
					this.SendPropertyChanging();
					this._ID_KRITERIA = value;
					this.SendPropertyChanged("ID_KRITERIA");
					this.OnID_KRITERIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DETAIL", DbType="VarChar(50)")]
		public string DETAIL
		{
			get
			{
				return this._DETAIL;
			}
			set
			{
				if ((this._DETAIL != value))
				{
					this.OnDETAILChanging(value);
					this.SendPropertyChanging();
					this._DETAIL = value;
					this.SendPropertyChanged("DETAIL");
					this.OnDETAILChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NILAI", DbType="Int")]
		public System.Nullable<int> NILAI
		{
			get
			{
				return this._NILAI;
			}
			set
			{
				if ((this._NILAI != value))
				{
					this.OnNILAIChanging(value);
					this.SendPropertyChanging();
					this._NILAI = value;
					this.SendPropertyChanged("NILAI");
					this.OnNILAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_KRITERIA_TBL_M_KRITERIA_DETAIL", Storage="_TBL_M_KRITERIA", ThisKey="ID_KRITERIA", OtherKey="ID", IsForeignKey=true)]
		public TBL_M_KRITERIA TBL_M_KRITERIA
		{
			get
			{
				return this._TBL_M_KRITERIA.Entity;
			}
			set
			{
				TBL_M_KRITERIA previousValue = this._TBL_M_KRITERIA.Entity;
				if (((previousValue != value) 
							|| (this._TBL_M_KRITERIA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBL_M_KRITERIA.Entity = null;
						previousValue.TBL_M_KRITERIA_DETAILs.Remove(this);
					}
					this._TBL_M_KRITERIA.Entity = value;
					if ((value != null))
					{
						value.TBL_M_KRITERIA_DETAILs.Add(this);
						this._ID_KRITERIA = value.ID;
					}
					else
					{
						this._ID_KRITERIA = default(int);
					}
					this.SendPropertyChanged("TBL_M_KRITERIA");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_T_HASIL")]
	public partial class TBL_T_HASIL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_CALON_PENERIMA;
		
		private System.Nullable<double> _TOTAL_NILAI;
		
		private EntityRef<TBL_M_CALON_PENERIMA> _TBL_M_CALON_PENERIMA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_CALON_PENERIMAChanging(int value);
    partial void OnID_CALON_PENERIMAChanged();
    partial void OnTOTAL_NILAIChanging(System.Nullable<double> value);
    partial void OnTOTAL_NILAIChanged();
    #endregion
		
		public TBL_T_HASIL()
		{
			this._TBL_M_CALON_PENERIMA = default(EntityRef<TBL_M_CALON_PENERIMA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_CALON_PENERIMA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_CALON_PENERIMA
		{
			get
			{
				return this._ID_CALON_PENERIMA;
			}
			set
			{
				if ((this._ID_CALON_PENERIMA != value))
				{
					if (this._TBL_M_CALON_PENERIMA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_CALON_PENERIMAChanging(value);
					this.SendPropertyChanging();
					this._ID_CALON_PENERIMA = value;
					this.SendPropertyChanged("ID_CALON_PENERIMA");
					this.OnID_CALON_PENERIMAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL_NILAI", DbType="Float")]
		public System.Nullable<double> TOTAL_NILAI
		{
			get
			{
				return this._TOTAL_NILAI;
			}
			set
			{
				if ((this._TOTAL_NILAI != value))
				{
					this.OnTOTAL_NILAIChanging(value);
					this.SendPropertyChanging();
					this._TOTAL_NILAI = value;
					this.SendPropertyChanged("TOTAL_NILAI");
					this.OnTOTAL_NILAIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_CALON_PENERIMA_TBL_T_HASIL", Storage="_TBL_M_CALON_PENERIMA", ThisKey="ID_CALON_PENERIMA", OtherKey="ID", IsForeignKey=true)]
		public TBL_M_CALON_PENERIMA TBL_M_CALON_PENERIMA
		{
			get
			{
				return this._TBL_M_CALON_PENERIMA.Entity;
			}
			set
			{
				TBL_M_CALON_PENERIMA previousValue = this._TBL_M_CALON_PENERIMA.Entity;
				if (((previousValue != value) 
							|| (this._TBL_M_CALON_PENERIMA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBL_M_CALON_PENERIMA.Entity = null;
						previousValue.TBL_T_HASIL = null;
					}
					this._TBL_M_CALON_PENERIMA.Entity = value;
					if ((value != null))
					{
						value.TBL_T_HASIL = this;
						this._ID_CALON_PENERIMA = value.ID;
					}
					else
					{
						this._ID_CALON_PENERIMA = default(int);
					}
					this.SendPropertyChanged("TBL_M_CALON_PENERIMA");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_T_KRITERIA")]
	public partial class TBL_T_KRITERIA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_KRITERIA;
		
		private int _ID_CALON_PENERIMA;
		
		private System.Nullable<int> _NILAI_KRITERIA;
		
		private EntityRef<TBL_M_CALON_PENERIMA> _TBL_M_CALON_PENERIMA;
		
		private EntityRef<TBL_M_KRITERIA> _TBL_M_KRITERIA;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_KRITERIAChanging(int value);
    partial void OnID_KRITERIAChanged();
    partial void OnID_CALON_PENERIMAChanging(int value);
    partial void OnID_CALON_PENERIMAChanged();
    partial void OnNILAI_KRITERIAChanging(System.Nullable<int> value);
    partial void OnNILAI_KRITERIAChanged();
    #endregion
		
		public TBL_T_KRITERIA()
		{
			this._TBL_M_CALON_PENERIMA = default(EntityRef<TBL_M_CALON_PENERIMA>);
			this._TBL_M_KRITERIA = default(EntityRef<TBL_M_KRITERIA>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_KRITERIA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_KRITERIA
		{
			get
			{
				return this._ID_KRITERIA;
			}
			set
			{
				if ((this._ID_KRITERIA != value))
				{
					if (this._TBL_M_KRITERIA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_KRITERIAChanging(value);
					this.SendPropertyChanging();
					this._ID_KRITERIA = value;
					this.SendPropertyChanged("ID_KRITERIA");
					this.OnID_KRITERIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_CALON_PENERIMA", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID_CALON_PENERIMA
		{
			get
			{
				return this._ID_CALON_PENERIMA;
			}
			set
			{
				if ((this._ID_CALON_PENERIMA != value))
				{
					if (this._TBL_M_CALON_PENERIMA.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_CALON_PENERIMAChanging(value);
					this.SendPropertyChanging();
					this._ID_CALON_PENERIMA = value;
					this.SendPropertyChanged("ID_CALON_PENERIMA");
					this.OnID_CALON_PENERIMAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NILAI_KRITERIA", DbType="Int")]
		public System.Nullable<int> NILAI_KRITERIA
		{
			get
			{
				return this._NILAI_KRITERIA;
			}
			set
			{
				if ((this._NILAI_KRITERIA != value))
				{
					this.OnNILAI_KRITERIAChanging(value);
					this.SendPropertyChanging();
					this._NILAI_KRITERIA = value;
					this.SendPropertyChanged("NILAI_KRITERIA");
					this.OnNILAI_KRITERIAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_CALON_PENERIMA_TBL_T_KRITERIA", Storage="_TBL_M_CALON_PENERIMA", ThisKey="ID_CALON_PENERIMA", OtherKey="ID", IsForeignKey=true)]
		public TBL_M_CALON_PENERIMA TBL_M_CALON_PENERIMA
		{
			get
			{
				return this._TBL_M_CALON_PENERIMA.Entity;
			}
			set
			{
				TBL_M_CALON_PENERIMA previousValue = this._TBL_M_CALON_PENERIMA.Entity;
				if (((previousValue != value) 
							|| (this._TBL_M_CALON_PENERIMA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBL_M_CALON_PENERIMA.Entity = null;
						previousValue.TBL_T_KRITERIAs.Remove(this);
					}
					this._TBL_M_CALON_PENERIMA.Entity = value;
					if ((value != null))
					{
						value.TBL_T_KRITERIAs.Add(this);
						this._ID_CALON_PENERIMA = value.ID;
					}
					else
					{
						this._ID_CALON_PENERIMA = default(int);
					}
					this.SendPropertyChanged("TBL_M_CALON_PENERIMA");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TBL_M_KRITERIA_TBL_T_KRITERIA", Storage="_TBL_M_KRITERIA", ThisKey="ID_KRITERIA", OtherKey="ID", IsForeignKey=true)]
		public TBL_M_KRITERIA TBL_M_KRITERIA
		{
			get
			{
				return this._TBL_M_KRITERIA.Entity;
			}
			set
			{
				TBL_M_KRITERIA previousValue = this._TBL_M_KRITERIA.Entity;
				if (((previousValue != value) 
							|| (this._TBL_M_KRITERIA.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TBL_M_KRITERIA.Entity = null;
						previousValue.TBL_T_KRITERIAs.Remove(this);
					}
					this._TBL_M_KRITERIA.Entity = value;
					if ((value != null))
					{
						value.TBL_T_KRITERIAs.Add(this);
						this._ID_KRITERIA = value.ID;
					}
					else
					{
						this._ID_KRITERIA = default(int);
					}
					this.SendPropertyChanged("TBL_M_KRITERIA");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VW_REKOMENDASI_SAW")]
	public partial class VW_REKOMENDASI_SAW
	{
		
		private int _ID_CALON_PENERIMA;
		
		private System.Nullable<double> _TOTAL_NILAI;
		
		private string _NAMA;
		
		private string _JENIS_KELAMIN;
		
		private System.Nullable<int> _USIA;
		
		private System.Nullable<long> _Rank;
		
		public VW_REKOMENDASI_SAW()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_CALON_PENERIMA", DbType="Int NOT NULL")]
		public int ID_CALON_PENERIMA
		{
			get
			{
				return this._ID_CALON_PENERIMA;
			}
			set
			{
				if ((this._ID_CALON_PENERIMA != value))
				{
					this._ID_CALON_PENERIMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TOTAL_NILAI", DbType="Float")]
		public System.Nullable<double> TOTAL_NILAI
		{
			get
			{
				return this._TOTAL_NILAI;
			}
			set
			{
				if ((this._TOTAL_NILAI != value))
				{
					this._TOTAL_NILAI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMA", DbType="VarChar(50)")]
		public string NAMA
		{
			get
			{
				return this._NAMA;
			}
			set
			{
				if ((this._NAMA != value))
				{
					this._NAMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JENIS_KELAMIN", DbType="VarChar(1)")]
		public string JENIS_KELAMIN
		{
			get
			{
				return this._JENIS_KELAMIN;
			}
			set
			{
				if ((this._JENIS_KELAMIN != value))
				{
					this._JENIS_KELAMIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USIA", DbType="Int")]
		public System.Nullable<int> USIA
		{
			get
			{
				return this._USIA;
			}
			set
			{
				if ((this._USIA != value))
				{
					this._USIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank", DbType="BigInt")]
		public System.Nullable<long> Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this._Rank = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TBL_T_LOGIN")]
	public partial class TBL_T_LOGIN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _email;
		
		private string _password;
		
		private string _nama;
		
		private System.Nullable<System.DateTime> _tanggal_lahir;
		
		private string _alamat;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnnamaChanging(string value);
    partial void OnnamaChanged();
    partial void Ontanggal_lahirChanging(System.Nullable<System.DateTime> value);
    partial void Ontanggal_lahirChanged();
    partial void OnalamatChanging(string value);
    partial void OnalamatChanged();
    #endregion
		
		public TBL_T_LOGIN()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nama", DbType="VarChar(50)")]
		public string nama
		{
			get
			{
				return this._nama;
			}
			set
			{
				if ((this._nama != value))
				{
					this.OnnamaChanging(value);
					this.SendPropertyChanging();
					this._nama = value;
					this.SendPropertyChanged("nama");
					this.OnnamaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tanggal_lahir", DbType="Date")]
		public System.Nullable<System.DateTime> tanggal_lahir
		{
			get
			{
				return this._tanggal_lahir;
			}
			set
			{
				if ((this._tanggal_lahir != value))
				{
					this.Ontanggal_lahirChanging(value);
					this.SendPropertyChanging();
					this._tanggal_lahir = value;
					this.SendPropertyChanged("tanggal_lahir");
					this.Ontanggal_lahirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alamat", DbType="VarChar(50)")]
		public string alamat
		{
			get
			{
				return this._alamat;
			}
			set
			{
				if ((this._alamat != value))
				{
					this.OnalamatChanging(value);
					this.SendPropertyChanging();
					this._alamat = value;
					this.SendPropertyChanged("alamat");
					this.OnalamatChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.VW_NILAI_KRITERIA")]
	public partial class VW_NILAI_KRITERIA
	{
		
		private int _ID_KRITERIA;
		
		private int _ID_CALON_PENERIMA;
		
		private System.Nullable<int> _NILAI_KRITERIA;
		
		private string _NAMA;
		
		private string _JENIS_KELAMIN;
		
		private System.Nullable<int> _USIA;
		
		private string _ALAMAT;
		
		public VW_NILAI_KRITERIA()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_KRITERIA", DbType="Int NOT NULL")]
		public int ID_KRITERIA
		{
			get
			{
				return this._ID_KRITERIA;
			}
			set
			{
				if ((this._ID_KRITERIA != value))
				{
					this._ID_KRITERIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_CALON_PENERIMA", DbType="Int NOT NULL")]
		public int ID_CALON_PENERIMA
		{
			get
			{
				return this._ID_CALON_PENERIMA;
			}
			set
			{
				if ((this._ID_CALON_PENERIMA != value))
				{
					this._ID_CALON_PENERIMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NILAI_KRITERIA", DbType="Int")]
		public System.Nullable<int> NILAI_KRITERIA
		{
			get
			{
				return this._NILAI_KRITERIA;
			}
			set
			{
				if ((this._NILAI_KRITERIA != value))
				{
					this._NILAI_KRITERIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMA", DbType="VarChar(50)")]
		public string NAMA
		{
			get
			{
				return this._NAMA;
			}
			set
			{
				if ((this._NAMA != value))
				{
					this._NAMA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JENIS_KELAMIN", DbType="VarChar(1)")]
		public string JENIS_KELAMIN
		{
			get
			{
				return this._JENIS_KELAMIN;
			}
			set
			{
				if ((this._JENIS_KELAMIN != value))
				{
					this._JENIS_KELAMIN = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USIA", DbType="Int")]
		public System.Nullable<int> USIA
		{
			get
			{
				return this._USIA;
			}
			set
			{
				if ((this._USIA != value))
				{
					this._USIA = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ALAMAT", DbType="VarChar(100)")]
		public string ALAMAT
		{
			get
			{
				return this._ALAMAT;
			}
			set
			{
				if ((this._ALAMAT != value))
				{
					this._ALAMAT = value;
				}
			}
		}
	}
}
#pragma warning restore 1591