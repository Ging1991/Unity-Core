using System.Collections.Generic;
using Ging1991.Core.Interfaces;

namespace Ging1991.Core {

	public abstract class ProveedorPerezoso<K, V> : IProveedor<K, V> {

		public Dictionary<K, V> elementos = new();

		public V GetElemento(K k) {
			if (!elementos.ContainsKey(k)) {
				elementos.Add(k, GenerarElemento(k));
			}
			return elementos[k];
		}

		public abstract V GenerarElemento(K k);

	}
}