using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSeekWithSonar : ISeekBehaviour
{
    public void seek()
    {
        Debug.Log("Seeking target with heat sonar");
    }
}
