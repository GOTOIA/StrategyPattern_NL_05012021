using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CMissile :ScriptableObject
{
    protected ISeekBehaviour seekBehaviour;

    public virtual void ApplySeek()
    {
        seekBehaviour.seek();
    }

    public void setSeekBehaviour(ISeekBehaviour seekType)
    {
        this.seekBehaviour = seekType;
    }

}
