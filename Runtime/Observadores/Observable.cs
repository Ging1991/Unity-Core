using System.Collections.Generic;

namespace Ging1991.Core.Observadores {

	public class Observable<T> {

		private readonly List<IObservador<T>> observadores = new();

		public void Suscribir(IObservador<T> observador) {
			if (!observadores.Contains(observador))
				observadores.Add(observador);
		}

		public void Desuscribir(IObservador<T> observador) {
			observadores.Remove(observador);
		}

		public void Notificar(T valor) {
			foreach (var observador in observadores) {
				observador.Notificar(valor);
			}
		}

	}

}