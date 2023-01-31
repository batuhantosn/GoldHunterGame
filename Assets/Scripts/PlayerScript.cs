using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public AudioClip goldSound, fallSound;
    public GameControl gameC;
    private float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameC.gameActive)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * speed;
            y *= Time.deltaTime * speed;

            transform.Translate(x,0f,y);
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("gold"))
        {
            AudioSource.PlayClipAtPoint(goldSound, transform.position);
            //GetComponent<AudioSource>().PlayOneShot(goldSound, 1f);
            gameC.addGold();
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag.Equals("enemy"))
        {
            AudioSource.PlayClipAtPoint(fallSound, transform.position);
            //GetComponent<AudioSource>().PlayOneShot(fallSound,1f);
            gameC.gameActive = false;
        }
    }
}
