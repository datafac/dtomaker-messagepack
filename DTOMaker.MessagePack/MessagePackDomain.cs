using DTOMaker.Gentime;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;

namespace DTOMaker.MessagePack
{
    internal sealed class MessagePackDomain : TargetDomain
    {
        public MessagePackDomain(string name, Location location) : base(name, location) { }

        private SyntaxDiagnostic? CheckEntityTags()
        {
            Dictionary<int, TargetEntity> map = new Dictionary<int, TargetEntity>();
            foreach (var entity in this.Entities.Values)
            {
                // todo invalid tag unit tests
                int tag = entity.IntTag;
                if (tag == 0)
                {
                    return new SyntaxDiagnostic(
                        DiagnosticId.DMMP0002, "Invalid entity tag", DiagnosticCategory.Design, entity.Location, DiagnosticSeverity.Error,
                        $"An entity tag must be defined.");
                }
                if (map.TryGetValue(tag, out var otherEntity))
                {
                    // duplicate!
                    return new SyntaxDiagnostic(
                        DiagnosticId.DMMP0002, "Invalid entity tag", DiagnosticCategory.Design, entity.Location, DiagnosticSeverity.Error,
                        $"This entity tag ({tag}) is not unique. Already used by entity: {otherEntity.Name}");
                }
                else
                {
                    map[tag] = entity;
                }
            }
            return null;
        }

        protected override IEnumerable<SyntaxDiagnostic> OnGetValidationDiagnostics()
        {
            foreach (var diagnostic1 in base.OnGetValidationDiagnostics())
            {
                yield return diagnostic1;
            }

            SyntaxDiagnostic? diagnostic2;
            if ((diagnostic2 = CheckEntityTags()) is not null) yield return diagnostic2;
        }
    }
}
