using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeView : MonoBehaviour
{
    public void ChangeScene(int scene_Number)
    {
        SceneManager.LoadScene(scene_Number);
    }
}
