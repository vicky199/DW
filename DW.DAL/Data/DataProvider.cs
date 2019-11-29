using DW.DAL.IData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Npgsql.NameTranslation;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace DW.DAL.Data
{
    public class DataProvider<T> : IDataProvider<T>
    {
        private string _connectionString;

        public DataProvider(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DWConnection");
        }
        public async Task<T> GetT()
        {
            try
            {
                return await _GetT();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task InsertT(params NpgsqlParameter[] parameters)
        {
            try
            {
                await _InsertT(parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<T> _GetT()
        {
           
            return default(T);
        }

        private async Task _InsertT(params NpgsqlParameter[] parameters)
        {
            await using var conn = new NpgsqlConnection(_connectionString);
            await conn.OpenAsync();

            // Insert some data
            await using (var cmd = new NpgsqlCommand("INSERT INTO User (name,lastname) VALUES (@p,@r)", conn))
            {
                //cmd.Parameters.AddRange(parameters);
                cmd.Parameters.AddWithValue("p", "Hello world");
                cmd.Parameters.AddWithValue("r", "Hello world");
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
