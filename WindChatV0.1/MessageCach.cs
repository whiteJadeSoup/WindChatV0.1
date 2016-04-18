// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: message_cach.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace IM {

  /// <summary>Holder for reflection information generated from message_cach.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MessageCachReflection {

    #region Descriptor
    /// <summary>File descriptor for message_cach.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageCachReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJtZXNzYWdlX2NhY2gucHJvdG8SAklNGgpjaGF0LnByb3RvIkEKC01lc3Nh",
            "Z2VDYWNoEg8KB3VzZXJfaWQYASABKAMSIQoMY2hhdF9tZXNzYWdlGAIgAygL",
            "MgsuSU0uQ2hhdFBrdGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::IM.ChatReflection.Descriptor, },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::IM.MessageCach), global::IM.MessageCach.Parser, new[]{ "UserId", "ChatMessage" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class MessageCach : pb::IMessage<MessageCach> {
    private static readonly pb::MessageParser<MessageCach> _parser = new pb::MessageParser<MessageCach>(() => new MessageCach());
    public static pb::MessageParser<MessageCach> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::IM.MessageCachReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public MessageCach() {
      OnConstruction();
    }

    partial void OnConstruction();

    public MessageCach(MessageCach other) : this() {
      userId_ = other.userId_;
      chatMessage_ = other.chatMessage_.Clone();
    }

    public MessageCach Clone() {
      return new MessageCach(this);
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 1;
    private long userId_;
    /// <summary>
    ///   �û�id
    /// </summary>
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "chat_message" field.</summary>
    public const int ChatMessageFieldNumber = 2;
    private static readonly pb::FieldCodec<global::IM.ChatPkt> _repeated_chatMessage_codec
        = pb::FieldCodec.ForMessage(18, global::IM.ChatPkt.Parser);
    private readonly pbc::RepeatedField<global::IM.ChatPkt> chatMessage_ = new pbc::RepeatedField<global::IM.ChatPkt>();
    /// <summary>
    ///   ������Ϣ���� 
    /// </summary>
    public pbc::RepeatedField<global::IM.ChatPkt> ChatMessage {
      get { return chatMessage_; }
    }

    public override bool Equals(object other) {
      return Equals(other as MessageCach);
    }

    public bool Equals(MessageCach other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserId != other.UserId) return false;
      if(!chatMessage_.Equals(other.chatMessage_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      hash ^= chatMessage_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(UserId);
      }
      chatMessage_.WriteTo(output, _repeated_chatMessage_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      size += chatMessage_.CalculateSize(_repeated_chatMessage_codec);
      return size;
    }

    public void MergeFrom(MessageCach other) {
      if (other == null) {
        return;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
      chatMessage_.Add(other.chatMessage_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            UserId = input.ReadInt64();
            break;
          }
          case 18: {
            chatMessage_.AddEntriesFrom(input, _repeated_chatMessage_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code