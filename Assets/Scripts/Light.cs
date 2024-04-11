using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private void Awake()
    {
        if (FindObjectsOfType<Light>().Length != 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this);
    }
}
