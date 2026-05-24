using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using UnityEngine;

namespace Ging1991.Core.Movimiento {

	public class MovimientoConsecutivo : MonoBehaviour, IEjecutable {

		private float velocidad = 0.1f;
		private IEjecutable accion;
		private List<Vector3> posiciones;
		private int indice;
		private PosicionamientoLocal posicionamientoLocal;
		private bool debeRepetir;


		public void Posicionar(List<Vector3> posiciones, float velocidad, IEjecutable accion = null, bool debeRepetir = false) {
			posicionamientoLocal = GetComponent<PosicionamientoLocal>();
			this.posiciones = posiciones;
			this.accion = accion;
			this.velocidad = velocidad;
			this.debeRepetir = debeRepetir;
			indice = 0;
			ProcesarPosicionamiento(posiciones[indice]);
		}


		private void ProcesarPosicionamiento(Vector3 posicion) {
			posicionamientoLocal.Posicionar(posicion, velocidad, this);
		}


		public void Ejecutar() {
			indice++;
			if (indice == posiciones.Count) {
				if (accion != null) {
					accion.Ejecutar();
				}
				if (debeRepetir) {
					indice = 0;
					ProcesarPosicionamiento(posiciones[indice]);
				}
			}
		}

	}

}