using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInterval : ChangeValue
{
    public override void Change(float newValue)
    {
        Options.SpawnInterval = newValue;
    }
}
