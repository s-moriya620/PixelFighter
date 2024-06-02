using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptForAttackingAnimation : MonoBehaviour
{
    public int SpriteAttackingX = 0;
    public int SpriteAttackingY = 0;
    public float SpriteAttackingScale = 0.8f;
    public int AttackIconX = 0;
    public int AttackIconY = 0;
    public float AttackIconScale = 0.8f;
    public GameObject RedAttack;
    public GameObject GreenAttack;
    public GameObject BlueAttack;
    public GameObject RedPandaAttacking;
    public GameObject RedPandaEvo1Attacking;
    public GameObject RedPandaEvo2Attacking;
    public GameObject PyroMonkeyAttacking;
    public GameObject PyroMonkeyEvo1Attacking;
    public GameObject PyroMonkeyEvo2Attacking;
    public GameObject TaiyakiAttacking;
    public GameObject TaiyakiEvo1Attacking;
    public GameObject TaiyakiEvo2Attacking;
    public GameObject UfoCatAttacking;
    public GameObject UfoCatEvo1Attacking;
    public GameObject UfoCatEvo2Attacking;
    public GameObject HydroPhantasmAttacking;
    public GameObject HydroPhantasmEvo1Attacking;
    public GameObject HydroPhantasmEvo2Attacking;
    public GameObject PurpleFighterAttacking;
    public GameObject PurpleFighterEvo1Attacking;
    public GameObject PurpleFighterEvo2Attacking;
    // Start is called before the first frame update
    void Start()
    {
        switch(PlayableSpriteController.ChosenColor){
            case 0:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    RedPandaAttacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(RedPandaAttacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    RedPandaEvo1Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(RedPandaEvo1Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    RedPandaEvo2Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(RedPandaEvo2Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 1:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    PyroMonkeyAttacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(PyroMonkeyAttacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    PyroMonkeyEvo1Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(PyroMonkeyEvo1Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    PyroMonkeyEvo2Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(PyroMonkeyEvo2Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 2:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    TaiyakiAttacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(TaiyakiAttacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    TaiyakiEvo1Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(TaiyakiEvo1Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    TaiyakiEvo2Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(TaiyakiEvo2Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 3:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    UfoCatAttacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(UfoCatAttacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    UfoCatEvo1Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(UfoCatEvo1Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    UfoCatEvo2Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(UfoCatEvo2Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 4:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    HydroPhantasmAttacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(HydroPhantasmAttacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    HydroPhantasmEvo1Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(HydroPhantasmEvo1Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    HydroPhantasmEvo2Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(HydroPhantasmEvo2Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
            case 5:
                switch(PlayableSpriteController.EvoLevel){
                    case 0:
                    PurpleFighterAttacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(PurpleFighterAttacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                    case 1:
                    PurpleFighterEvo1Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(PurpleFighterEvo1Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);
                    break;
                    case 2:
                    PurpleFighterEvo2Attacking.transform.localScale = new Vector3(SpriteAttackingScale, SpriteAttackingScale, 1.0f);
                    Instantiate(PurpleFighterEvo2Attacking, new Vector3(SpriteAttackingX, SpriteAttackingY, 0), Quaternion.identity);                   
                    break;
                }
            break;
        }
        switch(AttackColorController.AttackColor)
        {
            case 0:
            RedAttack.transform.localScale = new Vector3(AttackIconScale, AttackIconScale, 1.0f);
            Instantiate(RedAttack, new Vector3(AttackIconX, AttackIconY, 0), Quaternion.identity);  
            break;
            case 1:
            GreenAttack.transform.localScale = new Vector3(AttackIconScale, AttackIconScale, 1.0f);
            Instantiate(GreenAttack, new Vector3(AttackIconX, AttackIconY, 0), Quaternion.identity);  
            break;
            case 2:
            BlueAttack.transform.localScale = new Vector3(AttackIconScale, AttackIconScale, 1.0f);
            Instantiate(BlueAttack, new Vector3(AttackIconX, AttackIconY, 0), Quaternion.identity);  
            break;
        }
        Invoke(nameof(GoToNextScene), 3.0f);
    }
    private void GoToNextScene()
    {
        SceneManager.LoadScene("26_1 BossSpriteAttackingScene");
    }
}
