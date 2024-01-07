using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PrincePatel
{
    public class PieMenuItem : MonoBehaviour
    {
        public Color hoverColor;
        public Color baseColor;
        public Image background;

        private Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
            background.color = baseColor;
        }

        public void Select()
        {
            background.color = hoverColor;
            animator.Play("Select");
        }

        public void Deselect()
        {
            background.color = baseColor;
            animator.Play("Deselect");
        }
    }
}
