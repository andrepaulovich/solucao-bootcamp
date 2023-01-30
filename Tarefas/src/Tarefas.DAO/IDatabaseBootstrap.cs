using System;
using System.Collections.Generic;
using Tarefas.DAO;

namespace Tarefas.DAO
{
    public interface IDatabaseBootstrap
    {
        void Setup();
    }
}