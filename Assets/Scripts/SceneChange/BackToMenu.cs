using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SceneChanger
{
    [RequireComponent(typeof(Button))]
    public class BackToMenu : MonoBehaviour
    {
        Button backToMainMenu;

        void Awake()
        {
            backToMainMenu = this.GetComponent<Button>();
        }

        void Start()
        {
            
            backToMainMenu.onClick.AddListener(() => BackToMainM(0));
        }

        void BackToMainM(int scene_Number)
        {
            SceneManager.LoadScene(scene_Number);
        }
    }
}
