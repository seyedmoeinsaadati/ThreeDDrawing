using System;
using UnityEditor;
using UnityEngine;

namespace SMSPackages.ThreeD
{

    public class RotatablePlane : ThreeDDrawing
    {
        Vector3[] p;
        protected override void OnDrawGizmos()
        {
            // reset z rotation
            Vector3 rotationAngles = transform.eulerAngles;
            transform.rotation = Quaternion.Euler(new Vector3(rotationAngles.x, rotationAngles.y, 0));

#if UNITY_EDITOR
            CalculateLinePoints();
#endif
            Gizmos.color = color;
            DrawLines();
            DrawPlane();
            Gizmos.DrawSphere(transform.position, .05f);
        }

        void CalculateLinePoints()
        {
            p = new Vector3[4];
            Vector3 pos = transform.position;
            p[0] = (-transform.right + transform.up) * length + pos;
            p[1] = (transform.right + transform.up) * length + pos;
            p[2] = (-transform.right - transform.up) * length + pos;
            p[3] = (transform.right - transform.up) * length + pos;
        }

        private void DrawLines()
        {
            Gizmos.DrawLine(p[0], p[1]);
            Gizmos.DrawLine(p[0], p[2]);
            Gizmos.DrawLine(p[1], p[3]);
            Gizmos.DrawLine(p[2], p[3]);
        }

        private void DrawPlane()
        {
            Quaternion m_rotation;
            m_rotation = Quaternion.LookRotation(transform.forward);
            Matrix4x4 trs = Matrix4x4.TRS(transform.position, m_rotation, Vector3.one);
            Gizmos.matrix = trs;
            Color32 m_color = color;
            m_color.a = 48;
            Gizmos.color = m_color;
            Gizmos.DrawCube(Vector3.zero, new Vector3(1.0f, 1.0f, 0.0001f) * 2 * length);
            Gizmos.matrix = Matrix4x4.identity;
            Gizmos.color = color;
        }

    }
}