using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;

public class CharInputBuffer : MonoBehaviour
{
    public CharInputEngine charInputEngine;
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

    private void FixedUpdate()
    {
        if (!midclear)
        {
            StartCoroutine(ClearAfterTime(2f));
        }
    }

    public void BufferInput(input currentInput)
    {
        //if (currentInput == input.light || currentInput == input.medium || currentInput == input.heavy || currentInput == input.special) //check if attack, if so can stack multiple times
        //{
        //    DetectedInputs.Push(currentInput);
        //}
        //else if (DetectedInputs.Count == 0 || DetectedInputs.Peek() != currentInput) //if direction, must be unique to adjacent input
        //{
        //    DetectedInputs.Push(currentInput);
        //}

        DetectedInputs.Push(currentInput);

        
        if (currentInput == input.light || currentInput == input.medium || currentInput == input.heavy || currentInput == input.special) //check if attack was buffered and detect special input
        {
            DetectedInputs.Pop();
            //foreach (input item in DetectedInputs.ToArray())
            //{
            //    PrevInputs.Add(item);
            //    DetectedInputs.Pop();
            //}
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
                            charInputEngine.animator.ResetTrigger("specialAttack1");
                            charInputEngine.animator.SetTrigger("specialAttack1");
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
    IEnumerator ClearAfterTime(float time)
    {
        midclear = true;
        yield return new WaitForSeconds(time);
        //Debug.Log("MIDCLEAR=FALSE");
        midclear = false;
        //Debug.Log("CLEAR STACK");
        //PrintPastInputs();
        DetectedInputs.Clear();
        charInputEngine.animator.ResetTrigger("lightNormal");
        charInputEngine.animator.ResetTrigger("mediumNormal");
        charInputEngine.animator.ResetTrigger("heavyNormal");
        //midclear = false;
    }
}

