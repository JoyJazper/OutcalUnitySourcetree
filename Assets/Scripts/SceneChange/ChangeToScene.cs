using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace SceneChanger
{
    class ChangeToScene : MonoBehaviour
    {
        public Button toScene1;
        public Button toScene2;
        public Button toScene3;

        void Start()
        {
            toScene1.onClick.AddListener(() => ChangeScene(1));
            toScene2.onClick.AddListener(() => ChangeScene(2));
            toScene3.onClick.AddListener(() => ChangeScene(3));
        }

        void ChangeScene(int scene_Number)
        {
            SceneManager.LoadScene(scene_Number);
        }
    }
}
