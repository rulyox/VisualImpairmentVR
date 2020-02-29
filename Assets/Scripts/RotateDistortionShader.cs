using UnityEngine;

namespace nightowl.DistortionShaderPack {

	public class RotateDistortionShader : MonoBehaviour {

		public Vector3 RotateAxis = Vector3.up;

		void Update() {

			transform.Rotate(RotateAxis, 1f);
			
		}

	}

}
