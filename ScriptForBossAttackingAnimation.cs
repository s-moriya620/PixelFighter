using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForBossAttackingAnimation : MonoBehaviour
{
    public int BossAttackingX = -4;
    public int BossAttackingY = 0;
    public float BossAttackingScale = 0.8f;
    public int BossAttackIconX = 0;
    public int BossAttackIconY = 0;
    public float BossAttackIconScale = 0.8f;
    public GameObject BossRedAttack;
    public GameObject BossGreenAttack;
    public GameObject BossBlueAttack;
    public GameObject SwapKittyAttacking;
    public GameObject SmokeFaceAttacking;
    public GameObject SplitLadyAttacking;
    public GameObject GorillaGraffitiAttacking;
    // Start is called before the first frame update
    void Start()
    {
        switch(BossSpriteController.ChosenBoss){
            case 0:    
            SwapKittyAttacking.transform.localScale = new Vector3(BossAttackingScale, BossAttackingScale, 1.0f);
            Instantiate(SwapKittyAttacking, new Vector3(BossAttackingX, BossAttackingY, 0), Quaternion.identity);                   
            break;
            case 1:    
            SmokeFaceAttacking.transform.localScale = new Vector3(BossAttackingScale, BossAttackingScale, 1.0f);
            Instantiate(SmokeFaceAttacking, new Vector3(BossAttackingX, BossAttackingY, 0), Quaternion.identity);                   
            break;
            case 2:    
            SplitLadyAttacking.transform.localScale = new Vector3(BossAttackingScale, BossAttackingScale, 1.0f);
            Instantiate(SplitLadyAttacking, new Vector3(BossAttackingX, BossAttackingY, 0), Quaternion.identity);                   
            break;
            case 3:    
            GorillaGraffitiAttacking.transform.localScale = new Vector3(BossAttackingScale, BossAttackingScale, 1.0f);
            Instantiate(GorillaGraffitiAttacking, new Vector3(BossAttackingX, BossAttackingY, 0), Quaternion.identity);                   
            break;
        }
        switch(AttackColorController.BossAttackColor)
        {
            case 0:
            BossRedAttack.transform.localScale = new Vector3(BossAttackIconScale, BossAttackIconScale, 1.0f);
            Instantiate(BossRedAttack, new Vector3(BossAttackIconX, BossAttackIconY, 0), Quaternion.identity);  
            break;
            case 1:
            BossGreenAttack.transform.localScale = new Vector3(BossAttackIconScale, BossAttackIconScale, 1.0f);
            Instantiate(BossGreenAttack, new Vector3(BossAttackIconX, BossAttackIconY, 0), Quaternion.identity);  
            break;
            case 2:
            BossBlueAttack.transform.localScale = new Vector3(BossAttackIconScale, BossAttackIconScale, 1.0f);
            Instantiate(BossBlueAttack, new Vector3(BossAttackIconX, BossAttackIconY, 0), Quaternion.identity);  
            break;
        }
        Invoke(nameof(GoToNextScene), 3.0f);
    }
    private void GoToNextScene()
    {
        if (AttackColorController.DidPlayerWin == 1){
            SceneManager.LoadScene("26_2 AttackMeetingWinScene");
        } else if (AttackColorController.DidPlayerWin == 0){
            SceneManager.LoadScene("26_3 AttackMeetingLoseScene");
        }
    }

}
