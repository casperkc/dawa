using System;
namespace Dawa.Service.Models
{
    public enum DørEnum { Mf, Th, Tv };

    public partial struct DørUnion
    {
        public DørEnum? Enum;

        public long? Integer;

        public static implicit operator DørUnion(DørEnum Enum) => new DørUnion { Enum = Enum };
        public static implicit operator DørUnion(long Integer) => new DørUnion { Integer = Integer };
        public bool IsNull => Integer == null && Enum == null;
    }
}
