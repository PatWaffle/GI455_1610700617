using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code : MonoBehaviour
{
    public Button search;
    public InputField input;
    public Text resalt2;
    public string database1 = "dog";
    public string database2 = "cat";
    public string database3 = "fish";
    public string database4 = "bird";
    public string database5 = "duck";
    public void searchdata()
    {
        if (input.text == database1)
        {
            resalt();
        }
        else if (input.text == database2)
        {
            resalt();
        }
        else if (input.text == database3)
        {
            resalt();
        }
        else if (input.text == database4)
        {
            resalt();
        }
        else if (input.text == database5 )
        {
            resalt();
        }
        else 
        {
            resalt02();
        }
    }
    public void resalt()
    {
        resalt2.text = "[" + input.text + "]" + " Is Found";
    }
    public void resalt02()
    {
        resalt2.text = "[" + input.text + "]" + " Is Not Found";
    }
}