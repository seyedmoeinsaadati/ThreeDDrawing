using System;
using UnityEditor;
using UnityEngine;

namespace SMSPackages.ThreeD
{
    public class Point : ThreeDDrawing
    {
        public float radius = 0.5f;
        public bool drawLine;
        public Transform TransformToLine;
        public Color lineColor = Color.black;

        protected override void OnDrawGizmos()
        {
            Gizmos.color = color;
            Gizmos.DrawSphere(transform.position, radius);

            if (TransformToLine != null && drawLine)
            {
                Gizmos.color = lineColor;
                Gizmos.DrawLine(transform.position, TransformToLine.position);
            }
        }

        private void OnGUI()
        {
            if (TransformToLine != null)
            {
                float distance = Vector3.Distance(transform.position, TransformToLine.position);
                GUILayout.Label("Distance between " + transform.name + "& " + TransformToLine.name + ": " + distance);
            }
        }
    }
}