using UnityEngine;
using UnityEngine.SceneManagement;

namespace Ging1991.Core {

	public class BotonCambiarEscena : MonoBehaviour {

		public void Cambiar(string escena) {
			SceneManager.LoadScene(escena);
		}

	}

}