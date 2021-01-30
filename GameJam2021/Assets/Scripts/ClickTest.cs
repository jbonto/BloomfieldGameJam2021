using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    public int mouseInput = -2, mouseSelect;
    private bool glowing = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
        if(mouseInput == 1 && glowing){
            Debug.Log("hi");
            glowing=false;
        }
        //Debug.Log("over");
    }
}
