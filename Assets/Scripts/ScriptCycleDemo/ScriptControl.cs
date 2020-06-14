using UnityEngine;

namespace ScriptHandler
{
    [RequireComponent(typeof(ScriptImplementDemo))]
    public class ScriptControl:MonoBehaviour
    {
        ScriptImplementDemo scriptBase;

        void Start()
        {
            scriptBase = this.GetComponent<ScriptImplementDemo>();
        }

        public void EnableScript()
        {
            scriptBase.enabled = true;
        }

        public void DestroyScript()
        {
            Debug.Log("Ran this.");
            Destroy(this.gameObject);
        }
    }
}
