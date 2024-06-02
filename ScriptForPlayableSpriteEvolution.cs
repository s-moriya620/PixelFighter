using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForPlayableSpriteEvolution : MonoBehaviour
{
    public GameObject RedEvo;
    public GameObject RedPandaBeforeEvo1;
    public GameObject RedPandaToEvo1;
    public GameObject RedPandaBeforeEvo2;
    public GameObject RedPandaToEvo2;
    public GameObject OrangeEvo;
    public GameObject PyroMonkeyBeforeEvo1;
    public GameObject PyroMonkeyToEvo1;
    public GameObject PyroMonkeyBeforeEvo2;
    public GameObject PyroMonkeyToEvo2;
    public GameObject YellowEvo;
    public GameObject TaiyakiBeforeEvo1;
    public GameObject TaiyakiToEvo1;
    public GameObject TaiyakiBeforeEvo2;
    public GameObject TaiyakiToEvo2;
    public GameObject GreenEvo;
    public GameObject UfoCatBeforeEvo1;
    public GameObject UfoCatToEvo1;
    public GameObject UfoCatBeforeEvo2;
    public GameObject UfoCatToEvo2;
    public GameObject BlueEvo;
    public GameObject HydroPhanstasmBeforeEvo1;
    public GameObject HydroPhanstasmToEvo1;
    public GameObject HydroPhanstasmBeforeEvo2;
    public GameObject HydroPhanstasmToEvo2;
    public GameObject PurpleEvo;
    public GameObject PurpleFighterBeforeEvo1;
    public GameObject PurpleFighterToEvo1;
    public GameObject PurpleFighterBeforeEvo2;
    public GameObject PurpleFighterToEvo2;
    void Start()
    {
        switch(PlayableSpriteController.ChosenColor){
            case 0:
            Instantiate(RedEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            switch(PlayableSpriteController.EvoLevel){
                case 0:
                Instantiate(RedPandaBeforeEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(RedPandaToEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                break;
                case 1:
                Instantiate(RedPandaBeforeEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(RedPandaToEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            } 
            break;
            case 1:
            Instantiate(OrangeEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            switch(PlayableSpriteController.EvoLevel){
                case 0:
                Instantiate(PyroMonkeyBeforeEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(PyroMonkeyToEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                break;
                case 1:
                Instantiate(PyroMonkeyBeforeEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(PyroMonkeyToEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            } 
            break;
            case 2:
            Instantiate(YellowEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            switch(PlayableSpriteController.EvoLevel){
                case 0:
                Instantiate(TaiyakiBeforeEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(TaiyakiToEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                break;
                case 1:
                Instantiate(TaiyakiBeforeEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(TaiyakiToEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            } 
            break;
            case 3:
            Instantiate(GreenEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            switch(PlayableSpriteController.EvoLevel){
                case 0:
                Instantiate(UfoCatBeforeEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(UfoCatToEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                break;
                case 1:
                Instantiate(UfoCatBeforeEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(UfoCatToEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            } 
            break;
            case 4:
            Instantiate(BlueEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            switch(PlayableSpriteController.EvoLevel){
                case 0:
                Instantiate(HydroPhanstasmBeforeEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(HydroPhanstasmToEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                break;
                case 1:
                Instantiate(HydroPhanstasmBeforeEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(HydroPhanstasmToEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            } 
            break;
            case 5:
            Instantiate(PurpleEvo, new Vector3(0, 0, 0), Quaternion.identity); 
            switch(PlayableSpriteController.EvoLevel){
                case 0:
                Instantiate(PurpleFighterBeforeEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(PurpleFighterToEvo1, new Vector3(0, 0, 0), Quaternion.identity);
                break;
                case 1:
                Instantiate(PurpleFighterBeforeEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                Instantiate(PurpleFighterToEvo2, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            } 
            break;
        }
        PlayableSpriteLevelUp();
        Invoke(nameof(GoToNextScene), 3.5f);
    }
    
    public void PlayableSpriteLevelUp()
    {
            if (PlayableSpriteController.EvoLevel < 2){
                PlayableSpriteController.EvoLevel++;
            }
    }
    private void GoToNextScene()
    {
        SceneManager.LoadScene("11 MainScene");
    }
}
