using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class LightWave : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D _light;
    public float baseFalloff = 0f, falloffMod, baseF, add;
    public bool initiallyActive;
    // Start is called before the first frame update
    void Start()
    {
        _light = this.GetComponent<UnityEngine.Experimental.Rendering.Universal.Light2D>(); 
        StartCoroutine(LightHum());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        
       // _light.falloffIntensity = 
    }
    
    IEnumerator LightHum(){
        float mod = 1f;
        while(2>1){
            yield return new WaitForSeconds(.06f);
            baseFalloff++;
            if(baseFalloff > 60f){
                mod*=-1f;
                baseFalloff = 0f;
            }
            _light.intensity+=(baseF*mod);
        }
    }
}
