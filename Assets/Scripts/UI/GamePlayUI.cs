using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PrincePatel
{
    public class GamePlayUI : MonoBehaviour
    {
        public static GamePlayUI Instance { get; private set; }

        public Image playerHealthBar;

        private void Awake()
        {
            Instance = this;
        }

        public void UpdatePlayerHealthBar(int health)
        {
            playerHealthBar.fillAmount = health / 100f;
        }
    }
}
