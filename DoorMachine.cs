using System;

namespace TP_MODUL4_103022400044
{
    public class DoorMachine
    {
        public enum State
        {
            Terkunci,
            Terbuka
        }

        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            TampilkanState();
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                TampilkanState();
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                TampilkanState();
            }
        }

        private void TampilkanState()
        {
            if (currentState == State.Terkunci)
            {
                Console.WriteLine("Pintu terkunci");
            }
            else if (currentState == State.Terbuka)
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }
    }
}