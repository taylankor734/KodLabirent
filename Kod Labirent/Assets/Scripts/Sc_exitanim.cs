using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_exitanim : MonoBehaviour
{
    public Animator anim;
    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            anim.Play("bitis");
        }
    }
}
