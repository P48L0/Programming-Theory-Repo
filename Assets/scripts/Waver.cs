using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Waver : Cell
{
    Vector3 iniPos;

    // Start is called before the first frame update
    void Start()
    {
        iniPos = transform.position;
    }

    // POLYMORPHISM
    protected override void AnimateIdle()
    {
        currentValue = (Time.time%1f);
        transform.position = iniPos + ( Vector3.one * currentValue ); 
    }
}
