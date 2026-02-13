using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private SpriteRenderer re;
    public GameObject tr;
    // Start is called before the first frame update
    void Start()
    {
        re = GetComponent<SpriteRenderer>();
        ColorC();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Metodo cambiar color
    public void ColorC()
    {
        re.color = Color.green;
        transform.position = tr.transform.position;
        Debug.Log(string.Format("La posicion del cuadrado es: {0}", transform.position));
    }
}
