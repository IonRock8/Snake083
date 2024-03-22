using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
       
    
    
    [SerializeField] float destroyDelay = 1f;
    SpriteRenderer spriteRenderer;

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Oops!");
    }
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        

        if(other.tag == "snake1")
        {
            spriteRenderer.sprite = Resources.Load<Sprite>("Bat");
            Debug.Log("ถอยกลับ 2 ช่อง"); 
            Destroy(other.gameObject, destroyDelay); 
        }
        if(other.tag == "snake2")
        {
            spriteRenderer.sprite = Resources.Load<Sprite>("Bat");
            Debug.Log("ถอยกลับ 4 ช่อง"); 
            Destroy(other.gameObject, destroyDelay); 
        }
        if(other.tag == "snake3")
        {
            spriteRenderer.sprite = Resources.Load<Sprite>("Bat");
            Debug.Log("ถอยกลับ 1 ช่อง"); 
            Destroy(other.gameObject, destroyDelay); 
        }

        if(other.tag == "Chest")
        {
            spriteRenderer.sprite = Resources.Load<Sprite>("vama");
            Debug.Log("ทอยลูกเต๋าอีกรอบ");
            Destroy(other.gameObject, destroyDelay);    
        }
        if(other.tag == "ladder1")
        {
            Debug.Log("ไปช่องที่ 14"); 
        }
        if(other.tag == "ladder2")
        {
            Debug.Log("ไปช่องที่ 37"); 
        }
        if(other.tag == "ladder3")
        {
            Debug.Log("ไปช่องที่ 64"); 
        }
        if(other.tag == "ladder4")
        {
            Debug.Log("ไปช่องที่ 96"); 
        }
        if(other.tag == "ladder5")
        {
            Debug.Log("ไปช่องที่ 73"); 
        }
        if(other.tag == "ladder6")
        {
            Debug.Log("ไปช่องที่ 43"); 
        }
        if(other.tag == "ladder7")
        {
            Debug.Log("ไปช่องที่ 47"); 
        }
        if(other.tag == "ladder8")
        {
            Debug.Log("ไปช่องที่ 23"); 
        }
    }
    
}
