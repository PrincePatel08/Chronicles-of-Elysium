using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PrincePatel
{
    public class AbilitiesManager : MonoBehaviour
    {
        public GameObject abilitiesSwichUIMenu;

        private StarterAssetsInputs _inputs;

        private void Awake()
        {
            _inputs = GetComponentInParent<StarterAssetsInputs>();
        }

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            abilitiesSwichUIMenu.SetActive(_inputs.showAbilities);
        }
    }
}
