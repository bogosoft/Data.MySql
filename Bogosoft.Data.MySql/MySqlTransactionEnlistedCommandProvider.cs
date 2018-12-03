using MySql.Data.MySqlClient;

namespace Bogosoft.Data.MySql
{
    /// <summary>
    /// A MySQL-specific extension of the <see cref="TransactionEnlistedCommandProvider{TConnection, TCommand, TTransaction}"/> class.
    /// </summary>
    public class MySqlTransactionEnlistedCommandProvider : TransactionEnlistedCommandProvider<MySqlConnection, MySqlCommand, MySqlTransaction>
    {
        /// <summary>
        /// Create a new transaction-enlisted command provider. A transaction will be automatically generated,
        /// committed and disposed of by this instance.
        /// </summary>
        /// <param name="connection">
        /// An established database connection against which a transaction will be started and database commands will be generated.
        /// This connection will NOT be disposed of when this instance is disposed of.
        /// </param>
        /// <param name="commitOnDispose">
        /// A value indicating whether or not a transaction started against the given connection
        /// should be committed when this instance is disposed of.
        /// </param>
        public MySqlTransactionEnlistedCommandProvider(MySqlConnection connection, bool commitOnDispose)
            : base(connection, commitOnDispose)
        {
        }

        /// <summary>
        /// Create a new transaction-enlisted command provider.
        /// </summary>
        /// <param name="connection">
        /// An established database connection against which database commands will be generated.
        /// This connection will NOT be disposed of when this instance is disposed of.
        /// </param>
        /// <param name="transaction">
        /// An established database transaction into which newly generated commands will be enlisted.
        /// This transaction will NOT be disposed of when this instance is disposed of.
        /// </param>
        /// <param name="commitOnDispose">
        /// A value indicating whether or not a transaction started against the given connection
        /// should be committed when this instance is disposed of.
        /// </param>
        public MySqlTransactionEnlistedCommandProvider(
            MySqlConnection connection,
            MySqlTransaction transaction,
            bool commitOnDispose
            )
            : base(connection, transaction, commitOnDispose)
        {
        }
    }
}