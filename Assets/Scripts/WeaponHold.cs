using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHold : MonoBehaviour
{
    public Transform attackPoint;
    public float moveSpeed = 1.0f;
    public float maxOffset = 1.0f;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = attackPoint.localPosition;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            float xOffset = Mathf.Clamp(attackPoint.localPosition.x - moveSpeed, -maxOffset, maxOffset);
            attackPoint.localPosition = new Vector3(xOffset, initialPosition.y, initialPosition.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            float xOffset = Mathf.Clamp(attackPoint.localPosition.x + moveSpeed, +maxOffset, maxOffset);
            attackPoint.localPosition = new Vector3(xOffset, initialPosition.y, initialPosition.z);
        }
    }
}
