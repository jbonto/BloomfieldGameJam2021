using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class utility : MonoBehaviour
{
    public static float Get2DAngle(Vector2 origin, Vector2 target){
        float angle= (target.y - origin.y) / (target.x - origin.x);
        float add = 0f;
            if(target.x > origin.x && target.y < origin.y){
                add = 360f;
            } else if(target.x < origin.x && target.y > origin.y){
                add = 180f;
            } else if(target.x < origin.x && target.y < origin.y){
                add = 225f;
            }
        angle = (Mathf.Atan(angle) * Mathf.Rad2Deg) + add; 
        return angle;
    }
    public static bool GreaterThan(float a, float b){
        if(a>=b){
            return true;
        } else{
             return false;
        }
    }
    public static bool GreaterThan(int a, int b){
        if(a>=b){
            return true;
        } else{
             return false;
        }
    }
    public static bool IsBetween(float a, float min, float max){
        if (a >= min && a <=max){
            return true;
        } else {
            return false;
        }
    }
    public static bool IsBetween(int a, int min, int max){
        if (a >= min && a <=max){
            return true;
        } else {
            return false;
        }
    }
}
