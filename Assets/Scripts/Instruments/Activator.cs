using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public KeyCode key;
    bool active=false;
    [SerializeField] private GameObject note;
   
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(key)&&active)
        { Destroy(note); }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Note") 
        {
            active = true;
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        active=false;
    }
}
