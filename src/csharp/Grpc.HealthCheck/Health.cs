// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: grpc/health/v1/health.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.Health.V1 {

  /// <summary>Holder for reflection information generated from grpc/health/v1/health.proto</summary>
  public static partial class HealthReflection {

    #region Descriptor
    /// <summary>File descriptor for grpc/health/v1/health.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HealthReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtncnBjL2hlYWx0aC92MS9oZWFsdGgucHJvdG8SDmdycGMuaGVhbHRoLnYx",
            "IiUKEkhlYWx0aENoZWNrUmVxdWVzdBIPCgdzZXJ2aWNlGAEgASgJIpQBChNI",
            "ZWFsdGhDaGVja1Jlc3BvbnNlEkEKBnN0YXR1cxgBIAEoDjIxLmdycGMuaGVh",
            "bHRoLnYxLkhlYWx0aENoZWNrUmVzcG9uc2UuU2VydmluZ1N0YXR1cyI6Cg1T",
            "ZXJ2aW5nU3RhdHVzEgsKB1VOS05PV04QABILCgdTRVJWSU5HEAESDwoLTk9U",
            "X1NFUlZJTkcQAjJaCgZIZWFsdGgSUAoFQ2hlY2sSIi5ncnBjLmhlYWx0aC52",
            "MS5IZWFsdGhDaGVja1JlcXVlc3QaIy5ncnBjLmhlYWx0aC52MS5IZWFsdGhD",
            "aGVja1Jlc3BvbnNlQhGqAg5HcnBjLkhlYWx0aC5WMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Health.V1.HealthCheckRequest), global::Grpc.Health.V1.HealthCheckRequest.Parser, new[]{ "Service" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grpc.Health.V1.HealthCheckResponse), global::Grpc.Health.V1.HealthCheckResponse.Parser, new[]{ "Status" }, null, new[]{ typeof(global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HealthCheckRequest : pb::IMessage<HealthCheckRequest> {
    private static readonly pb::MessageParser<HealthCheckRequest> _parser = new pb::MessageParser<HealthCheckRequest>(() => new HealthCheckRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HealthCheckRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Health.V1.HealthReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HealthCheckRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HealthCheckRequest(HealthCheckRequest other) : this() {
      service_ = other.service_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HealthCheckRequest Clone() {
      return new HealthCheckRequest(this);
    }

    /// <summary>Field number for the "service" field.</summary>
    public const int ServiceFieldNumber = 1;
    private string service_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Service {
      get { return service_; }
      set {
        service_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HealthCheckRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HealthCheckRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Service != other.Service) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Service.Length != 0) hash ^= Service.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Service.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Service);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Service.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Service);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HealthCheckRequest other) {
      if (other == null) {
        return;
      }
      if (other.Service.Length != 0) {
        Service = other.Service;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Service = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class HealthCheckResponse : pb::IMessage<HealthCheckResponse> {
    private static readonly pb::MessageParser<HealthCheckResponse> _parser = new pb::MessageParser<HealthCheckResponse>(() => new HealthCheckResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<HealthCheckResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grpc.Health.V1.HealthReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HealthCheckResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HealthCheckResponse(HealthCheckResponse other) : this() {
      status_ = other.status_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public HealthCheckResponse Clone() {
      return new HealthCheckResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as HealthCheckResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(HealthCheckResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(HealthCheckResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            status_ = (global::Grpc.Health.V1.HealthCheckResponse.Types.ServingStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the HealthCheckResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum ServingStatus {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("SERVING")] Serving = 1,
        [pbr::OriginalName("NOT_SERVING")] NotServing = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code