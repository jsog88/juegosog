using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private OldInput _oldInput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _oldInput = GetComponent<OldInput>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }
    public void movement()

     {
        transform.Translate(Vector3.right * speed * _oldInput.horizontal * Time.deltaTime);
     }
}
