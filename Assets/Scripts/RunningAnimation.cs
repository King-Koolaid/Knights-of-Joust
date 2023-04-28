using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAnimation : MonoBehaviour
{
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D));// or any other condition to check if the player is jumping
        {
            playerAnim.SetTrigger("Running");
        }

        if (Input.GetKeyDown(KeyCode.A));// or any other condition to check if the player is jumping
        {
            playerAnim.SetTrigger("Running");
        }
    }
}