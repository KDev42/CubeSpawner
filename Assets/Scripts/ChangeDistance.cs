using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDistance : ChangeValue
{
    public override void Change(float newValue)
    {
        Options.Distance = newValue;
    }
}
