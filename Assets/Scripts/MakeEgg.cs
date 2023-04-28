using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeEgg : MonoBehaviour
{
    public GameObject eggPrefab;

    private void OnDestroy()
    {
        Instantiate(eggPrefab, transform.position, Quaternion.identity, transform);
    }
}
