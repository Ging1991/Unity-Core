namespace Ging1991.Core.Observadores {

	public interface IObservador<T> {

		void Notificar(T observable);

	}

}