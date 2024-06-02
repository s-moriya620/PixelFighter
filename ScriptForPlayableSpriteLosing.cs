using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForPlayableSpriteLosing : MonoBehaviour
{
    public GameObject RedPandaLosing;
    public GameObject RedPandaEvo1Losing;
    public GameObject RedPandaEvo2Losing;
    public GameObject PyroMonkeyLosing;
    public GameObject PyroMonkeyEvo1Losing;
    public GameObject PyroMonkeyEvo2Losing;
    public GameObject TaiyakiLosing;
    public GameObject TaiyakiEvo1Losing;
    public GameObject TaiyakiEvo2Losing;
    public GameObject UfoCatLosing;
    public GameObject UfoCatEvo1Losing;
    public GameObject UfoCatEvo2Losing;
    public GameObject HydroPhantasmLosing;
    public GameObject HydroPhantasmEvo1Losing;
    public GameObject HydroPhantasmEvo2Losing;
    public GameObject PurpleFighterLosing;
    public GameObject PurpleFighterEvo1Losing;
    public GameObject PurpleFighterEvo2Losing;
    
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayableSpriteController.ChosenColor){
            case 0:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(RedPandaLosing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(RedPandaEvo1Losing, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(RedPandaEvo2Losing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 1:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(PyroMonkeyLosing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(PyroMonkeyEvo1Losing, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(PyroMonkeyEvo2Losing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 2:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(TaiyakiLosing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(TaiyakiEvo1Losing, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(TaiyakiEvo2Losing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 3:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(UfoCatLosing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(UfoCatEvo1Losing, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(UfoCatEvo2Losing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 4:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(HydroPhantasmLosing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(HydroPhantasmEvo1Losing, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(HydroPhantasmEvo2Losing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 5:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(PurpleFighterLosing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(PurpleFighterEvo1Losing, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(PurpleFighterEvo2Losing, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
        }
        AttackColorController.AttackColor = 0;
        AttackColorController.BossAttackColor = 0;
    }
}
