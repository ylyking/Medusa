// Copyright (c) 2015 fjz13. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ServerConfig.proto
namespace Medusa.CoreProto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerConfigItem")]
  public partial class ServerConfigItem : global::ProtoBuf.IExtensible
  {
    public ServerConfigItem() {}
    
    private uint _Id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Id
    {
      get { return _Id; }
      set { _Id = value; }
    }
    private string _Address;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Address
    {
      get { return _Address; }
      set { _Address = value; }
    }
    private uint _Port;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint Port
    {
      get { return _Port; }
      set { _Port = value; }
    }
    private Medusa.CoreProto.ServerConfigItem.ServerStatus _Status;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Medusa.CoreProto.ServerConfigItem.ServerStatus Status
    {
      get { return _Status; }
      set { _Status = value; }
    }
    private Medusa.CoreProto.ServerConfigItem.ServerType _Type;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Medusa.CoreProto.ServerConfigItem.ServerType Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ServerStatus")]
    public enum ServerStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OK", Value=0)]
      OK = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Maintain", Value=1)]
      Maintain = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Error", Value=2)]
      Error = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ServerType")]
    public enum ServerType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TcpServer", Value=0)]
      TcpServer = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MockServer", Value=1)]
      MockServer = 1
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerConfig")]
  public partial class ServerConfig : global::ProtoBuf.IExtensible
  {
    public ServerConfig() {}
    
    private readonly global::System.Collections.Generic.List<Medusa.CoreProto.ServerConfigItem> _Items = new global::System.Collections.Generic.List<Medusa.CoreProto.ServerConfigItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Medusa.CoreProto.ServerConfigItem> Items
    {
      get { return _Items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}