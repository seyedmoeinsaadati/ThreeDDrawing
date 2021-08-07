using UnityEngine;

namespace SMSPackages.ThreeD
{
    public abstract class ThreeDDrawing : MonoBehaviour
    {
        public Color color = Color.black;
        public float lenght = 1;

        protected virtual void OnDrawGizmos()
        {
        }
    }
}