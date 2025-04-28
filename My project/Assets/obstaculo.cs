using UnityEngine;

public class obstaculo : MonoBehaviour {
    public GeneratorScript generatorScript;
    
    // Update is called once per frame
    void Update(){
        tranform.Translate(Vectot2 * generatorScript.CurrentSpeed * Time.deltaTime);
        
    }

}