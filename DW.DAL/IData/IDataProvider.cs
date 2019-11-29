using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DW.DAL.IData
{
    interface IDataProvider<T>
    {
        Task<T> GetT();

        Task InsertT(params NpgsqlParameter[] parameters);
    }
}
