using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class InputController 
{
    
    public void RegisterInputController(InputField _email, InputField _password, InputField _repeatPassword, InputField _username,Button _registerButton)
    {

        switch (_email.text.IndexOf('@')<0 || _email.text.IndexOf(".")<0 || _password.text.Length<6 || _password.text != _repeatPassword.text || _username.text.Length<6)
        {
            case true:
                _registerButton.interactable = false;
                break;
            default:
                _registerButton.interactable = true;
                break; 
        }
        _username.text = Regex.Replace(_username.text, "[^\\w\\._]", "");
        _username.text = Regex.Replace(_username.text, "[ş,Ş,ğ,Ğ,ç, ý, ü, ð, ö, þ, Ý, Ð, Ü, Ö, Þ, Ç,.]", "");
        _password.text = Regex.Replace(_password.text, "[ç, ý, ü, ð, ö, þ, Ý, Ð, Ü, Ö, Þ, Ç]", "");

    }

    


}
