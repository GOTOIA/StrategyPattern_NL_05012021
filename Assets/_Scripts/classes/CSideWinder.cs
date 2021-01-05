using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSideWinder : CMissile
{
    void Awake()
    {
        this.seekBehaviour = new CSeekWithHeat();

    }

}
