using BE.Eco.PaymentProcessing.Domain.Constants.Enums;
using System.Data;
using System.Data.SqlClient;

namespace BE.Eco.PaymentProcessing.Infrastructure.Common.SqlConfig.Connection
{
    /// <summary>
    /// Lib Dapper
    /// </summary>
    public class DapperDBMultiConnectionFactory : IDBMultiConnectionFactory
    {
        private readonly IDictionary<DatabaseInstance, string> _connectionDict;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="connectionDict"></param>
        public DapperDBMultiConnectionFactory(IDictionary<DatabaseInstance, string> connectionDict)
        {
            _connectionDict = connectionDict;
        }

        /// <summary>
        /// Create Connect Sql
        /// </summary>
        /// <param name="databaseInstance"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IDbConnection CreateDbConnection(DatabaseInstance databaseInstance)
        {
            string connectionString;
            if (_connectionDict.TryGetValue(databaseInstance, out connectionString!))
            {
                return new SqlConnection(connectionString);
            }

            throw new ArgumentNullException();
        }
    }
}
