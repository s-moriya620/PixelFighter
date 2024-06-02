using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForPlayableSpriteWinning : MonoBehaviour
{
    public GameObject RedPandaWinning;
    public GameObject RedPandaEvo1Winning;
    public GameObject RedPandaEvo2Winning;
    public GameObject PyroMonkeyWinning;
    public GameObject PyroMonkeyEvo1Winning;
    public GameObject PyroMonkeyEvo2Winning;
    public GameObject TaiyakiWinning;
    public GameObject TaiyakiEvo1Winning;
    public GameObject TaiyakiEvo2Winning;
    public GameObject UfoCatWinning;
    public GameObject UfoCatEvo1Winning;
    public GameObject UfoCatEvo2Winning;
    public GameObject HydroPhantasmWinning;
    public GameObject HydroPhantasmEvo1Winning;
    public GameObject HydroPhantasmEvo2Winning;
    public GameObject PurpleFighterWinning;
    public GameObject PurpleFighterEvo1Winning;
    public GameObject PurpleFighterEvo2Winning;
    
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayableSpriteController.ChosenColor){
            case 0:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(RedPandaWinning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(RedPandaEvo1Winning, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(RedPandaEvo2Winning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 1:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(PyroMonkeyWinning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(PyroMonkeyEvo1Winning, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(PyroMonkeyEvo2Winning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 2:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(TaiyakiWinning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(TaiyakiEvo1Winning, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(TaiyakiEvo2Winning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 3:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(UfoCatWinning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(UfoCatEvo1Winning, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(UfoCatEvo2Winning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 4:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(HydroPhantasmWinning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(HydroPhantasmEvo1Winning, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(HydroPhantasmEvo2Winning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 5:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    Instantiate(PurpleFighterWinning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    Instantiate(PurpleFighterEvo1Winning, new Vector3(0, 0, 0), Quaternion.identity);
                    break;
                    case 2:
                    Instantiate(PurpleFighterEvo2Winning, new Vector3(0, 0, 0), Quaternion.identity);                   
                    break;
                }
            break;
        }
        GetEXP();
        AttackColorController.AttackColor = 0;
        AttackColorController.BossAttackColor = 0;
    }
    public void GetEXP()
    {
        if (PlayableSpriteController.EvoLevel < 2){
            PlayableSpriteController.EXP -= 500;
            if (PlayableSpriteController.EXP <= 0) {
                PlayableSpriteController.EXP += 1000;
                if (DemoModeController.IsDemoModeOn == 1) {
                    SceneManager.LoadScene("43 SpriteEvolutionScene");
                }               
            }
        }
    }
}
