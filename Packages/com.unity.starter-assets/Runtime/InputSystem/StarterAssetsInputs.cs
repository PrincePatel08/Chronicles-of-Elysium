using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[HideInInspector] public ThirdPersonController characterController;

		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		[Header("Abilities Input Values")]
		public bool showAbilities;
		public bool mouseLeftClick;
		public bool mouseRightClick;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = true;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM
		public void OnMove(InputValue value)
		{
            if (characterController.IsBusy)
                move = Vector2.zero;
			else
				move = value.Get<Vector2>();
		}

		public void OnLook(InputValue value)
		{
			if(cursorInputForLook)
			{
				look = value.Get<Vector2>();
			}
		}

		public void OnJump(InputValue value)
		{
			if(characterController.IsBusy)
                jump = false;
			else
				jump = value.isPressed;
		}

		public void OnSprint(InputValue value)
		{
			if (characterController.IsBusy)
                sprint = false;
            else
                sprint = value.isPressed;
		}

        public void OnShowAbilities(InputValue value)
        {
            if (characterController.IsBusy)
                showAbilities = false;
            else
				showAbilities = value.isPressed;
        }

		public void OnMouseLeft(InputValue value)
		{
            if (characterController.IsBusy)
                mouseLeftClick = false;
			else
				mouseLeftClick = value.isPressed;
        }

		public void OnMouseRight(InputValue value)
		{
            if (characterController.IsBusy)
                mouseRightClick = false;
			else
				mouseRightClick = value.isPressed;
		}
#endif


        public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}
		
		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}