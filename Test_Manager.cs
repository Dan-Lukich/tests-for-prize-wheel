using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Manager : MonoBehaviour
{
    public static IDictionary<int, int> caseAndProbability = 
        new Dictionary<int, int>();
    public static int currentTestCase = 0;
    public static bool oneSpun = true;
    public static bool errorsDetected = false;

    private void initializeCaseAndProbability ()
    {
        caseAndProbability.Add(1, 1);
        caseAndProbability.Add(2, 6);
        caseAndProbability.Add(3, 16);
        caseAndProbability.Add(4, 66);
        caseAndProbability.Add(5, 116);
        caseAndProbability.Add(6, 196);
        caseAndProbability.Add(7, 276);
        caseAndProbability.Add(8, 356);
        caseAndProbability.Add(9, 436);
        caseAndProbability.Add(10, 516);
        caseAndProbability.Add(11, 596);
        caseAndProbability.Add(12, 676);
        caseAndProbability.Add(13, 756);
        caseAndProbability.Add(14, 836);
    }

    void Start() {
        initializeCaseAndProbability();
    }

    public static bool correctCaseNumberTest()
    {
        switch (Wheel_Animation_Manager.randomNumber)
        {
            case int n when (n >= 1 && n <= 5):
                // Case 1 Super Rare
                if (Wheel_Animation_Manager.caseNumber == 1)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 6 && n <= 15):
                // Case 2 Rare
                if (Wheel_Animation_Manager.caseNumber == 2)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 16 && n <= 65):
                // Case 3 Uncommon
                if (Wheel_Animation_Manager.caseNumber == 3)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 66 && n <= 115):
                // Case 4 Uncommon
                if (Wheel_Animation_Manager.caseNumber == 4)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 116 && n <= 195):
                // Case 5 Common
                if (Wheel_Animation_Manager.caseNumber == 5)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 196 && n <= 275):
                // Case 6 Common
                if (Wheel_Animation_Manager.caseNumber == 6)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 276 && n <= 355):
                // Case 7 Common
                if (Wheel_Animation_Manager.caseNumber == 7)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 356 && n <= 435):
                // Case 8 Common
                if (Wheel_Animation_Manager.caseNumber == 8)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 436 && n <= 515):
                // Case 9 Common
                if (Wheel_Animation_Manager.caseNumber == 9)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 516 && n <= 595):
                // Case 10 Common
                if (Wheel_Animation_Manager.caseNumber == 10)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 596 && n <= 675):
                // Case 11 Common
                if (Wheel_Animation_Manager.caseNumber == 11)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 676 && n <= 755):
                // Case 12 Common
                if (Wheel_Animation_Manager.caseNumber == 12)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 756 && n <= 835):
                // Case 13 Common
                if (Wheel_Animation_Manager.caseNumber == 13)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            case int n when (n >= 836 && n <= 915):
                // Case 14 Common
                if (Wheel_Animation_Manager.caseNumber == 14)
                {
                    Debug.Log("TEST: Correct case.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect case.");
                    return false;
                }
            default:
                // code block
                break;
        }
        return false;
    }

    public static bool correctRewardTest()
    {
        switch (Wheel_Animation_Manager.caseNumber)
        {
            case 1:
                // Case 1 Super Rare
                if (Wheel_Animation_Manager.reward == 
                    Wheel_Animation_Manager.rewards.JACKPOT.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                } 
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 2:
                // Case 2 Rare
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.MUTATION_ITEM.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 3:
                // Case 3 Uncommon
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.DEVILDROP.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 4:
                // Case 4 Uncommon
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.CHOMPDROP.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 5:
                // Case 5 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.NOTHING.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 6:
                // Case 6 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.POOP_PET.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 7:
                // Case 7 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.GARBAGE.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 8:
                // Case 8 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.CRUMBS.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 9:
                // Case 9 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.BLANK_COMMON_GOOMDROP.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 10:
                // Case 10 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.UNCOMMON_GOOMDROP.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 11:
                // Case 11 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.UMAMI_GOOMPLING.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 12:
                // Case 12 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.GOOM_PROFILE_SKIN.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 13:
                // Case 13 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.GOOMBERRY.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            case 14:
                // Case 14 Common
                if (Wheel_Animation_Manager.reward ==
                    Wheel_Animation_Manager.rewards.TREAT.ToString().Replace("_", " "))
                {
                    Debug.Log("TEST: Correct reward.");
                    return true;
                }
                else
                {
                    Debug.Log("TEST: Incorrect reward.");
                    return false;
                }
            default:
                // code block
                break;
        }
        return false;
    }

}
