
using DTOMaker.Models;
using DTOMaker.Models.MessagePack;
namespace MyOrg.DomainA
{
    [Entity]
    [EntityKey(1)]
    public interface IMyDTO1
    {
        [Member(1)] long Field1 { get; set; }
    }
}
namespace MyOrg.DomainB
{
    [Entity]
    [EntityKey(2)]
    public interface IMyDTO2
    {
        [Member(1)] MyOrg.DomainA.IMyDTO1? Member1 { get; set; }
        [Member(2)] MyOrg.DomainA.IMyDTO1 Member2 { get; set; }
    }
}
