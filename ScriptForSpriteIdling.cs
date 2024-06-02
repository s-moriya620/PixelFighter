using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForSpriteIdling : MonoBehaviour
{
    public float SpriteIdlingX = -2.5f;
    public int SpriteIdlingY = 0;
    public float SpriteIdlingScale = 0.8f;
    public GameObject RedPandaIdling;
    public GameObject RedPandaEvo1Idling;
    public GameObject RedPandaEvo2Idling;
    public GameObject PyroMonkeyIdling;
    public GameObject PyroMonkeyEvo1Idling;
    public GameObject PyroMonkeyEvo2Idling;
    public GameObject TaiyakiIdling;
    public GameObject TaiyakiEvo1Idling;
    public GameObject TaiyakiEvo2Idling;
    public GameObject UfoCatIdling;
    public GameObject UfoCatEvo1Idling;
    public GameObject UfoCatEvo2Idling;
    public GameObject HydroPhantasmIdling;
    public GameObject HydroPhantasmEvo1Idling;
    public GameObject HydroPhantasmEvo2Idling;
    public GameObject PurpleFighterIdling;
    public GameObject PurpleFighterEvo1Idling;
    public GameObject PurpleFighterEvo2Idling;
    
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayableSpriteController.ChosenColor){
            case 0:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    RedPandaIdling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(RedPandaIdling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    RedPandaEvo1Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(RedPandaEvo1Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    RedPandaEvo2Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(RedPandaEvo2Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 1:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    PyroMonkeyIdling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(PyroMonkeyIdling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    PyroMonkeyEvo1Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(PyroMonkeyEvo1Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    PyroMonkeyEvo2Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(PyroMonkeyEvo2Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 2:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    TaiyakiIdling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(TaiyakiIdling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    TaiyakiEvo1Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(TaiyakiEvo1Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    TaiyakiEvo2Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(TaiyakiEvo2Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 3:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    UfoCatIdling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(UfoCatIdling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    UfoCatEvo1Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(UfoCatEvo1Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    UfoCatEvo2Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(UfoCatEvo2Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 4:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    HydroPhantasmIdling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(HydroPhantasmIdling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    HydroPhantasmEvo1Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(HydroPhantasmEvo1Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    HydroPhantasmEvo2Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(HydroPhantasmEvo2Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 5:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    PurpleFighterIdling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(PurpleFighterIdling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    PurpleFighterEvo1Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(PurpleFighterEvo1Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    PurpleFighterEvo2Idling.transform.localScale = new Vector3(SpriteIdlingScale, SpriteIdlingScale, 1.0f);
                    Instantiate(PurpleFighterEvo2Idling, new Vector3(SpriteIdlingX, SpriteIdlingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
