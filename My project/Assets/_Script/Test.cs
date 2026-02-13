using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public float a;
    public float b;
    public float c;
    public float d;
    private float _result;
    // Start is called before the first frame update
    void Start()
    {
        hipotenusa();
    }
    public void hipotenusa()
    {
        _result = ((a + b) * (b - c)) /d;
        Debug.Log(string.Format("El resultado es: {0}",_result));
    }
  
}
