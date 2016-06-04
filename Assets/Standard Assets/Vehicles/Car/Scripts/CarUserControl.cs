using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
		public KeyCode left;
		public KeyCode right;
		public KeyCode up;
		public KeyCode down;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
			// pass the input to the car!
			//float h = CrossPlatformInputManager.GetAxis("Horizontal");
			//float v = CrossPlatformInputManager.GetAxis("Vertical");

			float h = 0;
			float v = 0;

			if (Input.GetKey(right)) {
				h += 1;
			}
			if (Input.GetKey(left)) {
				h -= 1;
			}
			if (Input.GetKey(down)) {
				v -= 1;
			}
			if (Input.GetKey(up)) {
				v += 1;
			}

//#if !MOBILE_INPUT
			float handbrake = CrossPlatformInputManager.GetAxis("Jump");
			m_Car.Move(h, v, v, handbrake);
            
//#else
            m_Car.Move(h, v, v, 0f);
//#endif
        }
    }
}
