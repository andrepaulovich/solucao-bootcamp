using System;
using System.Collections.Generic;
using Tarefas.DAO;
using Tarefas.DTO;

namespace Tarefas.DAO
{
    public interface IUsuarioDAO
    {   void Atualizar(UsuarioDTO conta);
        List<UsuarioDTO> Consultar();
        UsuarioDTO Autenticar(string email, string senha);
        UsuarioDTO Consultar(int id);
        void Criar(UsuarioDTO conta);
        void Excluir(int id);
    }
}
