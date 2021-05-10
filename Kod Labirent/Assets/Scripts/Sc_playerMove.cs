using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_playerMove : MonoBehaviour
{
    public GameObject prtc_dogru;
    public GameObject prtc_yanlis;
    public GameObject prtc_konfeti;
    public GameObject bitispaneli;

    public Transform spawnpoint;

    void Update()
    {   
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                if(transform.position.y<=0.25)
                {
                    if(transform.position.x<4.75)
                    {
                    transform.position = new Vector2(transform.position.x + 1.75f, transform.position.y);
                    }
                }
                if(transform.position.y>0.25)
                {
                    if(transform.position.x<1.25)
                    {
                    transform.position = new Vector2(transform.position.x + 1.75f, transform.position.y);
                    }
                }
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow)&&transform.position.x>-4)
            {
                transform.position = new Vector2(transform.position.x - 1.75f, transform.position.y);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if(transform.position.x<=1.25)
                {
                    if(transform.position.y<2)
                    {
                    transform.position = new Vector2(transform.position.x, transform.position.y + 1.75f);
                    }
                }
                if (transform.position.x > 1.25)
                {
                if (transform.position.y < 0.25)
                {
                    transform.position = new Vector2(transform.position.x, transform.position.y + 1.75f);
                }
                }
            }
            if (Input.GetKeyDown(KeyCode.DownArrow)&&transform.position.y>-3.25)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - 1.75f);
            }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name=="exit")
        {
            Instantiate(prtc_konfeti, collision.transform.position, transform.rotation);
            Invoke("panelacma", 3f);
        }
        if(collision.gameObject.name=="obje")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(1f,1f,1f,0.5f);
        }
        if (collision.gameObject.name == "sol")
        {
            //collision.gameObject.
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Instantiate(prtc_dogru, collision.transform.position, transform.rotation);
            }
            else if(Input.GetKey(KeyCode.RightArrow)|| (Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.DownArrow)))
            {
                Instantiate(prtc_yanlis, collision.transform.position, transform.rotation);
            }
        }
        if (collision.gameObject.name == "sag")
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Instantiate(prtc_dogru, collision.transform.position, transform.rotation);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.DownArrow)))
            {
                Instantiate(prtc_yanlis, collision.transform.position, transform.rotation);
            }
        }
        if (collision.gameObject.name == "yukari")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Instantiate(prtc_dogru, collision.transform.position, transform.rotation);
            }
            else if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.DownArrow)))
            {
                Instantiate(prtc_yanlis, collision.transform.position, transform.rotation);
            }
        }
        if (collision.gameObject.name == "asagi")
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Instantiate(prtc_dogru, collision.transform.position, transform.rotation);
            }
            else if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.LeftArrow)))
            {
                Instantiate(prtc_yanlis, collision.transform.position, transform.rotation);
            }
        }
    }
    public void panelacma()
    {
        bitispaneli.SetActive(true);
    }
}
