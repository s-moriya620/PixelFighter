using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForPlayableSpriteAppearing : MonoBehaviour
{
    public GameObject RedEvo;
    public GameObject RedPandaAppearing;
    public GameObject OrangeEvo;
    public GameObject PyroMonkeyAppearing;
    public GameObject YellowEvo;
    public GameObject TaiyakiAppearing;
    public GameObject GreenEvo;
    public GameObject UfoCatAppearing;
    public GameObject BlueEvo;
    public GameObject HydroPhantasmAppearing;
    public GameObject PurpleEvo;
    public GameObject PurpleFighterAppearing;
    void Start()
    {
        if (DemoModeController.IsDemoModeOn == 1) {
            if (SceneManager.GetActiveScene().name == "42 GetSpriteScene") {
                PlayableSpriteController.ChosenColor = 2;
                PlayableSpriteController.EvoLevel = 0;
            }
        }
        switch(PlayableSpriteController.ChosenColor){
            case 0:
            Instantiate(RedEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            Instantiate(RedPandaAppearing, new Vector3(0, 0, 0), Quaternion.identity); 
            PlayableSpriteController.RValue = 50;
            PlayableSpriteController.GValue = 0;
            PlayableSpriteController.BValue = 0;
            break;
            case 1:
            Instantiate(OrangeEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            Instantiate(PyroMonkeyAppearing, new Vector3(0, 0, 0), Quaternion.identity); 
            PlayableSpriteController.RValue = 25;
            PlayableSpriteController.GValue = 15;
            PlayableSpriteController.BValue = 10;
            break;
            case 2:
            Instantiate(YellowEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            Instantiate(TaiyakiAppearing, new Vector3(0, 0, 0), Quaternion.identity); 
            PlayableSpriteController.RValue = 0;
            PlayableSpriteController.GValue = 25;
            PlayableSpriteController.BValue = 25;
            break;
            case 3:
            Instantiate(GreenEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            Instantiate(UfoCatAppearing, new Vector3(0, 0, 0), Quaternion.identity); 
            PlayableSpriteController.RValue = 0;
            PlayableSpriteController.GValue = 50;
            PlayableSpriteController.BValue = 0;
            break;
            case 4:
            Instantiate(BlueEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            Instantiate(HydroPhantasmAppearing, new Vector3(0, 0, 0), Quaternion.identity); 
            PlayableSpriteController.RValue = 0;
            PlayableSpriteController.GValue = 0;
            PlayableSpriteController.BValue = 50;
            break;
            case 5:
            Instantiate(PurpleEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            Instantiate(PurpleFighterAppearing, new Vector3(0, 0, 0), Quaternion.identity); 
            PlayableSpriteController.RValue = 25;
            PlayableSpriteController.GValue = 0;
            PlayableSpriteController.BValue = 25;
            break;
        }
        Invoke(nameof(GoToNextScene), 3.5f);
    }
    
    private void GoToNextScene()
    {
        if (SceneManager.GetActiveScene().name == "09 GetSpriteFirstTimeScene"){
            if (DemoModeController.IsDemoModeOn == 1){
                SceneManager.LoadScene("11 MainScene");
            } else {
                SceneManager.LoadScene("03 MainSceneIntroductionScene");
            }
        } else if (SceneManager.GetActiveScene().name == "42 GetSpriteScene"){
            SceneManager.LoadScene("11 MainScene");
        }
        
    }
}
