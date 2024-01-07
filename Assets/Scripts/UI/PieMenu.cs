using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class PieMenu : MonoBehaviour
    {
        public Vector2 normalizedMousePosition;
        public float currentAngle;
        public int selection;
        private int previousSelection;

        public PieMenuItem[] menuItems;
        private PieMenuItem selectedMenuItem;
        private PieMenuItem previousMenuItem;

        private void Update()
        {
            normalizedMousePosition = new Vector2(Input.mousePosition.x - Screen.width/2, Input.mousePosition.y - Screen.height/2);
            currentAngle = Mathf.Atan2(normalizedMousePosition.y, normalizedMousePosition.x) * Mathf.Rad2Deg;

            currentAngle = (currentAngle + 360) % 360;

            selection = (int) (currentAngle / (360 / transform.childCount));

            if(selection != previousSelection)
            {
                selectedMenuItem = menuItems[selection];
                selectedMenuItem.Select();

                if (previousMenuItem != null)
                {
                    previousMenuItem.Deselect();
                }

                previousMenuItem = selectedMenuItem;
                previousSelection = selection;
            }
        }

        private void OnEnable()
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }

        private void OnDisable()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
