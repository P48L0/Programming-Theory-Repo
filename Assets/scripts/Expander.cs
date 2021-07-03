using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// INHERITANCE
public class Expander : Cell
{
    private float ang;

    void Start() {
        ang = 0f;
    }

    // POLYMORPHISM
    protected override void AnimateIdle()
    {
        ang += 3f * Time.deltaTime;

        currentValue = Mathf.Sin(ang);
        transform.localScale = Vector3.one * currentValue;
    }

    
}
