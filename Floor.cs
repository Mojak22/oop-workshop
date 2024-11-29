namespace Domain
{
    class Floor
    {
        private int number;
        private List<List<Room>> roomsInFloor;
        
        public Floor(int number)
        {
            this.number = number;
        }

        public void AddRoomToFloor(Room room, int floor)
        {
            for (int i = floor; i <= roomsInFloor[floor].Count; i++)
            {
                for(int j = 0; j < roomsInFloor[floor].Count; j++ )
                {
                    if (roomsInFloor != null)
                    {
                        roomsInFloor[i].Add(room);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}