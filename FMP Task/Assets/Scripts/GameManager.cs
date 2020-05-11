using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public string Scenetogoto;


    public void CompleteLevel()
    {
        SceneManager.LoadScene(Scenetogoto);
    }
}
