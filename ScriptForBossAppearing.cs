using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForBossAppearing : MonoBehaviour
{
    public int BossAppearingX = -4;
    public int BossAppearingY = 0;
    public float BossAppearingScale = 0.8f;
    public GameObject SwapKittyAppearing;
    public GameObject SmokeFaceAppearing;
    public GameObject SplitLadyAppearing;
    public GameObject GorillaGraffitiAppearing;
    // Start is called before the first frame update
    void Start()
    {
        switch(BossSpriteController.ChosenBoss){
            case 0:    
            SwapKittyAppearing.transform.localScale = new Vector3(BossAppearingScale, BossAppearingScale, 1.0f);
            Instantiate(SwapKittyAppearing, new Vector3(BossAppearingX, BossAppearingY, 0), Quaternion.identity);                   
            break;
            case 1:    
            SmokeFaceAppearing.transform.localScale = new Vector3(BossAppearingScale, BossAppearingScale, 1.0f);
            Instantiate(SmokeFaceAppearing, new Vector3(BossAppearingX, BossAppearingY, 0), Quaternion.identity);                   
            break;
            case 2:    
            SplitLadyAppearing.transform.localScale = new Vector3(BossAppearingScale, BossAppearingScale, 1.0f);
            Instantiate(SplitLadyAppearing, new Vector3(BossAppearingX, BossAppearingY, 0), Quaternion.identity);                   
            break;
            case 3:    
            GorillaGraffitiAppearing.transform.localScale = new Vector3(BossAppearingScale, BossAppearingScale, 1.0f);
            Instantiate(GorillaGraffitiAppearing, new Vector3(BossAppearingX, BossAppearingY, 0), Quaternion.identity);                   
            break;
        }
        Invoke(nameof(GoToNextScene), 4.5f);
    }

    private void GoToNextScene()
    {
        SceneManager.LoadScene("24_1 StartFightingScene");
    }
}
