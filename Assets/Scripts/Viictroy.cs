using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Viictroy : MonoBehaviour
{
    private void OnDestroy()
    {
     

        if (gameObject.tag == "Boss")
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
