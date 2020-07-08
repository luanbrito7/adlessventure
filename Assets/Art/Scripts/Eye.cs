using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    Animator animator;
    Vector2 lookDirection = new Vector2(1,0);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPosition = getMainCharPosition();
        Vector2 eyePosition = transform.position;
        int horizontal = 0;
        int vertical = 0;

        if ((playerPosition.x - eyePosition.x) > 0) {
            horizontal = 1;
        } else if ((playerPosition.x - eyePosition.x) < 0) {
            horizontal = -1;
        } else {
            horizontal = 0;
        }

        if ((playerPosition.y - eyePosition.y) > 0) {
            vertical = 1;
        } else if ((playerPosition.x - eyePosition.y) < 0) {
            vertical = -1;
        } else {
            vertical = 0;
        }

        eyePosition.x = eyePosition.x + 2.0f * horizontal * Time.deltaTime;
        eyePosition.y = eyePosition.y + 2.0f * vertical * Time.deltaTime;

        transform.position = eyePosition;

        Vector2 move = new Vector2(horizontal, vertical);
            
        if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
            
        animator.SetFloat("Move X", lookDirection.x);
        animator.SetFloat("Move Y", lookDirection.y);
        // animator.SetFloat("Speed", move.magnitude);
    }

    Vector2 getMainCharPosition()
    {
        GameObject player = GameObject.Find("char5");
        Transform playerTransform = player.transform;
        Vector2 position = playerTransform.position;
        return position;
    }
}
