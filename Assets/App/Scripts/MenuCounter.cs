using TMPro;
using UnityEngine;

namespace ButtonDisableDemo
{
    public class MenuCounter : MonoBehaviour
    {
        [SerializeField]
        private TextMeshPro textMesh;
        
        private int counter = 0;
        
        public void OkClicked()
        {
            textMesh.text = (++counter).ToString();
        }
    }
}
