using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBuilder : MonoBehaviour, IRoomBuilder
{
    private Room room;

    public RoomBuilder()
    {
        room = new();
    }
    
    public IRoomBuilder BuildTV()
    {
        room.tv = true;
        return this;
    }
    public IRoomBuilder BuildTable()
    {
        room.table = true;
        return this;
    }
    public IRoomBuilder BuildChair()
    {
        room.chair = true;
        return this;
    }
    public IRoomBuilder BuildSofa()
    {
        room.sofa = true;
        return this;
    }
    public IRoomBuilder BuildArmchair()
    {
        room.armchair = true;
        return this;
    }
    public IRoomBuilder BuildCarpet()
    {
        room.carpet = true;
        return this;
    }
    public IRoomBuilder BuildWardrobe()
    {
        room.wardrobe = true;
        return this;
    }

    public Room GetRoom()
    {
        Room room = this.room;
        this.room = new();
        return room;
    }
}
   