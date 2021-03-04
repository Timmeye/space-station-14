#nullable enable
using Content.Shared.GameObjects.EntitySystems;
using Robust.Shared.GameObjects;
using Robust.Shared.Physics;
using Robust.Shared.Physics.Collision;

namespace Content.Shared.GameObjects.Components.Items
{
    [RegisterComponent]
    public class ThrownItemComponent : Component, IStartCollide
    {
        public override string Name => "ThrownItem";

        public IEntity? Thrower { get; set; }

        void IStartCollide.CollideWith(IPhysBody ourBody, IPhysBody otherBody, in Manifold manifold)
        {
            EntitySystem.Get<ThrownItemSystem>().ThrowCollideInteraction(Thrower, ourBody, otherBody);
        }
    }
}
