using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTomahawk :CMissile
{
    void Awake()
    {
        this.seekBehaviour = new CSeekWithGPS();

    }
}
