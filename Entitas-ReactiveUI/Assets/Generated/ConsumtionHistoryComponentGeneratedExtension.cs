//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public ConsumtionHistoryComponent consumtionHistory { get { return (ConsumtionHistoryComponent)GetComponent(ComponentIds.ConsumtionHistory); } }

        public bool hasConsumtionHistory { get { return HasComponent(ComponentIds.ConsumtionHistory); } }

        public Entity AddConsumtionHistory(System.Collections.Generic.List<ConsumptionEntry> newEntires) {
            var component = CreateComponent<ConsumtionHistoryComponent>(ComponentIds.ConsumtionHistory);
            component.entires = newEntires;
            return AddComponent(ComponentIds.ConsumtionHistory, component);
        }

        public Entity ReplaceConsumtionHistory(System.Collections.Generic.List<ConsumptionEntry> newEntires) {
            var component = CreateComponent<ConsumtionHistoryComponent>(ComponentIds.ConsumtionHistory);
            component.entires = newEntires;
            ReplaceComponent(ComponentIds.ConsumtionHistory, component);
            return this;
        }

        public Entity RemoveConsumtionHistory() {
            return RemoveComponent(ComponentIds.ConsumtionHistory);
        }
    }

    public partial class Pool {
        public Entity consumtionHistoryEntity { get { return GetGroup(Matcher.ConsumtionHistory).GetSingleEntity(); } }

        public ConsumtionHistoryComponent consumtionHistory { get { return consumtionHistoryEntity.consumtionHistory; } }

        public bool hasConsumtionHistory { get { return consumtionHistoryEntity != null; } }

        public Entity SetConsumtionHistory(System.Collections.Generic.List<ConsumptionEntry> newEntires) {
            if (hasConsumtionHistory) {
                throw new EntitasException("Could not set consumtionHistory!\n" + this + " already has an entity with ConsumtionHistoryComponent!",
                    "You should check if the pool already has a consumtionHistoryEntity before setting it or use pool.ReplaceConsumtionHistory().");
            }
            var entity = CreateEntity();
            entity.AddConsumtionHistory(newEntires);
            return entity;
        }

        public Entity ReplaceConsumtionHistory(System.Collections.Generic.List<ConsumptionEntry> newEntires) {
            var entity = consumtionHistoryEntity;
            if (entity == null) {
                entity = SetConsumtionHistory(newEntires);
            } else {
                entity.ReplaceConsumtionHistory(newEntires);
            }

            return entity;
        }

        public void RemoveConsumtionHistory() {
            DestroyEntity(consumtionHistoryEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherConsumtionHistory;

        public static IMatcher ConsumtionHistory {
            get {
                if (_matcherConsumtionHistory == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.ConsumtionHistory);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherConsumtionHistory = matcher;
                }

                return _matcherConsumtionHistory;
            }
        }
    }
}
