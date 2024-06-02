using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForAttacksMeetingWin : MonoBehaviour
{
    public GameObject RedAttackInMeetingScene;
    public GameObject GreenAttackInMeetingScene;
    public GameObject BlueAttackInMeetingScene;
    public GameObject BossRedAttackInMeetingScene;
    public GameObject BossGreenAttackInMeetingScene;
    public GameObject BossBlueAttackInMeetingScene;

    // Start is called before the first frame update
    void Start()
    {
        switch(AttackColorController.AttackColor){
            case 0:
            Instantiate(RedAttackInMeetingScene, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 1: 
            Instantiate(GreenAttackInMeetingScene, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 2:
            Instantiate(BlueAttackInMeetingScene, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
        }
        switch(AttackColorController.BossAttackColor){
            case 0:
            Instantiate(BossRedAttackInMeetingScene, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 1: 
            Instantiate(BossGreenAttackInMeetingScene, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
            case 2:
            Instantiate(BossBlueAttackInMeetingScene, new Vector3(0, 0, 0), Quaternion.identity);                   
            break;
        }
        Invoke(nameof(GoToNextScene), 6.0f);
    }

    private void GoToNextScene()
    {
        SceneManager.LoadScene("26_4 BossAttackedScene");
    }
}
