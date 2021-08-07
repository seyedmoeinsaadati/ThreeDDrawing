using UnityEngine;

namespace SMSPackages.ThreeD
{
    public enum AxisType
    {
        X,
        Y,
        Z
    }

    public class Axis : ThreeDDrawing
    {

        public AxisType axisType;

        protected override void OnDrawGizmos()
        {
            Gizmos.color = color;
            switch (axisType)
            {
                case AxisType.X:
                    Gizmos.DrawRay(transform.position, Vector3.right * lenght);
                    Gizmos.DrawRay(transform.position, -Vector3.right * lenght);
                    break;
                case AxisType.Y:
                    Gizmos.DrawRay(transform.position, Vector3.up * lenght);
                    Gizmos.DrawRay(transform.position, -Vector3.up * lenght);
                    break;
                case AxisType.Z:
                    Gizmos.DrawRay(transform.position, Vector3.forward * lenght);
                    Gizmos.DrawRay(transform.position, -Vector3.forward * lenght);
                    break;
                default:
                    break;
            }
        }

    }

}