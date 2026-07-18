using UnityEngine;

namespace Ging1991.Core {

	public class Unico<T> : MonoBehaviour where T : MonoBehaviour {

		public static T Instancia { get; private set; }
		[SerializeField] private bool esPersistente = true;

		protected virtual void Awake() {
			if (Instancia != null && Instancia != this) {
				Destroy(gameObject);
				return;
			}

			Instancia = this as T;
			if (esPersistente)
				DontDestroyOnLoad(gameObject);
		}
	}

}