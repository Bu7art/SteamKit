//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_physicalgoods.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_RegisterSteamController_Request")]
  public partial class CPhysicalGoods_RegisterSteamController_Request : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_RegisterSteamController_Request() {}
    

    private string _serial_number = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }

    private string _controller_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"controller_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string controller_code
    {
      get { return _controller_code; }
      set { _controller_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_RegisterSteamController_Response")]
  public partial class CPhysicalGoods_RegisterSteamController_Response : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_RegisterSteamController_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_CompleteSteamControllerRegistration_Request")]
  public partial class CPhysicalGoods_CompleteSteamControllerRegistration_Request : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_CompleteSteamControllerRegistration_Request() {}
    

    private string _serial_number = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }

    private string _controller_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"controller_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string controller_code
    {
      get { return _controller_code; }
      set { _controller_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_CompleteSteamControllerRegistration_Response")]
  public partial class CPhysicalGoods_CompleteSteamControllerRegistration_Response : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_CompleteSteamControllerRegistration_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_SteamControllerSetConfig_Request")]
  public partial class CPhysicalGoods_SteamControllerSetConfig_Request : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_SteamControllerSetConfig_Request() {}
    

    private string _serial_number = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }

    private string _controller_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"controller_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string controller_code
    {
      get { return _controller_code; }
      set { _controller_code = value; }
    }

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _publishedfileid = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"publishedfileid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong publishedfileid
    {
      get { return _publishedfileid; }
      set { _publishedfileid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_SteamControllerSetConfig_Response")]
  public partial class CPhysicalGoods_SteamControllerSetConfig_Response : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_SteamControllerSetConfig_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_QueryAccountsRegisteredToSerial_Request")]
  public partial class CPhysicalGoods_QueryAccountsRegisteredToSerial_Request : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_QueryAccountsRegisteredToSerial_Request() {}
    

    private string _serial_number = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"serial_number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string serial_number
    {
      get { return _serial_number; }
      set { _serial_number = value; }
    }

    private string _controller_code = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"controller_code", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string controller_code
    {
      get { return _controller_code; }
      set { _controller_code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_QueryAccountsRegisteredToSerial_Accounts")]
  public partial class CPhysicalGoods_QueryAccountsRegisteredToSerial_Accounts : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_QueryAccountsRegisteredToSerial_Accounts() {}
    

    private uint _accountid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }

    private bool _registration_complete = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"registration_complete", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool registration_complete
    {
      get { return _registration_complete; }
      set { _registration_complete = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CPhysicalGoods_QueryAccountsRegisteredToSerial_Response")]
  public partial class CPhysicalGoods_QueryAccountsRegisteredToSerial_Response : global::ProtoBuf.IExtensible
  {
    public CPhysicalGoods_QueryAccountsRegisteredToSerial_Response() {}
    
    private readonly global::System.Collections.Generic.List<CPhysicalGoods_QueryAccountsRegisteredToSerial_Accounts> _accounts = new global::System.Collections.Generic.List<CPhysicalGoods_QueryAccountsRegisteredToSerial_Accounts>();
    [global::ProtoBuf.ProtoMember(1, Name=@"accounts", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPhysicalGoods_QueryAccountsRegisteredToSerial_Accounts> accounts
    {
      get { return _accounts; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IPhysicalGoods
    {
      CPhysicalGoods_RegisterSteamController_Response RegisterSteamController(CPhysicalGoods_RegisterSteamController_Request request);
    CPhysicalGoods_CompleteSteamControllerRegistration_Response CompleteSteamControllerRegistration(CPhysicalGoods_CompleteSteamControllerRegistration_Request request);
    CPhysicalGoods_SteamControllerSetConfig_Response SteamControllerSetConfig(CPhysicalGoods_SteamControllerSetConfig_Request request);
    CPhysicalGoods_QueryAccountsRegisteredToSerial_Response QueryAccountsRegisteredToController(CPhysicalGoods_QueryAccountsRegisteredToSerial_Request request);
    
    }
    
    
}
#pragma warning restore 1591
