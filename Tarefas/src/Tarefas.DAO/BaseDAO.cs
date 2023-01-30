using Dapper;
using System;
using System.Data.SQLite;

namespace Tarefas.DAO
{
    public abstract class BaseDAO 
    {

        public string DataSourceFile => Environment.CurrentDirectory + "AppTarefasDB.sqlite";
        public SQLiteConnection Connection => new SQLiteConnection("DataSource=" + DataSourceFile);

        public BaseDAO()
        {
            
        }

    }
}