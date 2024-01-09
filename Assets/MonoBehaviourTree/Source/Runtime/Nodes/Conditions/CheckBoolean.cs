using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBT
{
    [AddComponentMenu("")]
    [MBTNode(name = "Conditions/Check Boolean")]
    public class CheckBoolean : Condition
    {
        public BoolReference boolean;
        public bool checkValue = true;

        public override bool Check()
        {
            return boolean.Value == checkValue;
        }
    }
}
