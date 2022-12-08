using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetNameController : MonoBehaviour
{

    public TextMeshProUGUI user_name;
    public TMP_InputField user_inputField;
    
    
    public void setName()
    {
        user_name.text  = user_inputField.text;
    }

    public void restName()
    {
        user_name.text = "Please enter your name again";
    }
}