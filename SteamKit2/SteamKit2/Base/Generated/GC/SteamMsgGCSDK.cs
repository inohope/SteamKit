//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: gcsdk_gcmessages.proto
// Note: requires additional types generated from: steammessages.proto
namespace SteamKit2.GC.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOIDOwner")]
  public partial class CMsgSOIDOwner : global::ProtoBuf.IExtensible
  {
    public CMsgSOIDOwner() {}
    

    private uint _type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }

    private ulong _id = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOSingleObject")]
  public partial class CMsgSOSingleObject : global::ProtoBuf.IExtensible
  {
    public CMsgSOSingleObject() {}
    

    private int _type_id = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }

    private byte[] _object_data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"object_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] object_data
    {
      get { return _object_data; }
      set { _object_data = value; }
    }

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }

    private CMsgSOIDOwner _owner_soid = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"owner_soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner owner_soid
    {
      get { return _owner_soid; }
      set { _owner_soid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOMultipleObjects")]
  public partial class CMsgSOMultipleObjects : global::ProtoBuf.IExtensible
  {
    public CMsgSOMultipleObjects() {}
    
    private readonly global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> _objects_modified = new global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject>();
    [global::ProtoBuf.ProtoMember(2, Name=@"objects_modified", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> objects_modified
    {
      get { return _objects_modified; }
    }
  

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> _objects_added = new global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject>();
    [global::ProtoBuf.ProtoMember(4, Name=@"objects_added", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> objects_added
    {
      get { return _objects_added; }
    }
  
    private readonly global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> _objects_removed = new global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject>();
    [global::ProtoBuf.ProtoMember(5, Name=@"objects_removed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOMultipleObjects.SingleObject> objects_removed
    {
      get { return _objects_removed; }
    }
  

    private CMsgSOIDOwner _owner_soid = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"owner_soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner owner_soid
    {
      get { return _owner_soid; }
      set { _owner_soid = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SingleObject")]
  public partial class SingleObject : global::ProtoBuf.IExtensible
  {
    public SingleObject() {}
    

    private int _type_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }

    private byte[] _object_data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"object_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] object_data
    {
      get { return _object_data; }
      set { _object_data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheSubscribed")]
  public partial class CMsgSOCacheSubscribed : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheSubscribed() {}
    
    private readonly global::System.Collections.Generic.List<CMsgSOCacheSubscribed.SubscribedType> _objects = new global::System.Collections.Generic.List<CMsgSOCacheSubscribed.SubscribedType>();
    [global::ProtoBuf.ProtoMember(2, Name=@"objects", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOCacheSubscribed.SubscribedType> objects
    {
      get { return _objects; }
    }
  

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }

    private CMsgSOIDOwner _owner_soid = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"owner_soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner owner_soid
    {
      get { return _owner_soid; }
      set { _owner_soid = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubscribedType")]
  public partial class SubscribedType : global::ProtoBuf.IExtensible
  {
    public SubscribedType() {}
    

    private int _type_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int type_id
    {
      get { return _type_id; }
      set { _type_id = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _object_data = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(2, Name=@"object_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> object_data
    {
      get { return _object_data; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheUnsubscribed")]
  public partial class CMsgSOCacheUnsubscribed : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheUnsubscribed() {}
    

    private CMsgSOIDOwner _owner_soid = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"owner_soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner owner_soid
    {
      get { return _owner_soid; }
      set { _owner_soid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheSubscriptionCheck")]
  public partial class CMsgSOCacheSubscriptionCheck : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheSubscriptionCheck() {}
    

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }

    private CMsgSOIDOwner _owner_soid = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"owner_soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner owner_soid
    {
      get { return _owner_soid; }
      set { _owner_soid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheSubscriptionRefresh")]
  public partial class CMsgSOCacheSubscriptionRefresh : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheSubscriptionRefresh() {}
    

    private CMsgSOIDOwner _owner_soid = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"owner_soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner owner_soid
    {
      get { return _owner_soid; }
      set { _owner_soid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheVersion")]
  public partial class CMsgSOCacheVersion : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheVersion() {}
    

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgAccountDetails")]
  public partial class CMsgAccountDetails : global::ProtoBuf.IExtensible
  {
    public CMsgAccountDetails() {}
    

    private bool _valid = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool valid
    {
      get { return _valid; }
      set { _valid = value; }
    }

    private string _account_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"account_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string account_name
    {
      get { return _account_name; }
      set { _account_name = value; }
    }

    private bool _public_profile = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"public_profile", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool public_profile
    {
      get { return _public_profile; }
      set { _public_profile = value; }
    }

    private bool _public_inventory = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"public_inventory", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool public_inventory
    {
      get { return _public_inventory; }
      set { _public_inventory = value; }
    }

    private bool _vac_banned = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"vac_banned", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool vac_banned
    {
      get { return _vac_banned; }
      set { _vac_banned = value; }
    }

    private bool _cyber_cafe = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"cyber_cafe", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool cyber_cafe
    {
      get { return _cyber_cafe; }
      set { _cyber_cafe = value; }
    }

    private bool _school_account = default(bool);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"school_account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool school_account
    {
      get { return _school_account; }
      set { _school_account = value; }
    }

    private bool _free_trial_account = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"free_trial_account", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool free_trial_account
    {
      get { return _free_trial_account; }
      set { _free_trial_account = value; }
    }

    private bool _subscribed = default(bool);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"subscribed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool subscribed
    {
      get { return _subscribed; }
      set { _subscribed = value; }
    }

    private bool _low_violence = default(bool);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"low_violence", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool low_violence
    {
      get { return _low_violence; }
      set { _low_violence = value; }
    }

    private bool _limited = default(bool);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"limited", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool limited
    {
      get { return _limited; }
      set { _limited = value; }
    }

    private bool _trusted = default(bool);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"trusted", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool trusted
    {
      get { return _trusted; }
      set { _trusted = value; }
    }

    private uint _package = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"package", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint package
    {
      get { return _package; }
      set { _package = value; }
    }

    private uint _time_cached = default(uint);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"time_cached", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint time_cached
    {
      get { return _time_cached; }
      set { _time_cached = value; }
    }

    private bool _account_locked = default(bool);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"account_locked", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool account_locked
    {
      get { return _account_locked; }
      set { _account_locked = value; }
    }

    private bool _community_banned = default(bool);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"community_banned", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool community_banned
    {
      get { return _community_banned; }
      set { _community_banned = value; }
    }

    private bool _trade_banned = default(bool);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"trade_banned", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool trade_banned
    {
      get { return _trade_banned; }
      set { _trade_banned = value; }
    }

    private bool _eligible_for_community_market = default(bool);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"eligible_for_community_market", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool eligible_for_community_market
    {
      get { return _eligible_for_community_market; }
      set { _eligible_for_community_market = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCMultiplexMessage")]
  public partial class CMsgGCMultiplexMessage : global::ProtoBuf.IExtensible
  {
    public CMsgGCMultiplexMessage() {}
    

    private uint _msgtype = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msgtype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint msgtype
    {
      get { return _msgtype; }
      set { _msgtype = value; }
    }

    private byte[] _payload = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"payload", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] payload
    {
      get { return _payload; }
      set { _payload = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _steamids = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(3, Name=@"steamids", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<ulong> steamids
    {
      get { return _steamids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGCToGCMsgMasterAck")]
  public partial class CGCToGCMsgMasterAck : global::ProtoBuf.IExtensible
  {
    public CGCToGCMsgMasterAck() {}
    

    private uint _dir_index = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dir_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint dir_index
    {
      get { return _dir_index; }
      set { _dir_index = value; }
    }

    private uint _gc_type = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gc_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint gc_type
    {
      get { return _gc_type; }
      set { _gc_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGCToGCMsgMasterAck_Response")]
  public partial class CGCToGCMsgMasterAck_Response : global::ProtoBuf.IExtensible
  {
    public CGCToGCMsgMasterAck_Response() {}
    

    private int _eresult = (int)2;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)2)]
    public int eresult
    {
      get { return _eresult; }
      set { _eresult = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGCToGCMsgRouted")]
  public partial class CGCToGCMsgRouted : global::ProtoBuf.IExtensible
  {
    public CGCToGCMsgRouted() {}
    

    private uint _msg_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint msg_type
    {
      get { return _msg_type; }
      set { _msg_type = value; }
    }

    private ulong _sender_id = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sender_id", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong sender_id
    {
      get { return _sender_id; }
      set { _sender_id = value; }
    }

    private byte[] _net_message = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"net_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] net_message
    {
      get { return _net_message; }
      set { _net_message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGCToGCMsgRoutedReply")]
  public partial class CGCToGCMsgRoutedReply : global::ProtoBuf.IExtensible
  {
    public CGCToGCMsgRoutedReply() {}
    

    private uint _msg_type = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"msg_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint msg_type
    {
      get { return _msg_type; }
      set { _msg_type = value; }
    }

    private byte[] _net_message = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"net_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] net_message
    {
      get { return _net_message; }
      set { _net_message = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCUpdateSessionIP")]
  public partial class CMsgGCUpdateSessionIP : global::ProtoBuf.IExtensible
  {
    public CMsgGCUpdateSessionIP() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }

    private uint _ip = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ip
    {
      get { return _ip; }
      set { _ip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCRequestSessionIP")]
  public partial class CMsgGCRequestSessionIP : global::ProtoBuf.IExtensible
  {
    public CMsgGCRequestSessionIP() {}
    

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGCRequestSessionIPResponse")]
  public partial class CMsgGCRequestSessionIPResponse : global::ProtoBuf.IExtensible
  {
    public CMsgGCRequestSessionIPResponse() {}
    

    private uint _ip = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ip", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ip
    {
      get { return _ip; }
      set { _ip = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgSOCacheHaveVersion")]
  public partial class CMsgSOCacheHaveVersion : global::ProtoBuf.IExtensible
  {
    public CMsgSOCacheHaveVersion() {}
    

    private CMsgSOIDOwner _soid = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"soid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CMsgSOIDOwner soid
    {
      get { return _soid; }
      set { _soid = value; }
    }

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgClientHello")]
  public partial class CMsgClientHello : global::ProtoBuf.IExtensible
  {
    public CMsgClientHello() {}
    

    private uint _version = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgSOCacheHaveVersion> _socache_have_versions = new global::System.Collections.Generic.List<CMsgSOCacheHaveVersion>();
    [global::ProtoBuf.ProtoMember(2, Name=@"socache_have_versions", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOCacheHaveVersion> socache_have_versions
    {
      get { return _socache_have_versions; }
    }
  

    private uint _client_session_need = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"client_session_need", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint client_session_need
    {
      get { return _client_session_need; }
      set { _client_session_need = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgClientWelcome")]
  public partial class CMsgClientWelcome : global::ProtoBuf.IExtensible
  {
    public CMsgClientWelcome() {}
    

    private uint _version = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint version
    {
      get { return _version; }
      set { _version = value; }
    }

    private byte[] _game_data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"game_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] game_data
    {
      get { return _game_data; }
      set { _game_data = value; }
    }
    private readonly global::System.Collections.Generic.List<CMsgSOCacheSubscribed> _outofdate_subscribed_caches = new global::System.Collections.Generic.List<CMsgSOCacheSubscribed>();
    [global::ProtoBuf.ProtoMember(3, Name=@"outofdate_subscribed_caches", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOCacheSubscribed> outofdate_subscribed_caches
    {
      get { return _outofdate_subscribed_caches; }
    }
  
    private readonly global::System.Collections.Generic.List<CMsgSOCacheSubscriptionCheck> _uptodate_subscribed_caches = new global::System.Collections.Generic.List<CMsgSOCacheSubscriptionCheck>();
    [global::ProtoBuf.ProtoMember(4, Name=@"uptodate_subscribed_caches", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CMsgSOCacheSubscriptionCheck> uptodate_subscribed_caches
    {
      get { return _uptodate_subscribed_caches; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgConnectionStatus")]
  public partial class CMsgConnectionStatus : global::ProtoBuf.IExtensible
  {
    public CMsgConnectionStatus() {}
    

    private GCConnectionStatus _status = GCConnectionStatus.GCConnectionStatus_HAVE_SESSION;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(GCConnectionStatus.GCConnectionStatus_HAVE_SESSION)]
    public GCConnectionStatus status
    {
      get { return _status; }
      set { _status = value; }
    }

    private uint _client_session_need = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"client_session_need", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint client_session_need
    {
      get { return _client_session_need; }
      set { _client_session_need = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"GCConnectionStatus")]
    public enum GCConnectionStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GCConnectionStatus_HAVE_SESSION", Value=0)]
      GCConnectionStatus_HAVE_SESSION = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GCConnectionStatus_GC_GOING_DOWN", Value=1)]
      GCConnectionStatus_GC_GOING_DOWN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GCConnectionStatus_NO_SESSION", Value=2)]
      GCConnectionStatus_NO_SESSION = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE", Value=3)]
      GCConnectionStatus_NO_SESSION_IN_LOGON_QUEUE = 3
    }
  
}
#pragma warning restore 1591
