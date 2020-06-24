using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDuck : MonoBehaviour
{
    Animator animator;
    Vector2 lookDirection = new Vector2(1,0);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetFloat("Stand", 1);
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");
                    
        // Vector2 move = new Vector2(horizontal, vertical);
            
        // if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        // {
        //     lookDirection.Set(move.x, move.y);
        //     lookDirection.Normalize();
        // }
            
        // animator.SetFloat("Stand", true);
        // animator.SetFloat("Speed", move.magnitude);
        // Vector2 position = transform.position;
        // position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        // position.y = position.y + 3.0f * vertical * Time.deltaTime;
        // transform.position = position;
    }
}
