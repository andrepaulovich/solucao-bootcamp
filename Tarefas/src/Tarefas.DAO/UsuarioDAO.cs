using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using Tarefas.DTO;
using Tarefas.DAO;
using System.Collections.Generic;

namespace Tarefas.DAO
{
    public class UsuarioDAO : BaseDAO, IUsuarioDAO
    {
        public void Criar(UsuarioDTO usuario)
        {
            using (var con = Connection)
            {
                con.Open();
                con.Execute(
                    @"INSERT INTO Usuario
                    (Email, Senha, Nome, Ativo) VALUES
                    (@Email, @Senha, @Nome, @Ativo);", usuario
                );
            }
        }

        public List<UsuarioDTO> Consultar()
        {
            using (var con = Connection)
            {
                con.Open();
                var result = con.Query<UsuarioDTO>(
                    @"SELECT Id, Email, Senha, Nome, Ativo FROM Usuario"
                ).ToList();
                return result;
            }
        }

        public UsuarioDTO Consultar(int id)
        {
            using (var con = Connection)
            {
                con.Open();
                UsuarioDTO result = con.Query<UsuarioDTO>
                (
                    @"SELECT Id, Email, Senha, Nome, Ativo FROM Usuario
                    WHERE Id = @Id", new { id }
                ).First();
                return result;
            }
        }

        public UsuarioDTO Autenticar(string email, string senha)
        {
            using (var con = Connection)
            {
                con.Open();
                UsuarioDTO result = con.Query<UsuarioDTO>
                (
                    @"SELECT Id, Email, Senha, Nome, Ativo FROM Usuario
                    WHERE Email = @Email AND Senha = @Senha AND Ativo = true", new { email, senha }
                ).First();
                return result;
            }
        }

        public void Atualizar(UsuarioDTO usuario)
        {
            using (var con = Connection)
            {
                con.Open();
                con.Execute(
                    @"UPDATE Usuario 
                    SET Email = @Email, Senha = @Senha, Nome = @Nome, Ativo = @Ativo
                    WHERE Id = @Id;", usuario
                );
            }
        }

        public void Excluir(int id)
        {
            using (var con = Connection)
            {
                con.Open();
                con.Execute(
                    @"DELETE FROM Usuario
                    WHERE Id = @Id", new { id }
                );
            }
        }
    }
}