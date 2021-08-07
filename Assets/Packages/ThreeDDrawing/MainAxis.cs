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
                Gizmos.DrawRay(transform.position, transform.right * lenght);
                Gizmos.DrawRay(transform.position, -transform.right * lenght);
                Gizmos.color = YAxisColor;
                Gizmos.DrawRay(transform.position, transform.up * lenght);
                Gizmos.DrawRay(transform.position, -transform.up * lenght);
                Gizmos.color = ZAxisColor;
                Gizmos.DrawRay(transform.position, transform.forward * lenght);
                Gizmos.DrawRay(transform.position, -transform.forward * lenght);
            }
            else
            {
                Gizmos.color = XAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.right * lenght);
                Gizmos.DrawRay(transform.position, -Vector3.right * lenght);
                Gizmos.color = YAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.up * lenght);
                Gizmos.DrawRay(transform.position, -Vector3.up * lenght);
                Gizmos.color = ZAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.forward * lenght);
                Gizmos.DrawRay(transform.position, -Vector3.forward * lenght);
                Gizmos.color = XAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.right * lenght);
                Gizmos.DrawRay(transform.position, -Vector3.right * lenght);
                Gizmos.color = YAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.up * lenght);
                Gizmos.DrawRay(transform.position, -Vector3.up * lenght);
                Gizmos.color = ZAxisColor;
                Gizmos.DrawRay(transform.position, Vector3.forward * lenght);
                Gizmos.DrawRay(transform.position, -Vector3.forward * lenght);
            }
        }
    }
}