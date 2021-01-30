using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour
{
    public int mouseInput = -2, mouseSelect;
    public bool good;
    public GameObject objective;
    private bool glowing = true, moving = false, acting = false;
    private Vector2 left, center, right, up;
    public float distance, benevspeed, evilspeed;
    // Start is called before the first frame update
    void Start()
    {
        left = new Vector2(this.transform.position.x - distance, this.transform.position.y);
        center = new Vector2(this.transform.position.x, this.transform.position.y);
        right =  new Vector2(this.transform.position.x + distance, this.transform.position.y);
        up = new Vector2(this.transform.position.x, this.transform.position.y + 6f);
    }
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(mouseSelect)){
            mouseInput =1;
            
        } 
        if(Input.GetMouseButtonUp(mouseSelect)){
            mouseInput = 2;
            glowing = true;

        }
    }
    
    void OnMouseOver()
    {
        if(!moving){
            StartCoroutine(BenevolentMove());
            moving = true;
        }
        if(mouseInput == 1 && !acting){
            StartCoroutine(MoveUp());
            acting = true;
        }
        //Debug.Log("over");
    }
    IEnumerator BenevolentMove(){
        //rightthanleft
        while(this.transform.position.x!=right.x){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, right, benevspeed);
            if(acting)
                break;
        }
        while(this.transform.position.x!=left.x){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, left, benevspeed);
            if(acting)
                break;

        }
        while(this.transform.position.x!=center.x){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, center, benevspeed);
            if(acting)
                break;
        }
        moving = false;
    }

    IEnumerator MoveUp(){
        while(this.transform.position.y!= up.y){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, up, benevspeed * 3f);
        }
        yield return new WaitForSeconds(4f);
        while(this.transform.position.y!= center.y){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, center, benevspeed * 3f);
        }
        acting = false;
    }
}
