using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_destroyobje : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", 3f);
    }
    public void DestroyObject()
    {
        Destroy(gameObject);
    }
}
