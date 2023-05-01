using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    public ParticleSystem particlesystemPrefab;
    
    private void OnDestroy()
    {
        Instantiate(particlesystemPrefab, transform.position, Quaternion.identity, transform);
        
    }
}
