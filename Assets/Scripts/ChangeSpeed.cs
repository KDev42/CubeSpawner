using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : ChangeValue
{
    public override void Change(float newValue)
    {
        Options.Speed = newValue; 
    }
}
