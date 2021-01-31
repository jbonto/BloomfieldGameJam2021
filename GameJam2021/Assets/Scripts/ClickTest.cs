using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    public int mouseInput = -2, mouseSelect;
    private bool glowing = true;
    public static bool canClick = true;
    public GameObject[] Enable, Disable;
    public Transform Location;
    GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        canClick = true;
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

    void OnMouseDown()
    {
        if(canClick){
            cam.transform.position = Location.position;
        }
    }

    void OnMouseOver()
    {
        if(mouseInput == 1 && glowing && canClick){
            
            /**
            foreach(GameObject i in Enable){
                i.SetActive(true);
            }
            foreach(GameObject i in Disable){
                i.SetActive(false);
            }
            glowing=false;
            */
        }
        
        //Debug.Log("over");
    }
}
