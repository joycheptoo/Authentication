using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;


public class PlayfabManager : MonoBehaviour
{
public Text messageText;
    public InputField userEmail;
    public InputField userPassword;
     // Consolidate the declarations into one line

    // Register/Login/ResetPassword
    public void SignUp(){
        var request = new RegisterPlayFabUserRequest
        {
            Email = userEmail.text,
            Password = userPassword.text,
            RequireBothUsernameAndEmail =false
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, RegisterSuccess, RegisterError);
    }


public void RegisterSuccess(RegisterPlayFabUserResult result)
{
    messageText.text="Registered and logged in!";
}

public void RegisterError(PlayFabError error)
{
   messageText.text = error.ErrorMessage;
   Debug.Log(error.GenerateErrorReport());
}
   
}
