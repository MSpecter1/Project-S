using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

public class CharInputBuffer : MonoBehaviour
{
    public CharInputEngine charInputEngine;
    public float inputWindow = 36f;
    [SerializeField]
    private float currentInputWindow = 0;
    public bool midclear=false;
    public enum input
    {
        //direction
        left,
        right,
        up,
        down,
        //buttons
        light,
        medium,
        heavy,
        special
    }
    private Stack<input> DetectedInputs = new Stack<input>();
    //private List<input> PrevInputs = new List<input>();
    private input[] PrevInputs;

    private void Update()
    {
        if (currentInputWindow>0)
        {
            currentInputWindow -= Time.deltaTime;
        }
        else if (currentInputWindow == 0)
        {
            StartCoroutine(ClearAfterTime(0 / 60f));
        }
    }

    public void BufferInput(input currentInput)
    {

        DetectedInputs.Push(currentInput);
        currentInputWindow = 12;

        
        if (currentInput == input.light || currentInput == input.medium || currentInput == input.heavy || currentInput == input.special) //check if attack was buffered and detect special input
        {
            DetectedInputs.Pop();
            PrevInputs = DetectedInputs.ToArray();
            for (int i = 0; i <= PrevInputs.Length; i++)
            {
                //Debug.Log("READING ARRAY...");
                if (PrevInputs.Length >= 3 && i < PrevInputs.Length - 2 && PrevInputs[i] == input.right && PrevInputs[i + 1] == input.down && PrevInputs[i + 2] == input.right)
                {
                    //Debug.Log("DP INPUT DETECTED");
                    break;
                }
                else if (PrevInputs.Length >= 1 && i < PrevInputs.Length - 1 && PrevInputs[i] == input.right && PrevInputs[i + 1] == input.down)
                {
                    //Debug.Log("QCF INPUT DETECTED");
                    switch (currentInput)
                    {
                        case input.light:
                            charInputEngine.animator.ResetTrigger("lightNormal");
                            charInputEngine.CharacterFunctions.SpecialAttack1(1);
                            break;
                        case input.medium:
                            charInputEngine.animator.ResetTrigger("mediumNormal");
                            charInputEngine.CharacterFunctions.SpecialAttack1(2);
                            break;
                        case input.heavy:
                            charInputEngine.animator.ResetTrigger("heavyNormal");
                            charInputEngine.CharacterFunctions.SpecialAttack1(3);
                            break;
                    }
                    break;
                }
                else if (PrevInputs.Length >= 1 && i < PrevInputs.Length - 1 && PrevInputs[i] == input.left && PrevInputs[i+1] == input.down)
                {
                    //Debug.Log("QCB INPUT DETECTED");
                    break;
                }
                else
                {
                    //Debug.Log("NO SPECIAL INPUT DETECTED");
                    switch (currentInput)
                    {
                        case input.light:
                            charInputEngine.animator.ResetTrigger("lightNormal");
                            charInputEngine.animator.SetTrigger("lightNormal");
                            break;
                        case input.medium:
                            charInputEngine.animator.ResetTrigger("mediumNormal");
                            charInputEngine.animator.SetTrigger("mediumNormal");
                            break;
                        case input.heavy:
                            charInputEngine.animator.ResetTrigger("heavyNormal");
                            charInputEngine.animator.SetTrigger("heavyNormal");
                            break;
                        case input.special:
                            //charInputEngine.animator.ResetTrigger("specialAttack1");
                            //charInputEngine.animator.SetTrigger("specialAttack1");
                            charInputEngine.CharacterFunctions.SpecialAttack1(1);
                            break;
                    }
                }
                DetectedInputs.Clear();
            }
        }
    }

    public void PrintPastInputs()
    {
        string inputstring="";
        foreach (input item in DetectedInputs.ToArray())
        {
            switch (item)
            {
                case input.left:
                    inputstring+=("left, ");
                    break;
                case input.right:
                    inputstring += ("right, ");
                    break;
                case input.up:
                    inputstring += ("up, ");
                    break;
                case input.down:
                    inputstring += ("down, ");
                    break;
                case input.light:
                    inputstring += ("light, ");
                    break;
                case input.medium:
                    inputstring += ("medium, ");
                    break;
                case input.heavy:
                    inputstring += ("heavy, ");
                    break;
                case input.special:
                    inputstring += ("special, ");
                    break;
                default:

                    break;
            }
        }
        Debug.Log(inputstring);
    }

    public void ClearAttackInputs()
    {
        StartCoroutine(ClearAfterTime(0 / 60f));
    }
    IEnumerator ClearAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        DetectedInputs.Clear();
        charInputEngine.animator.ResetTrigger("lightNormal");
        charInputEngine.animator.ResetTrigger("mediumNormal");
        charInputEngine.animator.ResetTrigger("heavyNormal");
    }
}

