using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CClient : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            CMissile sideWinder = ScriptableObject.CreateInstance<CSideWinder>();
            sideWinder.ApplySeek();

            CMissile tomahawk = ScriptableObject.CreateInstance<CTomahawk>();
            tomahawk.ApplySeek();

            CMissile torpedo = ScriptableObject.CreateInstance<CTorpedo>();
            torpedo.ApplySeek();

            CMissile sideWinderWithSonar = ScriptableObject.CreateInstance<CSideWinder>();
            ISeekBehaviour sonar = new CSeekWithSonar();
            sideWinderWithSonar.setSeekBehaviour(sonar);
            sideWinderWithSonar.ApplySeek();


        }
        
    }
}
