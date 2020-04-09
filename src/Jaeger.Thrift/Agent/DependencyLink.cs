/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */

using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;


namespace Jaeger.Thrift.Agent
{

  public partial class DependencyLink : TBase
  {

    public string Parent { get; set; }

    public string Child { get; set; }

    public long CallCount { get; set; }

    public DependencyLink()
    {
    }

    public DependencyLink(string parent, string child, long callCount) : this()
    {
      this.Parent = parent;
      this.Child = child;
      this.CallCount = callCount;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_parent = false;
        bool isset_child = false;
        bool isset_callCount = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                Parent = await iprot.ReadStringAsync(cancellationToken);
                isset_parent = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Child = await iprot.ReadStringAsync(cancellationToken);
                isset_child = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                CallCount = await iprot.ReadI64Async(cancellationToken);
                isset_callCount = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_parent)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_child)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_callCount)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("DependencyLink");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "parent";
        field.Type = TType.String;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Parent, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "child";
        field.Type = TType.String;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Child, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "callCount";
        field.Type = TType.I64;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(CallCount, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as DependencyLink;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Parent, other.Parent)
        && System.Object.Equals(Child, other.Child)
        && System.Object.Equals(CallCount, other.CallCount);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Parent.GetHashCode();
        hashcode = (hashcode * 397) + Child.GetHashCode();
        hashcode = (hashcode * 397) + CallCount.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("DependencyLink(");
      sb.Append(", Parent: ");
      sb.Append(Parent);
      sb.Append(", Child: ");
      sb.Append(Child);
      sb.Append(", CallCount: ");
      sb.Append(CallCount);
      sb.Append(")");
      return sb.ToString();
    }
  }

}
