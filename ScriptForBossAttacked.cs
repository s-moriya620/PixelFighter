using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForBossAttacked : MonoBehaviour
{
    public GameObject BossRedAttacked;
    public GameObject BossGreenAttacked;
    public GameObject BossBlueAttacked;
    public GameObject SwapKittyAttacked;
    public GameObject SmokeFaceAttacked;
    public GameObject SplitLadyAttacked;
    public GameObject GorillaGraffitiAttacked;
    public GameObject HitAnimation;
    void Start()
    {
        switch(BossSpriteController.ChosenBoss){
            case 0:    
            Instantiate(SwapKittyAttacked, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 1:    
            Instantiate(SmokeFaceAttacked, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 2:    
            Instantiate(SplitLadyAttacked, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 3:    
            Instantiate(GorillaGraffitiAttacked, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
        }
        switch(AttackColorController.AttackColor)
        {
            case 0:
            Instantiate(BossRedAttacked, new Vector3(0, 0, 0), Quaternion.identity);  
            break;
            case 1:
            Instantiate(BossGreenAttacked, new Vector3(0, 0, 0), Quaternion.identity);  
            break;
            case 2:
            Instantiate(BossBlueAttacked, new Vector3(0, 0, 0), Quaternion.identity);  
            break;
        }
        Instantiate(HitAnimation, new Vector3(0, 0, 0), Quaternion.identity);  
        Invoke(nameof(GoToNextScene), 3.0f);
    }
    private void GoToNextScene()
    {
        SceneManager.LoadScene("27_0 BossDefeatedScene");
    }
}
