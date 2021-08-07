using UnityEngine;

namespace SMSPackages.ThreeD
{
    public class Line : ThreeDDrawing
    {
        protected override void OnDrawGizmos()
        {
            Gizmos.color = color;
            Gizmos.DrawRay(transform.position, transform.right * length);
            Gizmos.DrawRay(transform.position, -transform.right * length);
        }

    }
}