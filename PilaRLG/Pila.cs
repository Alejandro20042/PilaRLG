using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaRLG
{
    public class Pila
    {
        //crear pila
        private int _cima;
        private int[] listaPila;
        private int _longitudPila = 5;
        //constructor de la pila
        public Pila() 
        {
            _cima = -1;//debido a que en el arreglo la posicion siempre es n-1 (n=numero total de los datos) esto para irse reccoriendo hasta la ultima pocicion de la pila
            listaPila = new int[_longitudPila]; // crear pila vacia
        }

        //saber si la pila esta vacia
        public bool PilaVacia() 
        {
            if (_cima == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //verificar si la pila esta llena
        public bool PilaLlena()
        {
            if ( (_longitudPila-1) == _cima)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // saber la longitud de la pila o tamaño
        public int longitudPila()
        {
            return _longitudPila;
        }
        //conocer la canditad de elementos de la pila
        public int CantidadElementosPila()
        {
            return _cima + 1;
        }
        //obtener el valor que esta en la cima
        public int ValorCima()
        {
            return listaPila[_cima];
        }
        //Insertar valores en la pila 
        public bool InsertarValor(int valor)
        {
            if(PilaLlena())
            {
                return false;
            }
            else
            {
                _cima++;//incrementar en uno cada que inserte debido a que al inicio se encuentra en cero 
                listaPila[_cima] = valor;
                return true;

            }
        }
        //Eliminar o extraer un elemento
        public int extraerElemento()
        {
            if(PilaVacia())
            {
                Console.WriteLine("La pila esta vacia");
                return _cima;//solo para confirmar que la pila esta vacia por el -1
            }
            else
            {
                int ayuda = listaPila[_cima];//obtener el valor de la cima
                _cima--;//tomar el valor real que queda despues de la decrementacion
                return ayuda;//regresamos el valor que Quitamos
            }
        }
    }
}
