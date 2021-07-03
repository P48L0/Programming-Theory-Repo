using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValueDisplay : MonoBehaviour
{
    [SerializeField] Cell targetCell;
    Text label;

    void Start() {
        label = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        label.text = targetCell.currentValue.ToString();
    }
}
