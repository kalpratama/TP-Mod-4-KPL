using System;

class KodePos
{
    public string getKodePos(string kelurahan)
    {
        switch (kelurahan)
        {
            case "Batununggal":
                return "40266";
            case "Kujangsari":
                return "40287";
            case "Mengger":
                return "40267";
            case "Wates":
                return "40256";
            case "Cijaura":
                return "40287";
            case "Jatisari":
                return "40286";
            case "Margasari":
                return "40286";
            case "Sekejati":
                return "40286";
            case "Kebonwaru":
                return "40272";
            case "Maleer":
                return "40274";
            case "Samoja":
                return "40273";
            default:
                return "Kode Pos tidak ditemukan";
        }
    }
}

class DoorMachine
{
    private DoorState currentState;

    public DoorMachine()
    {
        // State awal: terkunci
        currentState = new LockedState();
    }

    public void OpenDoor()
    {
        currentState.Open(this);
    }

    public void CloseDoor()
    {
        currentState.Close(this);
    }

    public void DisplayState()
    {
        currentState.DisplayState();
    }

    // State interface
    private interface DoorState
    {
        void Open(DoorMachine doorMachine);
        void Close(DoorMachine doorMachine);
        void DisplayState();
    }

    // Concrete state: Terkunci
    private class LockedState : DoorState
    {
        public void Open(DoorMachine doorMachine)
        {
            Console.WriteLine("Pintu terkunci. Tidak bisa membuka pintu.");
        }

        public void Close(DoorMachine doorMachine)
        {
            Console.WriteLine("Pintu sudah terkunci.");
        }

        public void DisplayState()
        {
            Console.WriteLine("State Pintu: Terkunci");
        }
    }

    // Concrete state: Terbuka
    private class UnlockedState : DoorState
    {
        public void Open(DoorMachine doorMachine)
        {
            Console.WriteLine("Pintu sudah terbuka.");
        }

        public void Close(DoorMachine doorMachine)
        {
            Console.WriteLine("Pintu tidak terkunci.");
        }

        public void DisplayState()
        {
            Console.WriteLine("State Pintu: Terbuka");
        }
    }
}

class Program
{
    static void Main()
    {
        KodePos kodePosInstance = new KodePos();

        string kelurahan = "Batununggal";
        string kodePos = kodePosInstance.getKodePos(kelurahan);

        Console.WriteLine($"Kode Pos untuk kelurahan {kelurahan}: {kodePos}");

        DoorMachine doorMachine = new DoorMachine();

        doorMachine.DisplayState();  
        doorMachine.OpenDoor();    
        doorMachine.CloseDoor();    
        doorMachine.OpenDoor();      
        doorMachine.DisplayState();  
        doorMachine.CloseDoor();
    }
}

