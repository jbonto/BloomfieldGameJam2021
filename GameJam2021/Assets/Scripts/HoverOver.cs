using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOver : MonoBehaviour
{
    public int mouseInput = -2, mouseSelect, attackFrames;
    public bool good;
    public GameObject objective;
    private bool glowing = true, moving = false, acting = false;
    private Vector2 left, center, right, up;
    public float distance, benevspeed, evilspeed, sizeUp, attackSpeed;
    public Vector3 sizeIncrease;
    // Start is called before the first frame update
    void Start()
    {
        left = new Vector2(this.transform.position.x - distance, this.transform.position.y);
        center = new Vector2(this.transform.position.x, this.transform.position.y);
        right =  new Vector2(this.transform.position.x + distance, this.transform.position.y);
        up = new Vector2(this.transform.position.x, this.transform.position.y + 1.5f);
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
    
    void OnMouseDown()
    {
        if(good){
           
        if(!acting){
            StartCoroutine(MoveUp());
            acting = true;
        }
        //Debug.Log("over");
        }
        if(!good){
            
        if(!acting){
            StartCoroutine(AttackPlayer());
            ClickTest.canClick = false;
            acting = true;
        }
        }
    }

    void OnMouseOver()
    {
        if(good){
            if(!moving){
            StartCoroutine(BenevolentMove());
            moving = true;
            }
        }
        if(!good){
            if(!moving){
            StartCoroutine(EvilMove());
            moving = true;
            }
        }
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
        while(this.transform.position.y < up.y-.3f){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, up, benevspeed * 3f);
        }
        yield return new WaitForSeconds(1.8f);
        while(this.transform.position.y!= center.y){
            yield return null;
            
            transform.position = Vector2.MoveTowards(transform.position, center, benevspeed * 3f);
        }
        acting = false;
    }

    IEnumerator EvilMove(){
        //left than right
        while(this.transform.position.x > left.x + .2f){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, left, evilspeed);
            if(acting)
                break;

        }
        while(this.transform.position.x < right.x - .2f){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, right, evilspeed);
            if(acting)
                break;
        }
        while(this.transform.position.x!=center.x){
            yield return null;
            transform.position = Vector2.MoveTowards(transform.position, center, evilspeed);
            if(acting)
                break;
        }
        moving = false;
    }
    IEnumerator AttackPlayer(){
        this.GetComponent<SpriteRenderer>().sortingOrder = 20;
        for(int i =0;i < attackFrames;i++){
            yield return null;
            this.transform.localScale+=sizeIncrease;
        }
        
    }
}
