using UnityEngine;
using UnityEngine.UI;

namespace ScriptHandler
{
    public class ScriptImplementDemo : MonoBehaviour
    {
        public Text awake_Notifier;
        public Text start_Notifier;
        public Text event_Notifier;   

        void Awake()
        {
            awake_Notifier.text = this.name + "Object is Initialized. But script is not.";
        }
        
        void Start()
        {
            start_Notifier.text = "Script is initialized, now you can press f.";
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0))
            {
                event_Notifier.text = "Either F or Left Mouse button is pressed";
            }

            /*if (Input.GetKey(KeyCode.F))
            {
                Debug.Log("F is pressed.");
            }*/

            if (Input.GetKeyUp(KeyCode.F))
            {
                event_Notifier.text = "Either F is released";
            }
        }

        void OnDestroy()
        {
            awake_Notifier.text = this.name + "Object is destroyed, Please restart";
            start_Notifier.text = "";
            event_Notifier.text = "";
        }
    }
}
