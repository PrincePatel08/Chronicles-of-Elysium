using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBT
{
    [AddComponentMenu("")]
    [MBTNode(name = "Tasks/Destroy Gameobject")]
    public class DestroyGameobject : Leaf
    {
        [SerializeField]
        public GameObjectReference objectToDestroy;

        public override NodeResult Execute()
        {
            Destroy(objectToDestroy.Value);
            return NodeResult.success;
        }
    }
}
