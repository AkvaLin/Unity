using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRoomBuilder
{
    IRoomBuilder BuildTV();

    IRoomBuilder BuildTable();

    IRoomBuilder BuildChair();

    IRoomBuilder BuildSofa();

    IRoomBuilder BuildArmchair();

    IRoomBuilder BuildCarpet();
    
    IRoomBuilder BuildWardrobe();
    
    Room GetRoom();
}
