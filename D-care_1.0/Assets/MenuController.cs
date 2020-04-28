using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ButtonSignUp(){
        SceneManager.LoadScene(1);
    }
    public void ButtonSignIn(){
        SceneManager.LoadScene(2);
    }
}
