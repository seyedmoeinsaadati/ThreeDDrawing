using UnityEngine;

namespace SMSPackages.ThreeD
{
    public class MainAxis : ThreeDDrawing
    {
        public Color XAxisColor = Color.red;
        public Color YAxisColor = Color.green;
        public Color ZAxisColor = Color.blue;
        public bool isLocalAxis;

        protected override void OnDrawGizmos()
        {
            base.OnDrawGizmos();

            if (isLocalAxis)
            {
                Gizmos.color = XAxisColor;
                Gizmos.DrawRay(transform.position, transform.right * length);
                Gizmos.DrawRay(transform.position, -transform.right * length);
                Gizmos.color = YAxisColor;
                Gizmos.DrawRay(transform.position, transform.up * length);
                Gizmos.DrawRay(transform.position, -transform.up * length);
                Gizmos.color = ZAxisColor;
                Gizmos.DrawRay(transform.position, transform.forward * length);
                Gizmos.DrawRay(transform.position, -transform.forward * length);
            }
            else
            {
                Gizmos.color = XAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.right * length);
                Gizmos.DrawRay(transform.position, -Vector3.right * length);
                Gizmos.color = YAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.up * length);
                Gizmos.DrawRay(transform.position, -Vector3.up * length);
                Gizmos.color = ZAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.forward * length);
                Gizmos.DrawRay(transform.position, -Vector3.forward * length);
                Gizmos.color = XAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.right * length);
                Gizmos.DrawRay(transform.position, -Vector3.right * length);
                Gizmos.color = YAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.up * length);
                Gizmos.DrawRay(transform.position, -Vector3.up * length);
                Gizmos.color = ZAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.forward * length);
                Gizmos.DrawRay(transform.position, -Vector3.forward * length);
            }
        }
    }
}