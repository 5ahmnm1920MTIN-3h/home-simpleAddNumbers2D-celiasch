using UnityEngine;
using UnityEngine.UI;

public class ComputerNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    public Text result;

    public Button addnumbersButton;
    public Button resetButton;

    float varA;
    float varB;

    public void SetResult()
    {
        result.text = AddNumbers();

        input1.interactable = false;
        input2.interactable = false;

        addnumbersButton.interactable = false;
        resetButton.interactable = true;
    }
    string AddNumbers()
    {
            varA = float.Parse(input1.text);
            varB = float.Parse(input2.text);

            string success = (varA + varB).ToString();
            return success;
        }

    public void ResetCounter()
    {
        input1.text = "0";
        input2.text = "0";
        result.text = "insert numbers";

        input1.interactable = true;
        input2.interactable = true;
        addnumbersButton.interactable = true;
        resetButton.interactable = false;
    }
}
