using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //VARIABLES
    public string NPCname = "Link"; 
    //public Rigidbody2D rb;
    public float speed;
    private SpriteRenderer sr;

    //SPRITE VARIABLES 
    public Sprite upSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;
    public Sprite frontSprite;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;

        if (Input.GetKey("w"))
        {
            newPosition.y += .05f;
            sr.sprite = upSprite;
        }
        if (Input.GetKey("s"))
        {
            newPosition.y -= .05f;
            sr.sprite = frontSprite;
        }
        if (Input.GetKey("a"))
        {
            newPosition.x -= .05f;
            sr.sprite = leftSprite;
        }
        if (Input.GetKey("d"))
        {
            newPosition.x += .05f;
            sr.sprite =rightSprite;
        }
        transform.position = newPosition;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    
    {
    //links room 
        if (collision.gameObject.tag.Equals("HomeDoor"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(1);
        }
if (collision.gameObject.tag.Equals("Door"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(0);
        }
    //Black Smith Room
    if (collision.gameObject.tag.Equals("Blacksimithout"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(1);
        }
if (collision.gameObject.tag.Equals("BlackSmith"))
        {
            Debug.Log("change scene");
            SceneManager.LoadScene(2);
            
        }



    }

}
