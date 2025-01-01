
namespace Scratchpad
{
    using DTOMaker.Models;
    using DTOMaker.Models.MessagePack;
    namespace MyOrg.DomainA
    {
        [Entity][EntityKey(1)] public interface IMyBase { }
    }
    namespace MyOrg.DomainB
    {
        [Entity][EntityKey(2)] public interface IMyDTO : MyOrg.DomainA.IMyBase { }
    }
}
