﻿using System;
namespace GameProject
{
	public interface IGamerService 
	{
		void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}

