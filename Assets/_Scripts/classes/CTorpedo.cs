using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTorpedo : CMissile
{
    void Awake()
    {
        this.seekBehaviour = new CSeekWithSonar();

    }
  
}