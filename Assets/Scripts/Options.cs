using System;

public static class Options 
{
    //public static Options Instance { get; private set; }
    public static float Speed { get; set; }
    public static float Distance { get; set; }
    public static float SpawnInterval { get; set; }

    //private void Awake()
    //{
    //    if (Instance == null)
    //        Instance = this;
    //    else
    //        Destroy(GetComponent<Options>());
    //}
}
