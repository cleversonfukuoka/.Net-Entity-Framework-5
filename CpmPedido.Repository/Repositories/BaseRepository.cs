﻿using CpmPedido.Interface;

namespace CpmPedido.Repository
{
    public class BaseRepository
    {
        protected const int TamanhoPagina = 5;

        protected readonly ApplicationDbContext DbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
