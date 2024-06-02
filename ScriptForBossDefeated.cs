using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForBossDefeated : MonoBehaviour
{
    public GameObject SwapKittyDefeated;
    public GameObject SmokeFaceDefeated;
    public GameObject SplitLadyDefeated;
    public GameObject GorillaGraffitiDefeated;    
    void Start()
    {
        switch(BossSpriteController.ChosenBoss){
            case 0:
            Instantiate(SwapKittyDefeated, new Vector3(0, 0, 0), Quaternion.identity);
            BossSpriteController.IsSwapKittyDefeated = 1;                
            break;
            case 1:
            Instantiate(SmokeFaceDefeated, new Vector3(0, 0, 0), Quaternion.identity);  
            BossSpriteController.IsSmokeFaceDefeated = 1;               
            break;
            case 2: 
            Instantiate(SplitLadyDefeated, new Vector3(0, 0, 0), Quaternion.identity);   
            BossSpriteController.IsSplitLadyDefeated = 1;           
            break;
            case 3:
            Instantiate(GorillaGraffitiDefeated, new Vector3(0, 0, 0), Quaternion.identity);
            BossSpriteController.IsSwapKittyDefeated = 0; 
            BossSpriteController.IsSmokeFaceDefeated = 0; 
            BossSpriteController.IsSplitLadyDefeated = 0;                    
            break;
        }
        Invoke(nameof(GoToNextScene), 4.0f);
    }
    
    private void GoToNextScene()
    {
        SceneManager.LoadScene("27_2 PlayableSpriteWinningScene");
    }


}
