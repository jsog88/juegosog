using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _anim;
    private NewInput _newInput;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
        _newInput = GetComponent<NewInput>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveAnim();
    }

    public void PlayerMoveAnim()
    {
        _anim.SetBool("Move", _newInput.inputX !=0);
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            Vector3 rotation = transform.eulerAngles;
            rotation.y = horizontalInput > 0 ? 0 : 180;
            transform.eulerAngles = rotation;
        }
           
        
    }
}
