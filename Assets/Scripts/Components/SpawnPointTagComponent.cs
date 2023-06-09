using HECSFramework.Core;
using HECSFramework.Unity;
using System;
using BluePrints.Identifiers.SpawnerIdentifiers;
using UnityEngine;

namespace Components
{
    [Serializable][Documentation(Doc.NONE, "")]
    public sealed class SpawnPointTagComponent : BaseComponent
    {
        public SpawnerIdentifiers Id;
    }
}